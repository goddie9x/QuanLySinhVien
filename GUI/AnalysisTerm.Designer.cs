
namespace GUI
{
    partial class AnalysisTerm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalysisTerm));
            this.AnalysisTermTable = new System.Windows.Forms.DataGridView();
            this.ExportExcel = new System.Windows.Forms.Button();
            this.BackHomeBtn = new System.Windows.Forms.Button();
            this.SubjectSelect = new System.Windows.Forms.ComboBox();
            this.SemesterSelect = new System.Windows.Forms.ComboBox();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.studentQueryText = new System.Windows.Forms.TextBox();
            this.ToggleEditBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AnalysisTermTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnalysisTermTable
            // 
            this.AnalysisTermTable.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.AnalysisTermTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnalysisTermTable.Enabled = false;
            this.AnalysisTermTable.Location = new System.Drawing.Point(175, 67);
            this.AnalysisTermTable.Name = "AnalysisTermTable";
            this.AnalysisTermTable.Size = new System.Drawing.Size(595, 269);
            this.AnalysisTermTable.TabIndex = 0;
            this.AnalysisTermTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnalysisTermTable_CellEndEdit);
            // 
            // ExportExcel
            // 
            this.ExportExcel.BackColor = System.Drawing.Color.Green;
            this.ExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportExcel.ForeColor = System.Drawing.Color.Gold;
            this.ExportExcel.Location = new System.Drawing.Point(461, 370);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Size = new System.Drawing.Size(114, 40);
            this.ExportExcel.TabIndex = 1;
            this.ExportExcel.Text = "Export excel";
            this.ExportExcel.UseVisualStyleBackColor = false;
            this.ExportExcel.Click += new System.EventHandler(this.ExportExcel_Click);
            // 
            // BackHomeBtn
            // 
            this.BackHomeBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.BackHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackHomeBtn.ForeColor = System.Drawing.Color.Gold;
            this.BackHomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackHomeBtn.Image")));
            this.BackHomeBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BackHomeBtn.Location = new System.Drawing.Point(652, 12);
            this.BackHomeBtn.Name = "BackHomeBtn";
            this.BackHomeBtn.Size = new System.Drawing.Size(118, 40);
            this.BackHomeBtn.TabIndex = 2;
            this.BackHomeBtn.Text = "Home";
            this.BackHomeBtn.UseVisualStyleBackColor = false;
            this.BackHomeBtn.Click += new System.EventHandler(this.BackHomeBtn_Click);
            // 
            // SubjectSelect
            // 
            this.SubjectSelect.FormattingEnabled = true;
            this.SubjectSelect.Location = new System.Drawing.Point(6, 50);
            this.SubjectSelect.Name = "SubjectSelect";
            this.SubjectSelect.Size = new System.Drawing.Size(121, 21);
            this.SubjectSelect.TabIndex = 3;
            // 
            // SemesterSelect
            // 
            this.SemesterSelect.FormattingEnabled = true;
            this.SemesterSelect.Location = new System.Drawing.Point(6, 120);
            this.SemesterSelect.Name = "SemesterSelect";
            this.SemesterSelect.Size = new System.Drawing.Size(121, 21);
            this.SemesterSelect.TabIndex = 5;
            // 
            // FilterBtn
            // 
            this.FilterBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.FilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBtn.ForeColor = System.Drawing.Color.Gold;
            this.FilterBtn.Location = new System.Drawing.Point(6, 257);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(121, 31);
            this.FilterBtn.TabIndex = 7;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = false;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Semester";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.ForeColor = System.Drawing.Color.Gold;
            this.StudentLabel.Location = new System.Drawing.Point(5, 165);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(60, 16);
            this.StudentLabel.TabIndex = 10;
            this.StudentLabel.Text = "Student";
            // 
            // studentQueryText
            // 
            this.studentQueryText.Location = new System.Drawing.Point(6, 196);
            this.studentQueryText.Name = "studentQueryText";
            this.studentQueryText.Size = new System.Drawing.Size(100, 20);
            this.studentQueryText.TabIndex = 11;
            // 
            // ToggleEditBtn
            // 
            this.ToggleEditBtn.BackColor = System.Drawing.Color.Green;
            this.ToggleEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleEditBtn.ForeColor = System.Drawing.Color.Gold;
            this.ToggleEditBtn.Location = new System.Drawing.Point(323, 370);
            this.ToggleEditBtn.Name = "ToggleEditBtn";
            this.ToggleEditBtn.Size = new System.Drawing.Size(107, 40);
            this.ToggleEditBtn.TabIndex = 12;
            this.ToggleEditBtn.Text = "Toggle edit";
            this.ToggleEditBtn.UseVisualStyleBackColor = false;
            this.ToggleEditBtn.Click += new System.EventHandler(this.ToggleEditBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SubjectSelect);
            this.groupBox1.Controls.Add(this.FilterBtn);
            this.groupBox1.Controls.Add(this.studentQueryText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StudentLabel);
            this.groupBox1.Controls.Add(this.SemesterSelect);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 306);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manager form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(400, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Filtered List";
            // 
            // AnalysisTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExportExcel);
            this.Controls.Add(this.ToggleEditBtn);
            this.Controls.Add(this.BackHomeBtn);
            this.Controls.Add(this.AnalysisTermTable);
            this.Name = "AnalysisTerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalysisTerm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnalysisTerm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AnalysisTermTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AnalysisTermTable;
        private System.Windows.Forms.Button ExportExcel;
        private System.Windows.Forms.Button BackHomeBtn;
        private System.Windows.Forms.ComboBox SubjectSelect;
        private System.Windows.Forms.ComboBox SemesterSelect;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.TextBox studentQueryText;
        private System.Windows.Forms.Button ToggleEditBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}