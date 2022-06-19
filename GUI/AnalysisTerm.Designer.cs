
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
            ((System.ComponentModel.ISupportInitialize)(this.AnalysisTermTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AnalysisTermTable
            // 
            this.AnalysisTermTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnalysisTermTable.Enabled = false;
            this.AnalysisTermTable.Location = new System.Drawing.Point(43, 73);
            this.AnalysisTermTable.Name = "AnalysisTermTable";
            this.AnalysisTermTable.Size = new System.Drawing.Size(595, 269);
            this.AnalysisTermTable.TabIndex = 0;
            this.AnalysisTermTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnalysisTermTable_CellEndEdit);
            // 
            // ExportExcel
            // 
            this.ExportExcel.Location = new System.Drawing.Point(680, 134);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Size = new System.Drawing.Size(91, 40);
            this.ExportExcel.TabIndex = 1;
            this.ExportExcel.Text = "Export excel";
            this.ExportExcel.UseVisualStyleBackColor = true;
            this.ExportExcel.Click += new System.EventHandler(this.ExportExcel_Click);
            // 
            // BackHomeBtn
            // 
            this.BackHomeBtn.Location = new System.Drawing.Point(680, 12);
            this.BackHomeBtn.Name = "BackHomeBtn";
            this.BackHomeBtn.Size = new System.Drawing.Size(91, 40);
            this.BackHomeBtn.TabIndex = 2;
            this.BackHomeBtn.Text = "Home";
            this.BackHomeBtn.UseVisualStyleBackColor = true;
            this.BackHomeBtn.Click += new System.EventHandler(this.BackHomeBtn_Click);
            // 
            // SubjectSelect
            // 
            this.SubjectSelect.FormattingEnabled = true;
            this.SubjectSelect.Location = new System.Drawing.Point(43, 30);
            this.SubjectSelect.Name = "SubjectSelect";
            this.SubjectSelect.Size = new System.Drawing.Size(121, 21);
            this.SubjectSelect.TabIndex = 3;
            // 
            // SemesterSelect
            // 
            this.SemesterSelect.FormattingEnabled = true;
            this.SemesterSelect.Location = new System.Drawing.Point(170, 30);
            this.SemesterSelect.Name = "SemesterSelect";
            this.SemesterSelect.Size = new System.Drawing.Size(141, 21);
            this.SemesterSelect.TabIndex = 5;
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(460, 12);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(91, 40);
            this.FilterBtn.TabIndex = 7;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Semester";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Location = new System.Drawing.Point(314, 12);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(44, 13);
            this.StudentLabel.TabIndex = 10;
            this.StudentLabel.Text = "Student";
            // 
            // studentQueryText
            // 
            this.studentQueryText.Location = new System.Drawing.Point(317, 30);
            this.studentQueryText.Name = "studentQueryText";
            this.studentQueryText.Size = new System.Drawing.Size(100, 20);
            this.studentQueryText.TabIndex = 11;
            // 
            // ToggleEditBtn
            // 
            this.ToggleEditBtn.Location = new System.Drawing.Point(680, 73);
            this.ToggleEditBtn.Name = "ToggleEditBtn";
            this.ToggleEditBtn.Size = new System.Drawing.Size(91, 40);
            this.ToggleEditBtn.TabIndex = 12;
            this.ToggleEditBtn.Text = "Toggle edit";
            this.ToggleEditBtn.UseVisualStyleBackColor = true;
            this.ToggleEditBtn.Click += new System.EventHandler(this.ToggleEditBtn_Click);
            // 
            // AnalysisTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToggleEditBtn);
            this.Controls.Add(this.studentQueryText);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.SemesterSelect);
            this.Controls.Add(this.SubjectSelect);
            this.Controls.Add(this.BackHomeBtn);
            this.Controls.Add(this.ExportExcel);
            this.Controls.Add(this.AnalysisTermTable);
            this.Name = "AnalysisTerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalysisTerm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnalysisTerm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AnalysisTermTable)).EndInit();
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
    }
}