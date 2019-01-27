namespace VeinRecognition
{
    partial class VeinRecognition
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rcLog = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btLoadDataTraining = new System.Windows.Forms.Button();
            this.btExtract = new System.Windows.Forms.Button();
            this.btLoadDataTesting = new System.Windows.Forms.Button();
            this.btCompare = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pbTesting = new System.Windows.Forms.PictureBox();
            this.pbTraining = new System.Windows.Forms.PictureBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTesting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.64151F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.35849F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1325, 636);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rcLog, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(886, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(436, 630);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rcLog
            // 
            this.rcLog.Location = new System.Drawing.Point(3, 425);
            this.rcLog.Name = "rcLog";
            this.rcLog.Size = new System.Drawing.Size(430, 202);
            this.rcLog.TabIndex = 1;
            this.rcLog.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 205);
            this.dataGridView1.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.btLoadDataTraining, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btExtract, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btLoadDataTesting, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btCompare, 1, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(430, 205);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // btLoadDataTraining
            // 
            this.btLoadDataTraining.Location = new System.Drawing.Point(3, 3);
            this.btLoadDataTraining.Name = "btLoadDataTraining";
            this.btLoadDataTraining.Size = new System.Drawing.Size(137, 23);
            this.btLoadDataTraining.TabIndex = 0;
            this.btLoadDataTraining.Text = "Load Img Training";
            this.btLoadDataTraining.UseVisualStyleBackColor = true;
            this.btLoadDataTraining.Click += new System.EventHandler(this.btLoadDataTraining_Click);
            // 
            // btExtract
            // 
            this.btExtract.Location = new System.Drawing.Point(146, 3);
            this.btExtract.Name = "btExtract";
            this.btExtract.Size = new System.Drawing.Size(137, 23);
            this.btExtract.TabIndex = 1;
            this.btExtract.Text = "Extract Feature";
            this.btExtract.UseVisualStyleBackColor = true;
            this.btExtract.Click += new System.EventHandler(this.btExtract_Click);
            // 
            // btLoadDataTesting
            // 
            this.btLoadDataTesting.Location = new System.Drawing.Point(3, 37);
            this.btLoadDataTesting.Name = "btLoadDataTesting";
            this.btLoadDataTesting.Size = new System.Drawing.Size(137, 23);
            this.btLoadDataTesting.TabIndex = 2;
            this.btLoadDataTesting.Text = "Load Img Testing";
            this.btLoadDataTesting.UseVisualStyleBackColor = true;
            this.btLoadDataTesting.Click += new System.EventHandler(this.btLoadDataTesting_Click);
            // 
            // btCompare
            // 
            this.btCompare.Location = new System.Drawing.Point(146, 37);
            this.btCompare.Name = "btCompare";
            this.btCompare.Size = new System.Drawing.Size(137, 23);
            this.btCompare.TabIndex = 3;
            this.btCompare.Text = "Compare";
            this.btCompare.UseVisualStyleBackColor = true;
            this.btCompare.Click += new System.EventHandler(this.btCompare_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.progress, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(877, 630);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.pbTesting, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pbTraining, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(871, 590);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // pbTesting
            // 
            this.pbTesting.Location = new System.Drawing.Point(438, 3);
            this.pbTesting.Name = "pbTesting";
            this.pbTesting.Size = new System.Drawing.Size(429, 584);
            this.pbTesting.TabIndex = 1;
            this.pbTesting.TabStop = false;
            // 
            // pbTraining
            // 
            this.pbTraining.Location = new System.Drawing.Point(3, 3);
            this.pbTraining.Name = "pbTraining";
            this.pbTraining.Size = new System.Drawing.Size(429, 584);
            this.pbTraining.TabIndex = 0;
            this.pbTraining.TabStop = false;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(3, 599);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(871, 23);
            this.progress.TabIndex = 1;
            // 
            // VeinRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VeinRecognition";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTesting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraining)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox rcLog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btLoadDataTraining;
        private System.Windows.Forms.Button btExtract;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pbTesting;
        private System.Windows.Forms.PictureBox pbTraining;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btLoadDataTesting;
        private System.Windows.Forms.Button btCompare;
    }
}

