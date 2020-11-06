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
        public int Tcycle = 10;
        public decimal Tetta = 512.0m;
        public decimal population = 0.0m;
        public decimal InfectedCount = 0.0m;
        public decimal SusceptibleCount = 0.0m;
        public decimal RecoveredCount = 0.0m;
        public decimal InfectedControllCount = 0.0m;
        public decimal SusceptibleControllCount = 0.0m;
        public decimal RecoveredControllCount = 0.0m;
        public decimal InfectedSemiControllCount = 0.0m;
        public decimal SusceptibleSemiControllCount = 0.0m;
        public decimal RecoveredSemiControllCount = 0.0m;
        public int infectedCells = 0;
        public int infectedCellsC = 0;
        public int infectedCellsCS = 0;
        Function f;
        public int N1 = 0;        
        private List<CellStateVectorVM[,]> Cell;
        private List<CellStateVectorVM[,]> CellControlled;
        private List<CellStateVectorVM[,]> CellSemiLinear;
        public CellStateVectorVM[,] SetInit;

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
        public CellStateVectorVM[,] Epidemia(CellStateVectorVM[,] ArrayStart, ref int infectCells)
        {
            InfectedCount = 0.0m;
            SusceptibleCount = 0.0m;
            RecoveredCount = 0.0m;
            InfectedControllCount = 0.0m;
            SusceptibleControllCount = 0.0m;
            RecoveredControllCount = 0.0m;
            InfectedSemiControllCount = 0.0m;
            SusceptibleSemiControllCount = 0.0m;
            RecoveredSemiControllCount = 0.0m;
            infectCells = 0;
           
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
                    infectCells += epidemiaRecalcStart[i, j].Infected != 0 ? 1 : 0;
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
        public void SetInitialFromFile(CellStateVectorVM [,] init)
        {
            SetInit = new CellStateVectorVM[f.HeightImg, f.WidthImg];
            for (int i = 0; i < f.HeightImg; i++)
                for (int j = 0; j < f.WidthImg; j++)                
                    SetInit[i, j] = init[i, j];
        }       
        private void Print(CellStateVectorVM[,] A, CellStateVectorVM[,] C = null, CellStateVectorVM[,] CS = null)
        {
            CreateBitmapAtRuntime(A,C,CS);
        }        
        public void CreateBitmapAtRuntime(CellStateVectorVM[,] A, CellStateVectorVM[,] C = null, CellStateVectorVM[,] CS = null)
        {
            HeightField = f.HeightImg;
            WidthField = f.WidthImg;            
            var scale = f.scale; 
            var size = new Size((WidthField + 10) * 4 * scale, (HeightField + 10) * 4 * scale);
            pictureBox1.Size = size;
            //DrawingPanel.Size = size;            
            DrawingPanel.Controls.Add(pictureBox1);           

            Bitmap myAutomataField = new Bitmap((WidthField+10)*4 * scale, (HeightField+10) *4* scale);           

            Graphics flagGraphics = Graphics.FromImage(myAutomataField);
            
            for (int j = 0; j < WidthField; j++)            
                for (int i = 0; i < HeightField; i++)
                {
                    int colorOfSusceptible = Convert.ToInt32((A[i, j].Susceptible) * 255);
                    int colorOfInfected = Convert.ToInt32((A[i, j].Infected) * 255);
                    int colorOfRecovered = Convert.ToInt32((A[i, j].Recovered) * 255);

                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(colorOfInfected, colorOfRecovered, colorOfSusceptible)), j * scale, i * scale, scale, scale);

                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(colorOfInfected, 0, 0)), j * scale, (i + HeightField) * scale + 10, scale, scale);
                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, colorOfSusceptible)), j * scale, (i + 2 * HeightField) * scale + 20, scale, scale);
                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(0, colorOfRecovered, 0)), j * scale, (i + 3 * HeightField) * scale + 30, scale, scale);
                }
            if (C != null)
            {
                for (int j = 0; j < WidthField; j++)
                    for (int i = 0; i < HeightField; i++)
                    {
                        int colorOfSusceptible = Convert.ToInt32((C[i, j].Susceptible) * 255);
                        int colorOfInfected = Convert.ToInt32((C[i, j].Infected) * 255);
                        int colorOfRecovered = Convert.ToInt32((C[i, j].Recovered) * 255);

                        flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(colorOfInfected, colorOfRecovered, colorOfSusceptible)), (j + WidthField) * scale + 10, i * scale, scale, scale);

                        flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(colorOfInfected, 0, 0)), (j + WidthField) * scale + 10, (i + HeightField) * scale + 10, scale, scale);
                        flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, colorOfSusceptible)), (j + WidthField) * scale + 10, (i + 2 * HeightField) * scale + 20, scale, scale);
                        flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(0, colorOfRecovered, 0)), (j + WidthField) * scale + 10, (i + 3 * HeightField) * scale + 30, scale, scale);
                    }
            }
            if (CS != null)
            {
                for (int j = 0; j < WidthField; j++)
                    for (int i = 0; i < HeightField; i++)
                    {
                        int colorOfSusceptible = Convert.ToInt32((CS[i, j].Susceptible) * 255);
                        int colorOfInfected = Convert.ToInt32((CS[i, j].Infected) * 255);
                        int colorOfRecovered = Convert.ToInt32((CS[i, j].Recovered) * 255);

                        flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(colorOfInfected, colorOfRecovered, colorOfSusceptible)), (j + 2 * WidthField) * scale + 20, i * scale, scale, scale);

                        flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(colorOfInfected, 0, 0)), (j + 2 * WidthField) * scale + 20, (i + HeightField) * scale + 10, scale, scale);
                        flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, colorOfSusceptible)), (j + 2 * WidthField) * scale + 20, (i + 2 * HeightField) * scale + 20, scale, scale);
                        flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(0, colorOfRecovered, 0)), (j + 2 * WidthField) * scale + 20, (i + 3 * HeightField) * scale + 30, scale, scale);
                    }
            }


            var commonRate = InfectedCount + SusceptibleCount + RecoveredCount;
            var commonControlledRate = InfectedControllCount + SusceptibleControllCount + RecoveredControllCount;
            var commonSemiControlledRate = InfectedSemiControllCount + SusceptibleSemiControllCount + RecoveredSemiControllCount;

            if (commonRate != 0)
            {
                InfectedRateLbl.Text = $"{InfectedCount * 100 / commonRate}%";
                SusceptibleRateLbl.Text = $"{SusceptibleCount * 100 / commonRate}%";
                RecoveredRateLbl.Text = $"{RecoveredCount * 100 / commonRate}%";
            }
            if (commonControlledRate != 0)
            {
                infectedClbl.Text = $"{InfectedControllCount * 100 / commonControlledRate}%";
                susceptibleClbl.Text = $"{SusceptibleControllCount * 100 / commonControlledRate}%";
                recoveredClbl.Text = $"{RecoveredControllCount * 100 / commonControlledRate}%";
            }
            if (commonSemiControlledRate != 0)
            {
                infectedCSemilbl.Text = $"{InfectedSemiControllCount * 100 / commonSemiControlledRate}%";
                susceptibleCSemilbl.Text = $"{SusceptibleSemiControllCount * 100 / commonSemiControlledRate}%";
                recoveredCSemilbl.Text = $"{RecoveredSemiControllCount * 100 / commonSemiControlledRate}%";
            }
            infectedCellsTB.Text = infectedCells.ToString();
            infectedCellsClbl.Text = infectedCellsC.ToString();
            infectedCellsCSemilbl.Text = infectedCellsCS.ToString();

            //flagGraphics.DrawString($"Infected: {InfectedCount.ToString()}", new Font("Microsoft Sans Serif", 20, GraphicsUnit.Point), new SolidBrush(Color.Red), scale, (2 * HeightField) * scale + 20);
            //flagGraphics.DrawString($"Susceptible: {SusceptibleCount.ToString()}", new Font("Microsoft Sans Serif", 20, GraphicsUnit.Point), new SolidBrush(Color.Blue), scale, (2 * HeightField) * scale + 40);
            //flagGraphics.DrawString($"Recovered: {RecoveredCount.ToString()}", new Font("Microsoft Sans Serif", 20, GraphicsUnit.Point), new SolidBrush(Color.Green), scale, (2 * HeightField) * scale + 60);


            pictureBox1.Image = myAutomataField;           
        }
        public CellStateVectorVM[,] FeedBackControlSemiLinear()
        {
            var X_nonL = new List<CellStateVectorVM[,]>();
            var X_L = new List<CellStateVectorVM[,]>();
            var optCoeff = new List<decimal>();

            for (int i = 1; i <= 10; i++)
            {
                X_nonL.Add(CellSemiLinear[N1 - i * Tcycle + Tcycle]);
                X_L.Add(CellSemiLinear[N1 - i * Tcycle + 1]);
            }

            optCoeff.Add(0.6327m);
            optCoeff.Add(0.1211m);
            optCoeff.Add(0.0676m);
            optCoeff.Add(0.0466m);
            optCoeff.Add(0.0354m);
            optCoeff.Add(0.0284m);
            optCoeff.Add(0.0237m);
            optCoeff.Add(0.02m);
            optCoeff.Add(0.0166m);
            optCoeff.Add(0.0079m);
            var gamma = 0.1m; var div = 19.0m;          

            HeightField = f.HeightImg;
            WidthField = f.WidthImg;

            var Xn_average = new CellStateVectorVM[HeightField, WidthField];

            var Xn_controled = new CellStateVectorVM[HeightField, WidthField];

            for (int i = 0; i < HeightField; i++)
                for (int j = 0; j < WidthField; j++)
                {
                    var infected = 0.0m;var susceptible = 0.0m;var recovered = 0.0m;
                    for (int k = 0; k < 10; k++)
                    {
                        infected += optCoeff[k] * X_nonL[k][i, j].Infected;
                        susceptible += optCoeff[k] * X_nonL[k][i, j].Susceptible;
                        recovered += optCoeff[k] * X_nonL[k][i, j].Recovered;
                    }
                    Xn_average[i, j] = new CellStateVectorVM()
                        {
                            Infected = infected,
                            Susceptible = susceptible,
                            Recovered = recovered

                        };
                }

            var Xl_average = new CellStateVectorVM[HeightField, WidthField];

            for (int i = 0; i < HeightField; i++)
                for (int j = 0; j < WidthField; j++)
                {
                    var infected = 0.0m; var susceptible = 0.0m; var recovered = 0.0m;
                    for (int k = 0; k < 9; k++)
                    {
                        infected += 2 / div * X_nonL[k][i, j].Infected;
                        susceptible += 2 / div * X_nonL[k][i, j].Susceptible;
                        recovered += 2 / div * X_nonL[k][i, j].Recovered;
                    }
                    infected += 1 / div * X_nonL[9][i, j].Infected;
                    susceptible += 1 / div * X_nonL[9][i, j].Susceptible;
                    recovered += 1 / div * X_nonL[9][i, j].Recovered;
                    Xn_average[i, j] = new CellStateVectorVM()
                    {
                        Infected = infected,
                        Susceptible = susceptible,
                        Recovered = recovered

                    };                    
                }
            var infectCells = 0;
            var temp = Epidemia(Xn_average,ref infectCells);

            for (int i = 0; i < HeightField; i++)
                for (int j = 0; j < WidthField; j++)
                {
                    Xn_controled[i, j] = new CellStateVectorVM()
                    {
                        Infected = (1 - gamma) * temp[i, j].Infected + gamma * Xl_average[i, j].Infected,
                        Susceptible = (1 - gamma) * temp[i, j].Susceptible + gamma * Xl_average[i, j].Susceptible,
                        Recovered = (1 - gamma) * temp[i, j].Recovered + gamma * Xl_average[i, j].Recovered
                    };
                }

            return Xn_controled;           
        }
        public CellStateVectorVM[,] FeedbackControl3()
        {
            var div = 3.0m; var a1 = 0.56m; var a2 = 0.33m; var a3 = 0.11m;
            var recalc = new CellStateVectorVM[f.HeightImg, f.WidthImg];
            for (int i = 0; i < f.HeightImg; i++)
                for (int j = 0; j < f.WidthImg; j++)
                {
                    recalc[i, j] = new CellStateVectorVM()
                    {
                        Infected = a1 * CellControlled[N1][i, j].Infected + a2 * CellSemiLinear[N1 - 1][i, j].Infected + a3 * CellControlled[N1 - 2][i, j].Infected,
                        Susceptible = a1 * CellControlled[N1][i, j].Susceptible + a2 * CellSemiLinear[N1 - 1][i, j].Susceptible + a3 * CellControlled[N1 - 2][i, j].Susceptible,
                        Recovered = a1 * CellControlled[N1][i, j].Recovered + a2 * CellSemiLinear[N1 - 1][i, j].Recovered + a3 * CellControlled[N1 - 2][i, j].Recovered
                    };
                }
            return recalc;
        }
        public CellStateVectorVM[,] FeedBackLinear()
        {
            var Xn = CellSemiLinear[N1];
            var Xn_1 = CellSemiLinear[N1 - 2];
            
            HeightField = f.HeightImg;
            WidthField = f.WidthImg;
            var div = 4.0m;
            decimal a1 = 3/div; decimal a2 = 1/div; 

            var Xn_average = new CellStateVectorVM[HeightField, WidthField];
            var infC = 0;
            for (int i = 0; i < HeightField; i++)
                for (int j = 0; j < WidthField; j++)
                {
                    Xn_average[i, j] = new CellStateVectorVM()
                    {
                        Infected = a1 * CellSemiLinear[N1][i, j].Infected + a2 * CellSemiLinear[N1 - 2][i, j].Infected,
                        Susceptible = a1 * CellSemiLinear[N1][i, j].Susceptible + a2 * CellSemiLinear[N1 - 2][i, j].Susceptible,
                        Recovered = a1 * CellSemiLinear[N1][i, j].Recovered + a2 * CellSemiLinear[N1 - 2][i, j].Recovered,
                    };
                }
            return Epidemia(Xn_average,ref infC);
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
                        Infected = (2 / div) * CellControlled[N1][i, j].Infected + (1 / div) * CellControlled[N1 - 1][i, j].Infected,
                        Susceptible = (2 / div) * CellControlled[N1][i, j].Susceptible + (1 / div) * CellControlled[N1 - 1][i, j].Susceptible,
                        Recovered = (2 / div) * CellControlled[N1][i, j].Recovered + (1 / div) * CellControlled[N1 - 1][i, j].Recovered
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
            var infectCells = 0;
            var infectCellsSemi = 0;
            var arrayToRecalculate = Cell[N1];//isControl && N1>2 ? FeedbackControl() : Cell[N1];
            var arrayControlled = N1 > 2 ? FeedbackControl() : Cell[N1];

            Cell.Add(Epidemia(arrayToRecalculate, ref infectCells));
            infectedCells = infectCells;

            CellControlled.Add(Epidemia(arrayControlled, ref infectCells));
            infectedCellsC = infectCells;

            var arraySemiControlled = N1 > 3 ? FeedbackControl3() : Cell[N1];//N1 > Tcycle + 10 * Tcycle ? FeedBackLinear(ref infectCellsSemi) : Epidemia(arrayToRecalculate, ref infectCellsSemi);
            //
            CellSemiLinear.Add(Epidemia(arraySemiControlled, ref infectCellsSemi));
            infectedCellsCS = infectCellsSemi;
            N1 += 1;
            iteration += 1;
            IterationLabel.Text = iteration.ToString();

            PopulationEpidemiaCalculation(Cell[N1]);

            Print(Cell[N1], CellControlled[N1], CellSemiLinear[N1]);
            IterationLabel.Text = iteration.ToString();
        }
        private void startTimerButton_Click(object sender, EventArgs e)
        {
            funcSet.Enabled = false;
            if (isFirstLaunch)
            {
                N1 = 0;
                Cell = new List<CellStateVectorVM[,]>();
                CellControlled = new List<CellStateVectorVM[,]>();
                CellSemiLinear = new List<CellStateVectorVM[,]>();
                Print(SetInit);
                Cell.Add(SetInit);
                CellControlled.Add(SetInit);
                CellSemiLinear.Add(SetInit);
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
                    InfectedControllCount += CellControlled[N1][i, j].Infected;
                    SusceptibleControllCount += CellControlled[N1][i, j].Susceptible;
                    RecoveredControllCount += CellControlled[N1][i, j].Recovered;
                    InfectedSemiControllCount += CellControlled[N1][i, j].Infected;
                    SusceptibleSemiControllCount += CellControlled[N1][i, j].Susceptible;
                    RecoveredSemiControllCount += CellControlled[N1][i, j].Recovered;
                }            
        }
        public void WriteLog(CellStateVectorVM[,] logArray)
        {
            var CA_dt = new System.Data.DataTable($"initdata");
            for (int i = 0; i < f.WidthImg; i++)
                CA_dt.Columns.Add();
            for (int i = 0; i < f.HeightImg; i++)
            {
                var dr = CA_dt.NewRow();                
                for (int j = 0; j < f.WidthImg; j++)
                    dr[j] = $"{logArray[i, j].Susceptible}|{logArray[i,j].Infected}|{logArray[i, j].Recovered}";
                CA_dt.Rows.Add(dr);
            }

            var wb = new XLWorkbook();
            wb.Worksheets.Add(CA_dt).Columns().AdjustToContents();

            wb.SaveAs($"../../Uploads/logs/initdata{DateTime.Now.Date.ToString("ddMMyy")}.xlsx");
        }
    }
}
