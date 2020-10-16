using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Conway
{

    public partial class Form1 : Form
    {


        public int HeightField = 0; // field size  
        public int WidthField = 0;
        public int iteration = 0;
        public int Tcycle = 30;
        public decimal Tetta = 512.0m;
        public decimal population = 0.0m;
        public decimal InfectedCount = 0.0m;
        public decimal SusceptibleCount = 0.0m;
        public decimal RecoveredCount = 0.0m;
        public int infectedCells = 0;

        Function f;
        public int N1 = 0;        
        private List<CellStateVectorVM[,]> Cell;
        CellStateVectorVM[,] SetInit;

        public bool isFirstLaunch = true;

        public bool isControl = false;

        PictureBox pictureBox1 = new PictureBox();       
        public Form1()
        {
            InitializeComponent();
            f = new Function(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PanelForSettings_Position();
        }
        public void PanelForSettings_Position()
        {            
            PanelForSettings.Width = this.Width;
            DrawingPanel.Location = new System.Drawing.Point(0, PanelForSettings.Height);
            DrawingPanel.Width = this.Width;
            DrawingPanel.Height = this.Height - PanelForSettings.Height;

        }
        public CellStateVectorVM[,] Epidemia(CellStateVectorVM[,] ArrayStart)
        {
           InfectedCount = 0.0m;
           SusceptibleCount = 0.0m;
           RecoveredCount = 0.0m;
            infectedCells = 0;
            //Algorithm of Cellular Automata Game 2D
            HeightField = f.HeightImg;
            WidthField = f.WidthImg;
            //var ret = new CellStateVectorVM[HeightField, WidthField];
            decimal[] inF = f.innerParameters;
            decimal incode = 0;
            decimal[] weightCoefficient = new decimal[inF.Length];           

            for (int i = 0; i < inF.Length; i++)
                incode += inF[i];

            for (int i = 0; i < inF.Length; i++)
                weightCoefficient[i] = inF[i] / incode;

            var epidemiaRecalcStart = new CellStateVectorVM[HeightField, WidthField];

            for (int i = 0; i < HeightField; i++)
                for (int j = 0; j < WidthField; j++)
                {
                    epidemiaRecalcStart[i, j] = ArrayRecalculated(i, j, weightCoefficient, ArrayStart);
                    infectedCells += epidemiaRecalcStart[i, j].Infected != 0 ? 1 : 0;
                }         

            return epidemiaRecalcStart;
        }       
        public CellStateVectorVM ArrayRecalculated(int i, int j, decimal [] innerCode, CellStateVectorVM[,] array)
        {
            HeightField = f.HeightImg;
            WidthField = f.WidthImg;
            var infectedWithNeighbours = innerCode[0] * array[(i - 1) != -1 ? (i - 1) : (HeightField - 1), (j - 1) != -1 ? (j - 1) : (WidthField - 1)].Infected +
                        innerCode[1] * array[(i - 1) != -1 ? (i - 1) : (HeightField - 1), j].Infected +
                        innerCode[2] * array[(i - 1) != -1 ? (i - 1) : (HeightField - 1), (j + 1) != WidthField ? (j + 1) : 0].Infected +
                        innerCode[7] * array[i, (j - 1) != -1 ? (j - 1) : (WidthField - 1)].Infected +
                        innerCode[3] * array[i, (j + 1) != WidthField ? (j + 1) : 0].Infected +
                        innerCode[6] * array[(i + 1) != HeightField ? (i + 1) : 0, (j - 1) != -1 ? (j - 1) : (WidthField - 1)].Infected +
                        innerCode[5] * array[(i + 1) != HeightField ? (i + 1) : 0, j].Infected +
                        innerCode[4] * array[(i + 1) != HeightField ? (i + 1) : 0, (j + 1) != WidthField ? (j + 1) : 0].Infected;

            var infectedSusceptible = f.nu * array[i, j].Susceptible * (f.alfa * array[i, j].Infected + (1 - f.alfa) * infectedWithNeighbours);
            return new CellStateVectorVM()
            {
                Infected = (1 - f.epsilon) * array[i, j].Infected + infectedSusceptible,
                Susceptible = array[i, j].Susceptible + f.mu* array[i, j].Recovered - infectedSusceptible,
                Recovered = (1-f.mu)*array[i, j].Recovered + f.epsilon * array[i, j].Infected
            }; 
        }
        public decimal Func(decimal y, decimal x)
        {
            var mainFunction = f.allCellf;
            x = f.currentSeparate ? x : x + y;         
            return mainFunction(x,y);            
        }       
        public void SetInitial()
        {
            infectedCells = 0;
            SetInit = new CellStateVectorVM[f.HeightImg, f.WidthImg];
            Random rand = new Random();

            for (int i = 0; i < f.HeightImg; i++)
                for (int j = 0; j < f.WidthImg; j++)
                {
                    var population = (Convert.ToDecimal(rand.Next(100)) + 1) / 101;
                    var S = (Convert.ToDecimal(rand.Next(100)) + 0.01m) / 102;
                    var I = 0.0m;
                    do { I = (Convert.ToDecimal(rand.Next(100)) + 1) / 101; } while (S + I >= 1);
                    SetInit[i, j] = new CellStateVectorVM()
                    {
                        Susceptible = population,//S * population,
                        Infected =0,// I * population,
                        Recovered = 0//(1 - S - I) * population
                    };
                }
            SetInit[f.HeightImg / 2, f.WidthImg / 2] = new CellStateVectorVM()
            {
                Infected = 0.01m * SetInit[f.HeightImg / 2, f.WidthImg / 2].Susceptible,
                Susceptible = 0.99m * SetInit[f.HeightImg / 2, f.WidthImg / 2].Susceptible
            };       
        }        
        public void SetInitialFromImage(CellStateVectorVM [,] init)
        {
            SetInit = new CellStateVectorVM[f.HeightImg, f.WidthImg];
            for (int i = 0; i < f.HeightImg; i++)
                for (int j = 0; j < f.WidthImg; j++)                
                    SetInit[i, j] = init[i, j];
        }       
        private void Print(CellStateVectorVM[,] A)
        {
            CreateBitmapAtRuntime(A);
        }        
        public void CreateBitmapAtRuntime(CellStateVectorVM[,] A)
        {
            HeightField = f.HeightImg;
            WidthField = f.WidthImg;            
            var scale = f.scale;            
            pictureBox1.Size = new Size(WidthField * scale*5 + 30, HeightField*5 * scale + 20);            
            DrawingPanel.Controls.Add(pictureBox1);           

            Bitmap myAutomataField = new Bitmap((WidthField+10)*4 * scale, (HeightField+10) *3* scale);           

            Graphics flagGraphics = Graphics.FromImage(myAutomataField);
            
            for (int j = 0; j < WidthField; j++) 
            {
                for (int i = 0; i < HeightField; i++)
                {
                    int colorOfSusceptible = Convert.ToInt32((A[i, j].Susceptible) * 255);
                    int colorOfInfected = Convert.ToInt32((A[i, j].Infected) * 255);
                    int colorOfRecovered = Convert.ToInt32((A[i, j].Recovered) * 255);

                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(colorOfInfected, colorOfRecovered, colorOfSusceptible)), j * scale, i * scale, scale, scale);

                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(colorOfInfected, 0, 0)), j * scale, (i + HeightField) * scale + 10, scale, scale);
                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, colorOfSusceptible)), (j + WidthField) * scale + 10, (i + HeightField) * scale + 10, scale, scale);
                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(0, colorOfRecovered, 0)), (j + 2 * WidthField) * scale + 20, (i + HeightField) * scale + 10, scale, scale);
                }
            }
          
            //PopulationLabel.Text = InfectedCount.ToString();
            //AveragePopulationLbl.Text= SusceptibleCount.ToString();
            //TcycleCoincidenceLbl.Text = RecoveredCount.ToString();

            var commonRate = InfectedCount + SusceptibleCount + RecoveredCount;
            if (commonRate != 0)
            {
                InfectedRateLbl.Text = $"{InfectedCount * 100 / commonRate}%";
                SusceptibleRateLbl.Text = $"{SusceptibleCount * 100 / commonRate}%";
                RecoveredRateLbl.Text = $"{RecoveredCount * 100 / commonRate}%";
            }
            infectedCellsTB.Text = infectedCells.ToString();
            //flagGraphics.DrawString($"Infected: {InfectedCount.ToString()}", new Font("Microsoft Sans Serif", 20, GraphicsUnit.Point), new SolidBrush(Color.Red), scale, (2 * HeightField) * scale + 20);
            //flagGraphics.DrawString($"Susceptible: {SusceptibleCount.ToString()}", new Font("Microsoft Sans Serif", 20, GraphicsUnit.Point), new SolidBrush(Color.Blue), scale, (2 * HeightField) * scale + 40);
            //flagGraphics.DrawString($"Recovered: {RecoveredCount.ToString()}", new Font("Microsoft Sans Serif", 20, GraphicsUnit.Point), new SolidBrush(Color.Green), scale, (2 * HeightField) * scale + 60);


            pictureBox1.Image = myAutomataField;           
        }
        public CellStateVectorVM[,] FeedbackControl()
        {
            var div = 3.0m;
            var recalc = new CellStateVectorVM[f.HeightImg, f.WidthImg];
            for (int i = 0; i < f.HeightImg; i++)
                for (int j = 0; j < f.WidthImg; j++)
                {
                    recalc[i, j] = new CellStateVectorVM()
                    {
                        Infected = (2 / div) * Cell[N1][i, j].Infected + (1 / div) * Cell[N1 - 1][i, j].Infected,
                        Susceptible = (2 / div) * Cell[N1][i, j].Susceptible + (1 / div) * Cell[N1 - 1][i, j].Susceptible,
                        Recovered = (2 / div) * Cell[N1][i, j].Recovered + (1 / div) * Cell[N1 - 1][i, j].Recovered
                    };
                }
            return recalc;
        }
        private void funcSet_Click(object sender, EventArgs e)
        {
            startTimerButton.Enabled = true;           
            f = new Function(this);                
            f.Show();           
        }      
        private void timer1_Tick(object sender, EventArgs e)
        {
            HeightField = f.HeightImg;
            WidthField = f.WidthImg;
            var arrayToRecalculate = isControl && N1>2 ? FeedbackControl() : Cell[N1];
            Cell.Add(Epidemia(arrayToRecalculate));
            
            N1 += 1;
            iteration += 1;
            IterationLabel.Text = iteration.ToString();

            PopulationEpidemiaCalculation(Cell[N1]);

            Print(Cell[N1]);
            IterationLabel.Text = iteration.ToString();
        }
        private void startTimerButton_Click(object sender, EventArgs e)
        {
            funcSet.Enabled = false;
            if (isFirstLaunch)
            {
                N1 = 0;
                Cell = new List<CellStateVectorVM[,]>();                
                Print(SetInit);
                Cell.Add(SetInit);
                timer1.Enabled = true;
                isFirstLaunch = false;
            }
            timer1.Enabled = true;
        }
        private void stopTimer_Click(object sender, EventArgs e)
        {
            funcSet.Enabled = true;
            timer1.Enabled = false;
        }
        private void Control_btn_Click(object sender, EventArgs e)
        {
            isControl = isControl ? false : true;
            Control_Label.Text = isControl ? "Control is on" : "Control is off";
            Control_Label.ForeColor = isControl ? Color.Green : Color.Red;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            PanelForSettings_Position();
        }
        public void PopulationCalculation(decimal[,] Data)
        {
            var data = Data;
            
            for (int i = 0; i < f.HeightImg; i++)
                for (int j = 0; j < f.WidthImg; j++)
                    population += data[i, j];
           
            var avrPopulation = population / (f.HeightImg * f.WidthImg);                   
            PopulationLabel.Text = population.ToString();
            AveragePopulationLbl.Text = avrPopulation.ToString();            
            
        }
        public void PopulationEpidemiaCalculation(CellStateVectorVM[,] Data)
        {
            var data = Data;

            for (int i = 0; i < f.HeightImg; i++)
                for (int j = 0; j < f.WidthImg; j++)
                {
                    InfectedCount += data[i, j].Infected;
                    SusceptibleCount += data[i, j].Susceptible;
                    RecoveredCount += data[i, j].Recovered;
                }   
        }
    }
}
