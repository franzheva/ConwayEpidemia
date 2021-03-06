﻿namespace Conway
{
    partial class Function
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.useCurrentAsSeparate = new System.Windows.Forms.CheckBox();
            this.AddNewFunctionBtn = new System.Windows.Forms.Button();
            this.CalcFunctionCB = new System.Windows.Forms.ComboBox();
            this.commonAnalyticalCABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cellularAutomataDataSet = new Conway.CellularAutomataDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldsizeHeighttb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scaletb = new System.Windows.Forms.TextBox();
            this.common_AnalyticalCATableAdapter = new Conway.CellularAutomataDataSetTableAdapters.Common_AnalyticalCATableAdapter();
            this.fieldSizeEmpty = new System.Windows.Forms.Label();
            this.ScaleEmpty = new System.Windows.Forms.Label();
            this.UploadInit_btn = new System.Windows.Forms.Button();
            this.fieldsizeWidthtb = new System.Windows.Forms.TextBox();
            this.weightsLbl = new System.Windows.Forms.Label();
            this.EpsilonTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NuTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OmegaTB = new System.Windows.Forms.TextBox();
            this.alfaTBvbn = new System.Windows.Forms.Label();
            this.alfaTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.muTB = new System.Windows.Forms.TextBox();
            this.GenerateTxtFileData = new System.Windows.Forms.Button();
            this.UploadFromXLS = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commonAnalyticalCABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellularAutomataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set Function";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.useCurrentAsSeparate);
            this.panel1.Controls.Add(this.AddNewFunctionBtn);
            this.panel1.Controls.Add(this.CalcFunctionCB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(9, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 81);
            this.panel1.TabIndex = 1;
            // 
            // useCurrentAsSeparate
            // 
            this.useCurrentAsSeparate.AutoSize = true;
            this.useCurrentAsSeparate.Location = new System.Drawing.Point(6, 58);
            this.useCurrentAsSeparate.Name = "useCurrentAsSeparate";
            this.useCurrentAsSeparate.Size = new System.Drawing.Size(249, 17);
            this.useCurrentAsSeparate.TabIndex = 14;
            this.useCurrentAsSeparate.Text = "Use current cell as separate function parameter";
            this.useCurrentAsSeparate.UseVisualStyleBackColor = true;
            this.useCurrentAsSeparate.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // AddNewFunctionBtn
            // 
            this.AddNewFunctionBtn.Location = new System.Drawing.Point(232, 12);
            this.AddNewFunctionBtn.Name = "AddNewFunctionBtn";
            this.AddNewFunctionBtn.Size = new System.Drawing.Size(75, 37);
            this.AddNewFunctionBtn.TabIndex = 13;
            this.AddNewFunctionBtn.Text = "Add New Function";
            this.AddNewFunctionBtn.UseVisualStyleBackColor = true;
            this.AddNewFunctionBtn.Click += new System.EventHandler(this.AddNewFunctionBtn_Click);
            // 
            // CalcFunctionCB
            // 
            this.CalcFunctionCB.DataSource = this.commonAnalyticalCABindingSource;
            this.CalcFunctionCB.DisplayMember = "CA_Name";
            this.CalcFunctionCB.FormattingEnabled = true;
            this.CalcFunctionCB.Location = new System.Drawing.Point(90, 12);
            this.CalcFunctionCB.Name = "CalcFunctionCB";
            this.CalcFunctionCB.Size = new System.Drawing.Size(121, 21);
            this.CalcFunctionCB.TabIndex = 1;
            this.CalcFunctionCB.ValueMember = "CA_Function";
            // 
            // commonAnalyticalCABindingSource
            // 
            this.commonAnalyticalCABindingSource.DataMember = "Common_AnalyticalCA";
            this.commonAnalyticalCABindingSource.DataSource = this.cellularAutomataDataSet;
            // 
            // cellularAutomataDataSet
            // 
            this.cellularAutomataDataSet.DataSetName = "CellularAutomataDataSet";
            this.cellularAutomataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select function:";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(383, 56);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(383, 85);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 4;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 100);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cells Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Recalculation function";
            // 
            // fieldsizeHeighttb
            // 
            this.fieldsizeHeighttb.ForeColor = System.Drawing.Color.DarkGray;
            this.fieldsizeHeighttb.Location = new System.Drawing.Point(367, 162);
            this.fieldsizeHeighttb.Name = "fieldsizeHeighttb";
            this.fieldsizeHeighttb.Size = new System.Drawing.Size(42, 20);
            this.fieldsizeHeighttb.TabIndex = 9;
            this.fieldsizeHeighttb.Text = "Height";
            this.fieldsizeHeighttb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FieldsizeHeighttb_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Set field size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Set scale:";
            // 
            // scaletb
            // 
            this.scaletb.Location = new System.Drawing.Point(367, 202);
            this.scaletb.Name = "scaletb";
            this.scaletb.Size = new System.Drawing.Size(42, 20);
            this.scaletb.TabIndex = 11;
            // 
            // common_AnalyticalCATableAdapter
            // 
            this.common_AnalyticalCATableAdapter.ClearBeforeFill = true;
            // 
            // fieldSizeEmpty
            // 
            this.fieldSizeEmpty.AutoSize = true;
            this.fieldSizeEmpty.ForeColor = System.Drawing.Color.Red;
            this.fieldSizeEmpty.Location = new System.Drawing.Point(292, 185);
            this.fieldSizeEmpty.Name = "fieldSizeEmpty";
            this.fieldSizeEmpty.Size = new System.Drawing.Size(0, 13);
            this.fieldSizeEmpty.TabIndex = 13;
            // 
            // ScaleEmpty
            // 
            this.ScaleEmpty.AutoSize = true;
            this.ScaleEmpty.ForeColor = System.Drawing.Color.Red;
            this.ScaleEmpty.Location = new System.Drawing.Point(292, 225);
            this.ScaleEmpty.Name = "ScaleEmpty";
            this.ScaleEmpty.Size = new System.Drawing.Size(0, 13);
            this.ScaleEmpty.TabIndex = 14;
            // 
            // UploadInit_btn
            // 
            this.UploadInit_btn.Location = new System.Drawing.Point(295, 129);
            this.UploadInit_btn.Name = "UploadInit_btn";
            this.UploadInit_btn.Size = new System.Drawing.Size(163, 23);
            this.UploadInit_btn.TabIndex = 15;
            this.UploadInit_btn.Text = "Upload Initial Data";
            this.UploadInit_btn.UseVisualStyleBackColor = true;
            this.UploadInit_btn.Click += new System.EventHandler(this.UploadInit_btn_Click);
            // 
            // fieldsizeWidthtb
            // 
            this.fieldsizeWidthtb.ForeColor = System.Drawing.Color.DarkGray;
            this.fieldsizeWidthtb.Location = new System.Drawing.Point(415, 162);
            this.fieldsizeWidthtb.Name = "fieldsizeWidthtb";
            this.fieldsizeWidthtb.Size = new System.Drawing.Size(42, 20);
            this.fieldsizeWidthtb.TabIndex = 16;
            this.fieldsizeWidthtb.Text = "Width";
            this.fieldsizeWidthtb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FieldsizeWidthtb_MouseDown);
            // 
            // weightsLbl
            // 
            this.weightsLbl.AutoSize = true;
            this.weightsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightsLbl.ForeColor = System.Drawing.Color.Red;
            this.weightsLbl.Location = new System.Drawing.Point(19, 283);
            this.weightsLbl.Name = "weightsLbl";
            this.weightsLbl.Size = new System.Drawing.Size(0, 16);
            this.weightsLbl.TabIndex = 17;
            // 
            // EpsilonTB
            // 
            this.EpsilonTB.Location = new System.Drawing.Point(192, 132);
            this.EpsilonTB.Name = "EpsilonTB";
            this.EpsilonTB.Size = new System.Drawing.Size(38, 20);
            this.EpsilonTB.TabIndex = 18;
            this.EpsilonTB.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Epsilon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nu";
            // 
            // NuTB
            // 
            this.NuTB.Location = new System.Drawing.Point(192, 158);
            this.NuTB.Name = "NuTB";
            this.NuTB.Size = new System.Drawing.Size(38, 20);
            this.NuTB.TabIndex = 20;
            this.NuTB.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Omega";
            // 
            // OmegaTB
            // 
            this.OmegaTB.Location = new System.Drawing.Point(192, 214);
            this.OmegaTB.Name = "OmegaTB";
            this.OmegaTB.Size = new System.Drawing.Size(38, 20);
            this.OmegaTB.TabIndex = 22;
            this.OmegaTB.Text = "0";
            // 
            // alfaTBvbn
            // 
            this.alfaTBvbn.AutoSize = true;
            this.alfaTBvbn.Location = new System.Drawing.Point(235, 189);
            this.alfaTBvbn.Name = "alfaTBvbn";
            this.alfaTBvbn.Size = new System.Drawing.Size(25, 13);
            this.alfaTBvbn.TabIndex = 25;
            this.alfaTBvbn.Text = "Alfa";
            // 
            // alfaTB
            // 
            this.alfaTB.Location = new System.Drawing.Point(191, 186);
            this.alfaTB.Name = "alfaTB";
            this.alfaTB.Size = new System.Drawing.Size(38, 20);
            this.alfaTB.TabIndex = 24;
            this.alfaTB.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Mu";
            // 
            // muTB
            // 
            this.muTB.Location = new System.Drawing.Point(191, 241);
            this.muTB.Name = "muTB";
            this.muTB.Size = new System.Drawing.Size(38, 20);
            this.muTB.TabIndex = 26;
            this.muTB.Text = "0";
            // 
            // GenerateTxtFileData
            // 
            this.GenerateTxtFileData.Location = new System.Drawing.Point(295, 238);
            this.GenerateTxtFileData.Name = "GenerateTxtFileData";
            this.GenerateTxtFileData.Size = new System.Drawing.Size(161, 33);
            this.GenerateTxtFileData.TabIndex = 28;
            this.GenerateTxtFileData.Text = "Generate init data file";
            this.GenerateTxtFileData.UseVisualStyleBackColor = true;
            this.GenerateTxtFileData.Click += new System.EventHandler(this.GenerateTxtFileData_Click);
            // 
            // UploadFromXLS
            // 
            this.UploadFromXLS.Location = new System.Drawing.Point(294, 277);
            this.UploadFromXLS.Name = "UploadFromXLS";
            this.UploadFromXLS.Size = new System.Drawing.Size(161, 33);
            this.UploadFromXLS.TabIndex = 29;
            this.UploadFromXLS.Text = "Upload from xls file";
            this.UploadFromXLS.UseVisualStyleBackColor = true;
            this.UploadFromXLS.Click += new System.EventHandler(this.UploadFromXLS_Click);
            // 
            // Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 315);
            this.Controls.Add(this.UploadFromXLS);
            this.Controls.Add(this.GenerateTxtFileData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.muTB);
            this.Controls.Add(this.alfaTBvbn);
            this.Controls.Add(this.alfaTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OmegaTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NuTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EpsilonTB);
            this.Controls.Add(this.weightsLbl);
            this.Controls.Add(this.fieldsizeWidthtb);
            this.Controls.Add(this.UploadInit_btn);
            this.Controls.Add(this.ScaleEmpty);
            this.Controls.Add(this.fieldSizeEmpty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scaletb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fieldsizeHeighttb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Function";
            this.Text = "Function";
            this.Load += new System.EventHandler(this.Function_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commonAnalyticalCABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellularAutomataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldsizeHeighttb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scaletb;
        private System.Windows.Forms.ComboBox CalcFunctionCB;
        private System.Windows.Forms.Label label5;
        private CellularAutomataDataSet cellularAutomataDataSet;
        private System.Windows.Forms.BindingSource commonAnalyticalCABindingSource;
        private CellularAutomataDataSetTableAdapters.Common_AnalyticalCATableAdapter common_AnalyticalCATableAdapter;
        private System.Windows.Forms.Button AddNewFunctionBtn;
        private System.Windows.Forms.Label fieldSizeEmpty;
        private System.Windows.Forms.Label ScaleEmpty;
        private System.Windows.Forms.Button UploadInit_btn;
        private System.Windows.Forms.TextBox fieldsizeWidthtb;
        private System.Windows.Forms.CheckBox useCurrentAsSeparate;
        private System.Windows.Forms.Label weightsLbl;
        private System.Windows.Forms.TextBox EpsilonTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NuTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OmegaTB;
        private System.Windows.Forms.Label alfaTBvbn;
        private System.Windows.Forms.TextBox alfaTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox muTB;
        private System.Windows.Forms.Button GenerateTxtFileData;
        private System.Windows.Forms.Button UploadFromXLS;
    }
}