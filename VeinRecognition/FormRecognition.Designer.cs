namespace VeinRecognition
{
    partial class FormRecognition
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
            this.btLoadTraining = new System.Windows.Forms.Button();
            this.btExtraction = new System.Windows.Forms.Button();
            this.btTraining = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.numGrayLevel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numAlpha = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numBeta = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numMinLearningRate = new System.Windows.Forms.NumericUpDown();
            this.btLoadTesting = new System.Windows.Forms.Button();
            this.btTesting = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbTesting = new System.Windows.Forms.PictureBox();
            this.listImageView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTesting = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAccuration = new System.Windows.Forms.Button();
            this.rcAccuration = new System.Windows.Forms.RichTextBox();
            this.imageListResult = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGrayLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLearningRate)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTesting)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLoadTraining
            // 
            this.btLoadTraining.Location = new System.Drawing.Point(3, 178);
            this.btLoadTraining.Name = "btLoadTraining";
            this.btLoadTraining.Size = new System.Drawing.Size(75, 34);
            this.btLoadTraining.TabIndex = 0;
            this.btLoadTraining.Text = "Load Data Training";
            this.btLoadTraining.UseVisualStyleBackColor = true;
            this.btLoadTraining.Click += new System.EventHandler(this.btLoadTraining_Click);
            // 
            // btExtraction
            // 
            this.btExtraction.Enabled = false;
            this.btExtraction.Location = new System.Drawing.Point(3, 120);
            this.btExtraction.Name = "btExtraction";
            this.btExtraction.Size = new System.Drawing.Size(156, 52);
            this.btExtraction.TabIndex = 1;
            this.btExtraction.Text = "Extraction Feature Data Training";
            this.btExtraction.UseVisualStyleBackColor = true;
            this.btExtraction.Click += new System.EventHandler(this.btExtraction_Click);
            // 
            // btTraining
            // 
            this.btTraining.Enabled = false;
            this.btTraining.Location = new System.Drawing.Point(84, 178);
            this.btTraining.Name = "btTraining";
            this.btTraining.Size = new System.Drawing.Size(75, 34);
            this.btTraining.TabIndex = 2;
            this.btTraining.Text = "Training";
            this.btTraining.UseVisualStyleBackColor = true;
            this.btTraining.Click += new System.EventHandler(this.btTraining_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.02621F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.97378F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.29766F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 332);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.numGrayLevel);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.numAlpha);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.numBeta);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.numMinLearningRate);
            this.flowLayoutPanel1.Controls.Add(this.btExtraction);
            this.flowLayoutPanel1.Controls.Add(this.btLoadTraining);
            this.flowLayoutPanel1.Controls.Add(this.btTraining);
            this.flowLayoutPanel1.Controls.Add(this.btLoadTesting);
            this.flowLayoutPanel1.Controls.Add(this.btTesting);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(636, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 326);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // numGrayLevel
            // 
            this.numGrayLevel.Location = new System.Drawing.Point(3, 3);
            this.numGrayLevel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGrayLevel.Name = "numGrayLevel";
            this.numGrayLevel.Size = new System.Drawing.Size(90, 20);
            this.numGrayLevel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gray Level";
            // 
            // numAlpha
            // 
            this.numAlpha.DecimalPlaces = 2;
            this.numAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAlpha.Location = new System.Drawing.Point(3, 29);
            this.numAlpha.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAlpha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAlpha.Name = "numAlpha";
            this.numAlpha.Size = new System.Drawing.Size(90, 20);
            this.numAlpha.TabIndex = 9;
            this.numAlpha.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alpha";
            // 
            // numBeta
            // 
            this.numBeta.DecimalPlaces = 2;
            this.numBeta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numBeta.Location = new System.Drawing.Point(3, 55);
            this.numBeta.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numBeta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numBeta.Name = "numBeta";
            this.numBeta.Size = new System.Drawing.Size(90, 20);
            this.numBeta.TabIndex = 10;
            this.numBeta.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Beta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Minimum Learning Rate";
            // 
            // numMinLearningRate
            // 
            this.numMinLearningRate.DecimalPlaces = 30;
            this.numMinLearningRate.Increment = new decimal(new int[] {
            0,
            0,
            0,
            1835008});
            this.numMinLearningRate.Location = new System.Drawing.Point(3, 94);
            this.numMinLearningRate.Name = "numMinLearningRate";
            this.numMinLearningRate.Size = new System.Drawing.Size(154, 20);
            this.numMinLearningRate.TabIndex = 12;
            this.numMinLearningRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            1835008});
            // 
            // btLoadTesting
            // 
            this.btLoadTesting.Enabled = false;
            this.btLoadTesting.Location = new System.Drawing.Point(3, 218);
            this.btLoadTesting.Name = "btLoadTesting";
            this.btLoadTesting.Size = new System.Drawing.Size(75, 36);
            this.btLoadTesting.TabIndex = 3;
            this.btLoadTesting.Text = "Load Data Testing";
            this.btLoadTesting.UseVisualStyleBackColor = true;
            this.btLoadTesting.Click += new System.EventHandler(this.btLoadTesting_Click);
            // 
            // btTesting
            // 
            this.btTesting.Enabled = false;
            this.btTesting.Location = new System.Drawing.Point(84, 218);
            this.btTesting.Name = "btTesting";
            this.btTesting.Size = new System.Drawing.Size(75, 36);
            this.btTesting.TabIndex = 4;
            this.btTesting.Text = "Testing";
            this.btTesting.UseVisualStyleBackColor = true;
            this.btTesting.Click += new System.EventHandler(this.btTesting_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pbTesting);
            this.flowLayoutPanel2.Controls.Add(this.listImageView);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.tbTesting);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.tbResult);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(626, 326);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // pbTesting
            // 
            this.pbTesting.Location = new System.Drawing.Point(3, 3);
            this.pbTesting.Name = "pbTesting";
            this.pbTesting.Size = new System.Drawing.Size(304, 288);
            this.pbTesting.TabIndex = 0;
            this.pbTesting.TabStop = false;
            // 
            // listImageView
            // 
            this.listImageView.Location = new System.Drawing.Point(313, 3);
            this.listImageView.Name = "listImageView";
            this.listImageView.Size = new System.Drawing.Size(303, 288);
            this.listImageView.TabIndex = 6;
            this.listImageView.UseCompatibleStateImageBehavior = false;
            this.listImageView.DoubleClick += new System.EventHandler(this.listImageView_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Testing";
            // 
            // tbTesting
            // 
            this.tbTesting.Location = new System.Drawing.Point(51, 297);
            this.tbTesting.Name = "tbTesting";
            this.tbTesting.ReadOnly = true;
            this.tbTesting.Size = new System.Drawing.Size(256, 20);
            this.tbTesting.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(356, 297);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(260, 20);
            this.tbResult.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 365);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Testing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Accuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAccuration);
            this.panel1.Controls.Add(this.rcAccuration);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 327);
            this.panel1.TabIndex = 0;
            // 
            // btAccuration
            // 
            this.btAccuration.Enabled = false;
            this.btAccuration.Location = new System.Drawing.Point(348, 207);
            this.btAccuration.Name = "btAccuration";
            this.btAccuration.Size = new System.Drawing.Size(103, 23);
            this.btAccuration.TabIndex = 1;
            this.btAccuration.Text = "Accuration";
            this.btAccuration.UseVisualStyleBackColor = true;
            this.btAccuration.Click += new System.EventHandler(this.btAccuration_Click);
            // 
            // rcAccuration
            // 
            this.rcAccuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcAccuration.Location = new System.Drawing.Point(205, 76);
            this.rcAccuration.Name = "rcAccuration";
            this.rcAccuration.ReadOnly = true;
            this.rcAccuration.Size = new System.Drawing.Size(385, 96);
            this.rcAccuration.TabIndex = 0;
            this.rcAccuration.Text = "100%";
            // 
            // imageListResult
            // 
            this.imageListResult.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListResult.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListResult.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 393);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRecognition";
            this.Text = "Form Recognition";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGrayLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLearningRate)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTesting)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLoadTraining;
        private System.Windows.Forms.Button btExtraction;
        private System.Windows.Forms.Button btTraining;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pbTesting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTesting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btLoadTesting;
        private System.Windows.Forms.Button btTesting;
        private System.Windows.Forms.ListView listImageView;
        private System.Windows.Forms.NumericUpDown numGrayLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numAlpha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numBeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMinLearningRate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rcAccuration;
        private System.Windows.Forms.Button btAccuration;
        private System.Windows.Forms.ImageList imageListResult;
    }
}

