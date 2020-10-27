namespace Conway
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.funcSet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startTimerButton = new System.Windows.Forms.Button();
            this.stopTimer = new System.Windows.Forms.Button();
            this.Control_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PopulationLabel = new System.Windows.Forms.Label();
            this.IterationLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelForSettings = new System.Windows.Forms.Panel();
            this.infectedCellsClbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.recoveredClbl = new System.Windows.Forms.Label();
            this.susceptibleClbl = new System.Windows.Forms.Label();
            this.infectedClbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rlbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.slbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ilbl = new System.Windows.Forms.Label();
            this.infectedCellsTB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RecoveredRateLbl = new System.Windows.Forms.Label();
            this.SusceptibleRateLbl = new System.Windows.Forms.Label();
            this.InfectedRateLbl = new System.Windows.Forms.Label();
            this.ExportPopDataBtn = new System.Windows.Forms.Button();
            this.TcycleCoincidenceLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AveragePopulationLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Control_Label = new System.Windows.Forms.Label();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.PanelForSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // funcSet
            // 
            this.funcSet.Location = new System.Drawing.Point(3, 3);
            this.funcSet.Name = "funcSet";
            this.funcSet.Size = new System.Drawing.Size(79, 23);
            this.funcSet.TabIndex = 3;
            this.funcSet.Text = "Set Function";
            this.funcSet.UseVisualStyleBackColor = true;
            this.funcSet.Click += new System.EventHandler(this.funcSet_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startTimerButton
            // 
            this.startTimerButton.Location = new System.Drawing.Point(203, 3);
            this.startTimerButton.Name = "startTimerButton";
            this.startTimerButton.Size = new System.Drawing.Size(79, 23);
            this.startTimerButton.TabIndex = 6;
            this.startTimerButton.Text = "Start timer";
            this.startTimerButton.UseVisualStyleBackColor = true;
            this.startTimerButton.Click += new System.EventHandler(this.startTimerButton_Click);
            // 
            // stopTimer
            // 
            this.stopTimer.Location = new System.Drawing.Point(288, 3);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(79, 23);
            this.stopTimer.TabIndex = 7;
            this.stopTimer.Text = "Pause timer";
            this.stopTimer.UseVisualStyleBackColor = true;
            this.stopTimer.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // Control_btn
            // 
            this.Control_btn.Location = new System.Drawing.Point(88, 3);
            this.Control_btn.Name = "Control_btn";
            this.Control_btn.Size = new System.Drawing.Size(79, 23);
            this.Control_btn.TabIndex = 8;
            this.Control_btn.Text = "Control";
            this.Control_btn.UseVisualStyleBackColor = true;
            this.Control_btn.Click += new System.EventHandler(this.Control_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(370, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Infected:";
            // 
            // PopulationLabel
            // 
            this.PopulationLabel.AutoSize = true;
            this.PopulationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopulationLabel.ForeColor = System.Drawing.Color.Red;
            this.PopulationLabel.Location = new System.Drawing.Point(474, 7);
            this.PopulationLabel.Name = "PopulationLabel";
            this.PopulationLabel.Size = new System.Drawing.Size(0, 16);
            this.PopulationLabel.TabIndex = 10;
            // 
            // IterationLabel
            // 
            this.IterationLabel.AutoSize = true;
            this.IterationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IterationLabel.Location = new System.Drawing.Point(87, 43);
            this.IterationLabel.Name = "IterationLabel";
            this.IterationLabel.Size = new System.Drawing.Size(15, 16);
            this.IterationLabel.TabIndex = 12;
            this.IterationLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Iteration:";
            // 
            // PanelForSettings
            // 
            this.PanelForSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelForSettings.Controls.Add(this.infectedCellsClbl);
            this.PanelForSettings.Controls.Add(this.label7);
            this.PanelForSettings.Controls.Add(this.recoveredClbl);
            this.PanelForSettings.Controls.Add(this.susceptibleClbl);
            this.PanelForSettings.Controls.Add(this.infectedClbl);
            this.PanelForSettings.Controls.Add(this.label11);
            this.PanelForSettings.Controls.Add(this.rlbl);
            this.PanelForSettings.Controls.Add(this.label13);
            this.PanelForSettings.Controls.Add(this.slbl);
            this.PanelForSettings.Controls.Add(this.label15);
            this.PanelForSettings.Controls.Add(this.ilbl);
            this.PanelForSettings.Controls.Add(this.infectedCellsTB);
            this.PanelForSettings.Controls.Add(this.label5);
            this.PanelForSettings.Controls.Add(this.RecoveredRateLbl);
            this.PanelForSettings.Controls.Add(this.SusceptibleRateLbl);
            this.PanelForSettings.Controls.Add(this.InfectedRateLbl);
            this.PanelForSettings.Controls.Add(this.ExportPopDataBtn);
            this.PanelForSettings.Controls.Add(this.TcycleCoincidenceLbl);
            this.PanelForSettings.Controls.Add(this.label6);
            this.PanelForSettings.Controls.Add(this.AveragePopulationLbl);
            this.PanelForSettings.Controls.Add(this.label4);
            this.PanelForSettings.Controls.Add(this.Control_Label);
            this.PanelForSettings.Controls.Add(this.Control_btn);
            this.PanelForSettings.Controls.Add(this.IterationLabel);
            this.PanelForSettings.Controls.Add(this.funcSet);
            this.PanelForSettings.Controls.Add(this.label3);
            this.PanelForSettings.Controls.Add(this.startTimerButton);
            this.PanelForSettings.Controls.Add(this.PopulationLabel);
            this.PanelForSettings.Controls.Add(this.stopTimer);
            this.PanelForSettings.Controls.Add(this.label1);
            this.PanelForSettings.Location = new System.Drawing.Point(0, 0);
            this.PanelForSettings.Name = "PanelForSettings";
            this.PanelForSettings.Size = new System.Drawing.Size(1251, 104);
            this.PanelForSettings.TabIndex = 13;
            // 
            // infectedCellsClbl
            // 
            this.infectedCellsClbl.AutoSize = true;
            this.infectedCellsClbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infectedCellsClbl.ForeColor = System.Drawing.Color.Red;
            this.infectedCellsClbl.Location = new System.Drawing.Point(955, 75);
            this.infectedCellsClbl.Name = "infectedCellsClbl";
            this.infectedCellsClbl.Size = new System.Drawing.Size(15, 16);
            this.infectedCellsClbl.TabIndex = 33;
            this.infectedCellsClbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(814, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Infected cells number:";
            // 
            // recoveredClbl
            // 
            this.recoveredClbl.AutoSize = true;
            this.recoveredClbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveredClbl.ForeColor = System.Drawing.Color.Green;
            this.recoveredClbl.Location = new System.Drawing.Point(909, 49);
            this.recoveredClbl.Name = "recoveredClbl";
            this.recoveredClbl.Size = new System.Drawing.Size(15, 16);
            this.recoveredClbl.TabIndex = 31;
            this.recoveredClbl.Text = "0";
            // 
            // susceptibleClbl
            // 
            this.susceptibleClbl.AutoSize = true;
            this.susceptibleClbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.susceptibleClbl.ForeColor = System.Drawing.Color.Blue;
            this.susceptibleClbl.Location = new System.Drawing.Point(909, 29);
            this.susceptibleClbl.Name = "susceptibleClbl";
            this.susceptibleClbl.Size = new System.Drawing.Size(15, 16);
            this.susceptibleClbl.TabIndex = 30;
            this.susceptibleClbl.Text = "0";
            // 
            // infectedClbl
            // 
            this.infectedClbl.AutoSize = true;
            this.infectedClbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infectedClbl.ForeColor = System.Drawing.Color.Red;
            this.infectedClbl.Location = new System.Drawing.Point(909, 9);
            this.infectedClbl.Name = "infectedClbl";
            this.infectedClbl.Size = new System.Drawing.Size(15, 16);
            this.infectedClbl.TabIndex = 29;
            this.infectedClbl.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(918, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 28;
            // 
            // rlbl
            // 
            this.rlbl.AutoSize = true;
            this.rlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlbl.ForeColor = System.Drawing.Color.Green;
            this.rlbl.Location = new System.Drawing.Point(814, 49);
            this.rlbl.Name = "rlbl";
            this.rlbl.Size = new System.Drawing.Size(91, 16);
            this.rlbl.TabIndex = 27;
            this.rlbl.Text = "Recovered C:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(918, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 26;
            // 
            // slbl
            // 
            this.slbl.AutoSize = true;
            this.slbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slbl.ForeColor = System.Drawing.Color.Blue;
            this.slbl.Location = new System.Drawing.Point(814, 29);
            this.slbl.Name = "slbl";
            this.slbl.Size = new System.Drawing.Size(94, 16);
            this.slbl.TabIndex = 25;
            this.slbl.Text = "Susceptible C:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(918, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 24;
            // 
            // ilbl
            // 
            this.ilbl.AutoSize = true;
            this.ilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilbl.ForeColor = System.Drawing.Color.Red;
            this.ilbl.Location = new System.Drawing.Point(814, 9);
            this.ilbl.Name = "ilbl";
            this.ilbl.Size = new System.Drawing.Size(70, 16);
            this.ilbl.TabIndex = 23;
            this.ilbl.Text = "Infected C:";
            // 
            // infectedCellsTB
            // 
            this.infectedCellsTB.AutoSize = true;
            this.infectedCellsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infectedCellsTB.ForeColor = System.Drawing.Color.Red;
            this.infectedCellsTB.Location = new System.Drawing.Point(511, 73);
            this.infectedCellsTB.Name = "infectedCellsTB";
            this.infectedCellsTB.Size = new System.Drawing.Size(15, 16);
            this.infectedCellsTB.TabIndex = 22;
            this.infectedCellsTB.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(370, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Infected cells number:";
            // 
            // RecoveredRateLbl
            // 
            this.RecoveredRateLbl.AutoSize = true;
            this.RecoveredRateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveredRateLbl.ForeColor = System.Drawing.Color.Green;
            this.RecoveredRateLbl.Location = new System.Drawing.Point(446, 47);
            this.RecoveredRateLbl.Name = "RecoveredRateLbl";
            this.RecoveredRateLbl.Size = new System.Drawing.Size(15, 16);
            this.RecoveredRateLbl.TabIndex = 20;
            this.RecoveredRateLbl.Text = "0";
            // 
            // SusceptibleRateLbl
            // 
            this.SusceptibleRateLbl.AutoSize = true;
            this.SusceptibleRateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SusceptibleRateLbl.ForeColor = System.Drawing.Color.Blue;
            this.SusceptibleRateLbl.Location = new System.Drawing.Point(446, 27);
            this.SusceptibleRateLbl.Name = "SusceptibleRateLbl";
            this.SusceptibleRateLbl.Size = new System.Drawing.Size(15, 16);
            this.SusceptibleRateLbl.TabIndex = 19;
            this.SusceptibleRateLbl.Text = "0";
            // 
            // InfectedRateLbl
            // 
            this.InfectedRateLbl.AutoSize = true;
            this.InfectedRateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfectedRateLbl.ForeColor = System.Drawing.Color.Red;
            this.InfectedRateLbl.Location = new System.Drawing.Point(446, 7);
            this.InfectedRateLbl.Name = "InfectedRateLbl";
            this.InfectedRateLbl.Size = new System.Drawing.Size(15, 16);
            this.InfectedRateLbl.TabIndex = 18;
            this.InfectedRateLbl.Text = "0";
            // 
            // ExportPopDataBtn
            // 
            this.ExportPopDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportPopDataBtn.Location = new System.Drawing.Point(203, 36);
            this.ExportPopDataBtn.Name = "ExportPopDataBtn";
            this.ExportPopDataBtn.Size = new System.Drawing.Size(164, 23);
            this.ExportPopDataBtn.TabIndex = 17;
            this.ExportPopDataBtn.Text = "Export Population Data";
            this.ExportPopDataBtn.UseVisualStyleBackColor = true;
            // 
            // TcycleCoincidenceLbl
            // 
            this.TcycleCoincidenceLbl.AutoSize = true;
            this.TcycleCoincidenceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcycleCoincidenceLbl.ForeColor = System.Drawing.Color.Green;
            this.TcycleCoincidenceLbl.Location = new System.Drawing.Point(474, 47);
            this.TcycleCoincidenceLbl.Name = "TcycleCoincidenceLbl";
            this.TcycleCoincidenceLbl.Size = new System.Drawing.Size(0, 16);
            this.TcycleCoincidenceLbl.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(370, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Recovered:";
            // 
            // AveragePopulationLbl
            // 
            this.AveragePopulationLbl.AutoSize = true;
            this.AveragePopulationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AveragePopulationLbl.ForeColor = System.Drawing.Color.Blue;
            this.AveragePopulationLbl.Location = new System.Drawing.Point(474, 27);
            this.AveragePopulationLbl.Name = "AveragePopulationLbl";
            this.AveragePopulationLbl.Size = new System.Drawing.Size(0, 16);
            this.AveragePopulationLbl.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(370, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Susceptible:";
            // 
            // Control_Label
            // 
            this.Control_Label.AutoSize = true;
            this.Control_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control_Label.ForeColor = System.Drawing.Color.Red;
            this.Control_Label.Location = new System.Drawing.Point(85, 27);
            this.Control_Label.Name = "Control_Label";
            this.Control_Label.Size = new System.Drawing.Size(94, 16);
            this.Control_Label.TabIndex = 13;
            this.Control_Label.Text = "Control is off";
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Location = new System.Drawing.Point(3, 110);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(1251, 352);
            this.DrawingPanel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1258, 474);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.PanelForSettings);
            this.Name = "Form1";
            this.Text = "Conway";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.PanelForSettings.ResumeLayout(false);
            this.PanelForSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button funcSet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startTimerButton;
        private System.Windows.Forms.Button stopTimer;
        private System.Windows.Forms.Button Control_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PopulationLabel;
        private System.Windows.Forms.Label IterationLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelForSettings;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Label TcycleCoincidenceLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AveragePopulationLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExportPopDataBtn;
        private System.Windows.Forms.Label Control_Label;
        private System.Windows.Forms.Label RecoveredRateLbl;
        private System.Windows.Forms.Label SusceptibleRateLbl;
        private System.Windows.Forms.Label InfectedRateLbl;
        private System.Windows.Forms.Label infectedCellsTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label infectedCellsClbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label recoveredClbl;
        private System.Windows.Forms.Label susceptibleClbl;
        private System.Windows.Forms.Label infectedClbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label rlbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label slbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label ilbl;
    }
}

