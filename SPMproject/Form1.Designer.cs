namespace SPMproject
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonSession = new System.Windows.Forms.Button();
            this.buttonSubject = new System.Windows.Forms.Button();
            this.buttonLecturer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelform1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelform1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelSideMenu.Controls.Add(this.buttonSession);
            this.panelSideMenu.Controls.Add(this.buttonSubject);
            this.panelSideMenu.Controls.Add(this.buttonLecturer);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(221, 689);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // buttonSession
            // 
            this.buttonSession.BackColor = System.Drawing.Color.White;
            this.buttonSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonSession.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSession.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSession.Image = ((System.Drawing.Image)(resources.GetObject("buttonSession.Image")));
            this.buttonSession.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSession.Location = new System.Drawing.Point(0, 250);
            this.buttonSession.Name = "buttonSession";
            this.buttonSession.Size = new System.Drawing.Size(221, 75);
            this.buttonSession.TabIndex = 5;
            this.buttonSession.Text = "Session";
            this.buttonSession.UseVisualStyleBackColor = false;
            this.buttonSession.Click += new System.EventHandler(this.buttonSession_Click);
            // 
            // buttonSubject
            // 
            this.buttonSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSubject.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSubject.FlatAppearance.BorderSize = 3;
            this.buttonSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonSubject.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSubject.Image = ((System.Drawing.Image)(resources.GetObject("buttonSubject.Image")));
            this.buttonSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubject.Location = new System.Drawing.Point(0, 175);
            this.buttonSubject.Name = "buttonSubject";
            this.buttonSubject.Size = new System.Drawing.Size(221, 75);
            this.buttonSubject.TabIndex = 4;
            this.buttonSubject.Text = "Subject";
            this.buttonSubject.UseVisualStyleBackColor = false;
            this.buttonSubject.Click += new System.EventHandler(this.buttonSubject_Click);
            // 
            // buttonLecturer
            // 
            this.buttonLecturer.BackColor = System.Drawing.Color.White;
            this.buttonLecturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLecturer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLecturer.FlatAppearance.BorderSize = 3;
            this.buttonLecturer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonLecturer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonLecturer.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLecturer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLecturer.Image = ((System.Drawing.Image)(resources.GetObject("buttonLecturer.Image")));
            this.buttonLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLecturer.Location = new System.Drawing.Point(0, 100);
            this.buttonLecturer.Name = "buttonLecturer";
            this.buttonLecturer.Size = new System.Drawing.Size(221, 75);
            this.buttonLecturer.TabIndex = 3;
            this.buttonLecturer.Text = "Lecturer(s)";
            this.buttonLecturer.UseVisualStyleBackColor = false;
            this.buttonLecturer.Click += new System.EventHandler(this.buttonLecturer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 100);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelform1
            // 
            this.panelform1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelform1.Controls.Add(this.pictureBox1);
            this.panelform1.Location = new System.Drawing.Point(227, 12);
            this.panelform1.Name = "panelform1";
            this.panelform1.Size = new System.Drawing.Size(1080, 665);
            this.panelform1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 393);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 689);
            this.Controls.Add(this.panelform1);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Home";
            this.Text = "ABC Institute";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelform1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button buttonSession;
        private System.Windows.Forms.Button buttonSubject;
        private System.Windows.Forms.Button buttonLecturer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelform1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

