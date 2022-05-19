
namespace GUI
{
    partial class Home
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
            this.btnStudentMana = new System.Windows.Forms.Button();
            this.btnPresentation = new System.Windows.Forms.Button();
            this.btnTranscript = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentMana
            // 
            this.btnStudentMana.Location = new System.Drawing.Point(162, 118);
            this.btnStudentMana.Name = "btnStudentMana";
            this.btnStudentMana.Size = new System.Drawing.Size(143, 23);
            this.btnStudentMana.TabIndex = 0;
            this.btnStudentMana.Text = "student mângement";
            this.btnStudentMana.UseVisualStyleBackColor = true;
            this.btnStudentMana.Click += new System.EventHandler(this.btnStudentMana_Click);
            // 
            // btnPresentation
            // 
            this.btnPresentation.Location = new System.Drawing.Point(252, 213);
            this.btnPresentation.Name = "btnPresentation";
            this.btnPresentation.Size = new System.Drawing.Size(75, 23);
            this.btnPresentation.TabIndex = 1;
            this.btnPresentation.Text = "presentation";
            this.btnPresentation.UseVisualStyleBackColor = true;
            this.btnPresentation.Click += new System.EventHandler(this.btnPresentation_Click);
            // 
            // btnTranscript
            // 
            this.btnTranscript.Location = new System.Drawing.Point(466, 118);
            this.btnTranscript.Name = "btnTranscript";
            this.btnTranscript.Size = new System.Drawing.Size(75, 23);
            this.btnTranscript.TabIndex = 2;
            this.btnTranscript.Text = "transcrip";
            this.btnTranscript.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(363, 214);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.btnTranscript);
            this.Controls.Add(this.btnPresentation);
            this.Controls.Add(this.btnStudentMana);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentMana;
        private System.Windows.Forms.Button btnPresentation;
        private System.Windows.Forms.Button btnTranscript;
        private System.Windows.Forms.Button logoutBtn;
    }
}