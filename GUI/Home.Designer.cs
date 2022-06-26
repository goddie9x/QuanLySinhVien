
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.presentationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transcriptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.examToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.examToolStripMenuItem1});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(801, 40);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1,
            this.logoutToolStripMenuItem1});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentManagerToolStripMenuItem1,
            this.presentationToolStripMenuItem1,
            this.transcriptToolStripMenuItem1});
            this.optionsToolStripMenuItem1.ForeColor = System.Drawing.Color.Orange;
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(180, 36);
            this.optionsToolStripMenuItem1.Text = "Options";
            // 
            // studentManagerToolStripMenuItem1
            // 
            this.studentManagerToolStripMenuItem1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.studentManagerToolStripMenuItem1.ForeColor = System.Drawing.Color.Orange;
            this.studentManagerToolStripMenuItem1.Name = "studentManagerToolStripMenuItem1";
            this.studentManagerToolStripMenuItem1.Size = new System.Drawing.Size(279, 36);
            this.studentManagerToolStripMenuItem1.Text = "Student manager";
            this.studentManagerToolStripMenuItem1.Click += new System.EventHandler(this.studentManagerToolStripMenuItem1_Click);
            // 
            // presentationToolStripMenuItem1
            // 
            this.presentationToolStripMenuItem1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.presentationToolStripMenuItem1.ForeColor = System.Drawing.Color.Orange;
            this.presentationToolStripMenuItem1.Name = "presentationToolStripMenuItem1";
            this.presentationToolStripMenuItem1.Size = new System.Drawing.Size(279, 36);
            this.presentationToolStripMenuItem1.Text = "Presentation";
            this.presentationToolStripMenuItem1.Click += new System.EventHandler(this.presentationToolStripMenuItem1_Click);
            // 
            // transcriptToolStripMenuItem1
            // 
            this.transcriptToolStripMenuItem1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.transcriptToolStripMenuItem1.ForeColor = System.Drawing.Color.Orange;
            this.transcriptToolStripMenuItem1.Name = "transcriptToolStripMenuItem1";
            this.transcriptToolStripMenuItem1.Size = new System.Drawing.Size(279, 36);
            this.transcriptToolStripMenuItem1.Text = "Transcript";
            this.transcriptToolStripMenuItem1.Click += new System.EventHandler(this.transcriptToolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.logoutToolStripMenuItem1.ForeColor = System.Drawing.Color.Orange;
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(180, 36);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // examToolStripMenuItem1
            // 
            this.examToolStripMenuItem1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.examToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem,
            this.doToolStripMenuItem});
            this.examToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examToolStripMenuItem1.ForeColor = System.Drawing.Color.Orange;
            this.examToolStripMenuItem1.Name = "examToolStripMenuItem1";
            this.examToolStripMenuItem1.Size = new System.Drawing.Size(78, 36);
            this.examToolStripMenuItem1.Text = "Exam";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.managerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.managerToolStripMenuItem.Text = "Manager";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // doToolStripMenuItem
            // 
            this.doToolStripMenuItem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.doToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.doToolStripMenuItem.Name = "doToolStripMenuItem";
            this.doToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.doToolStripMenuItem.Text = "Do";
            this.doToolStripMenuItem.Click += new System.EventHandler(this.doToolStripMenuItem_Click);
            // 
            // examToolStripMenuItem
            // 
            this.examToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doExamToolStripMenuItem,
            this.createToolStripMenuItem});
            this.examToolStripMenuItem.Name = "examToolStripMenuItem";
            this.examToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.examToolStripMenuItem.Text = "Exam";
            // 
            // doExamToolStripMenuItem
            // 
            this.doExamToolStripMenuItem.Name = "doExamToolStripMenuItem";
            this.doExamToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 423);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosed);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentManagerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem presentationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transcriptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem examToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}