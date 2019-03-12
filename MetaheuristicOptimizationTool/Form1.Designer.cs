namespace MetaheuristicOptimizationTool
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnProblem = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpProblem = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCreateFunc = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpAlgorithms = new System.Windows.Forms.GroupBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExcelSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFunction = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExperiments = new System.Windows.Forms.TextBox();
            this.dgwFitnessInf = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbAlgorithms = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCost = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFonkOlustur = new System.Windows.Forms.Button();
            this.grpProblem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpAlgorithms.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFitnessInf)).BeginInit();
            this.grpCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(4, 17);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(513, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnProblem
            // 
            this.btnProblem.Location = new System.Drawing.Point(4, 41);
            this.btnProblem.Margin = new System.Windows.Forms.Padding(2);
            this.btnProblem.Name = "btnProblem";
            this.btnProblem.Size = new System.Drawing.Size(513, 19);
            this.btnProblem.TabIndex = 1;
            this.btnProblem.Text = "Problemi Tanımla / Veri setini yükle";
            this.btnProblem.UseVisualStyleBackColor = true;
            this.btnProblem.Click += new System.EventHandler(this.btnProblem_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(55, 86);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 22);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpProblem
            // 
            this.grpProblem.Controls.Add(this.panel1);
            this.grpProblem.Controls.Add(this.txtFilePath);
            this.grpProblem.Controls.Add(this.btnOk);
            this.grpProblem.Controls.Add(this.btnProblem);
            this.grpProblem.Location = new System.Drawing.Point(9, 10);
            this.grpProblem.Margin = new System.Windows.Forms.Padding(2);
            this.grpProblem.Name = "grpProblem";
            this.grpProblem.Padding = new System.Windows.Forms.Padding(2);
            this.grpProblem.Size = new System.Drawing.Size(522, 160);
            this.grpProblem.TabIndex = 3;
            this.grpProblem.TabStop = false;
            this.grpProblem.Text = "Problem Tanımlama";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnCreateFunc);
            this.panel1.Controls.Add(this.btnContinue);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(161, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 65);
            this.panel1.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(250, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "ya da";
            // 
            // btnCreateFunc
            // 
            this.btnCreateFunc.Location = new System.Drawing.Point(146, 3);
            this.btnCreateFunc.Name = "btnCreateFunc";
            this.btnCreateFunc.Size = new System.Drawing.Size(207, 21);
            this.btnCreateFunc.TabIndex = 4;
            this.btnCreateFunc.Text = ">> Matlab YSA ile fonksiyon oluştur >>";
            this.btnCreateFunc.UseVisualStyleBackColor = true;
            this.btnCreateFunc.Click += new System.EventHandler(this.btnCreateFunc_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(146, 40);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(207, 22);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Hazır fonksiyon kullan (Benchmark)";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(18, 20);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 22);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grpAlgorithms
            // 
            this.grpAlgorithms.BackColor = System.Drawing.SystemColors.Control;
            this.grpAlgorithms.Controls.Add(this.pnlInfo);
            this.grpAlgorithms.Controls.Add(this.label12);
            this.grpAlgorithms.Controls.Add(this.cmbFunction);
            this.grpAlgorithms.Controls.Add(this.label9);
            this.grpAlgorithms.Controls.Add(this.txtExperiments);
            this.grpAlgorithms.Controls.Add(this.dgwFitnessInf);
            this.grpAlgorithms.Controls.Add(this.btnStart);
            this.grpAlgorithms.Controls.Add(this.cmbAlgorithms);
            this.grpAlgorithms.Controls.Add(this.label2);
            this.grpAlgorithms.Location = new System.Drawing.Point(9, 174);
            this.grpAlgorithms.Margin = new System.Windows.Forms.Padding(2);
            this.grpAlgorithms.Name = "grpAlgorithms";
            this.grpAlgorithms.Padding = new System.Windows.Forms.Padding(2);
            this.grpAlgorithms.Size = new System.Drawing.Size(997, 495);
            this.grpAlgorithms.TabIndex = 4;
            this.grpAlgorithms.TabStop = false;
            this.grpAlgorithms.Text = "Metasezgisel Arama";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.label11);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.label10);
            this.pnlInfo.Controls.Add(this.label7);
            this.pnlInfo.Controls.Add(this.label8);
            this.pnlInfo.Controls.Add(this.btnExcelSave);
            this.pnlInfo.Location = new System.Drawing.Point(536, 18);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(456, 128);
            this.pnlInfo.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(2, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Min En iyi Çözüm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(194, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(194, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(194, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "label11";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(194, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(2, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Standart Sapma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(2, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Max En İyi Çözüm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(2, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "En İyi Çözümlerin Ortalaması:";
            // 
            // btnExcelSave
            // 
            this.btnExcelSave.Location = new System.Drawing.Point(2, 98);
            this.btnExcelSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelSave.Name = "btnExcelSave";
            this.btnExcelSave.Size = new System.Drawing.Size(119, 28);
            this.btnExcelSave.TabIndex = 11;
            this.btnExcelSave.Text = "Excel Kaydet";
            this.btnExcelSave.UseVisualStyleBackColor = true;
            this.btnExcelSave.Click += new System.EventHandler(this.btnExcelSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Fonksiyon Seçiniz :";
            // 
            // cmbFunction
            // 
            this.cmbFunction.FormattingEnabled = true;
            this.cmbFunction.Location = new System.Drawing.Point(367, 24);
            this.cmbFunction.Name = "cmbFunction";
            this.cmbFunction.Size = new System.Drawing.Size(150, 21);
            this.cmbFunction.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Deney(Tekrar) Sayısı :";
            // 
            // txtExperiments
            // 
            this.txtExperiments.Location = new System.Drawing.Point(119, 74);
            this.txtExperiments.Margin = new System.Windows.Forms.Padding(2);
            this.txtExperiments.Name = "txtExperiments";
            this.txtExperiments.Size = new System.Drawing.Size(124, 20);
            this.txtExperiments.TabIndex = 12;
            // 
            // dgwFitnessInf
            // 
            this.dgwFitnessInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFitnessInf.Location = new System.Drawing.Point(4, 151);
            this.dgwFitnessInf.Margin = new System.Windows.Forms.Padding(2);
            this.dgwFitnessInf.Name = "dgwFitnessInf";
            this.dgwFitnessInf.RowTemplate.Height = 24;
            this.dgwFitnessInf.Size = new System.Drawing.Size(989, 340);
            this.dgwFitnessInf.TabIndex = 10;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(138, 116);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 27);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbAlgorithms
            // 
            this.cmbAlgorithms.FormattingEnabled = true;
            this.cmbAlgorithms.Location = new System.Drawing.Point(98, 24);
            this.cmbAlgorithms.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAlgorithms.Name = "cmbAlgorithms";
            this.cmbAlgorithms.Size = new System.Drawing.Size(157, 21);
            this.cmbAlgorithms.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Algoritma Seçiniz :";
            // 
            // grpCost
            // 
            this.grpCost.Controls.Add(this.button1);
            this.grpCost.Controls.Add(this.textBox1);
            this.grpCost.Controls.Add(this.btnFonkOlustur);
            this.grpCost.Location = new System.Drawing.Point(545, 10);
            this.grpCost.Margin = new System.Windows.Forms.Padding(2);
            this.grpCost.Name = "grpCost";
            this.grpCost.Padding = new System.Windows.Forms.Padding(2);
            this.grpCost.Size = new System.Drawing.Size(461, 160);
            this.grpCost.TabIndex = 5;
            this.grpCost.TabStop = false;
            this.grpCost.Text = "Maliyet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(451, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnFonkOlustur
            // 
            this.btnFonkOlustur.Location = new System.Drawing.Point(80, 42);
            this.btnFonkOlustur.Name = "btnFonkOlustur";
            this.btnFonkOlustur.Size = new System.Drawing.Size(295, 23);
            this.btnFonkOlustur.TabIndex = 0;
            this.btnFonkOlustur.Text = "Fonksiyon oluşturmak için veri seti yükleyiniz";
            this.btnFonkOlustur.UseVisualStyleBackColor = true;
            this.btnFonkOlustur.Click += new System.EventHandler(this.btnFonkOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 680);
            this.Controls.Add(this.grpCost);
            this.Controls.Add(this.grpAlgorithms);
            this.Controls.Add(this.grpProblem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpProblem.ResumeLayout(false);
            this.grpProblem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpAlgorithms.ResumeLayout(false);
            this.grpAlgorithms.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFitnessInf)).EndInit();
            this.grpCost.ResumeLayout(false);
            this.grpCost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnProblem;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpProblem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpAlgorithms;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbAlgorithms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgwFitnessInf;
        private System.Windows.Forms.Button btnExcelSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExperiments;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnCreateFunc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFunction;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFonkOlustur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}

