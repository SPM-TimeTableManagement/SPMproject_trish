﻿namespace SPMproject
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
            this.buttonTags = new System.Windows.Forms.Button();
            this.buttonStudentList = new System.Windows.Forms.Button();
            this.buttonAddBuilding = new System.Windows.Forms.Button();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonWorking = new System.Windows.Forms.Button();
            this.buttonSubject = new System.Windows.Forms.Button();
            this.buttonLecturer = new System.Windows.Forms.Button();
            this.panelform1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStudentBatch = new System.Windows.Forms.Button();
            this.buttonGenarateID = new System.Windows.Forms.Button();
            this.buttonProgramme = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelform1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelSideMenu.Controls.Add(this.buttonProgramme);
            this.panelSideMenu.Controls.Add(this.buttonGenarateID);
            this.panelSideMenu.Controls.Add(this.buttonStudentList);
            this.panelSideMenu.Controls.Add(this.buttonStudentBatch);
            this.panelSideMenu.Controls.Add(this.buttonLecturer);
            this.panelSideMenu.Controls.Add(this.buttonTags);
            this.panelSideMenu.Controls.Add(this.buttonAddBuilding);
            this.panelSideMenu.Controls.Add(this.buttonAddRoom);
            this.panelSideMenu.Controls.Add(this.buttonWorking);
            this.panelSideMenu.Controls.Add(this.buttonSubject);
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(221, 689);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // buttonTags
            // 
            this.buttonTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTags.Location = new System.Drawing.Point(-3, 358);
            this.buttonTags.Name = "buttonTags";
            this.buttonTags.Size = new System.Drawing.Size(221, 46);
            this.buttonTags.TabIndex = 10;
            this.buttonTags.Text = "Tags";
            this.buttonTags.UseVisualStyleBackColor = true;
            this.buttonTags.Click += new System.EventHandler(this.buttonTags_Click);
            // 
            // buttonStudentList
            // 
            this.buttonStudentList.BackColor = System.Drawing.Color.White;
            this.buttonStudentList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonStudentList.FlatAppearance.BorderSize = 3;
            this.buttonStudentList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonStudentList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonStudentList.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStudentList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentList.Location = new System.Drawing.Point(0, 306);
            this.buttonStudentList.Name = "buttonStudentList";
            this.buttonStudentList.Size = new System.Drawing.Size(221, 46);
            this.buttonStudentList.TabIndex = 9;
            this.buttonStudentList.Text = "Student List";
            this.buttonStudentList.UseVisualStyleBackColor = false;
            this.buttonStudentList.Click += new System.EventHandler(this.buttonStudentList_Click);
            // 
            // buttonAddBuilding
            // 
            this.buttonAddBuilding.BackColor = System.Drawing.Color.White;
            this.buttonAddBuilding.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddBuilding.FlatAppearance.BorderSize = 3;
            this.buttonAddBuilding.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonAddBuilding.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonAddBuilding.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBuilding.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddBuilding.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddBuilding.Location = new System.Drawing.Point(-3, 466);
            this.buttonAddBuilding.Name = "buttonAddBuilding";
            this.buttonAddBuilding.Size = new System.Drawing.Size(221, 46);
            this.buttonAddBuilding.TabIndex = 8;
            this.buttonAddBuilding.Text = "Add Building";
            this.buttonAddBuilding.UseVisualStyleBackColor = false;
            this.buttonAddBuilding.Click += new System.EventHandler(this.buttonAddBuilding_Click);
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRoom.Location = new System.Drawing.Point(0, 518);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(221, 46);
            this.buttonAddRoom.TabIndex = 7;
            this.buttonAddRoom.Text = "Add Room";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // buttonWorking
            // 
            this.buttonWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWorking.Location = new System.Drawing.Point(-3, 410);
            this.buttonWorking.Name = "buttonWorking";
            this.buttonWorking.Size = new System.Drawing.Size(221, 46);
            this.buttonWorking.TabIndex = 6;
            this.buttonWorking.Text = "Working D/H";
            this.buttonWorking.UseVisualStyleBackColor = true;
            this.buttonWorking.Click += new System.EventHandler(this.buttonWorking_Click);
            // 
            // buttonSubject
            // 
            this.buttonSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSubject.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSubject.FlatAppearance.BorderSize = 3;
            this.buttonSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonSubject.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubject.Location = new System.Drawing.Point(0, 98);
            this.buttonSubject.Name = "buttonSubject";
            this.buttonSubject.Size = new System.Drawing.Size(221, 46);
            this.buttonSubject.TabIndex = 4;
            this.buttonSubject.Text = "Subject";
            this.buttonSubject.UseVisualStyleBackColor = false;
            this.buttonSubject.Click += new System.EventHandler(this.buttonSubject_Click);
            // 
            // buttonLecturer
            // 
            this.buttonLecturer.BackColor = System.Drawing.Color.White;
            this.buttonLecturer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLecturer.FlatAppearance.BorderSize = 3;
            this.buttonLecturer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonLecturer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonLecturer.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLecturer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLecturer.Location = new System.Drawing.Point(0, 46);
            this.buttonLecturer.Name = "buttonLecturer";
            this.buttonLecturer.Size = new System.Drawing.Size(221, 46);
            this.buttonLecturer.TabIndex = 3;
            this.buttonLecturer.Text = "Lecturer(s)";
            this.buttonLecturer.UseVisualStyleBackColor = false;
            this.buttonLecturer.Click += new System.EventHandler(this.buttonLecturer_Click);
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
            // buttonStudentBatch
            // 
            this.buttonStudentBatch.BackColor = System.Drawing.Color.White;
            this.buttonStudentBatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonStudentBatch.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentBatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStudentBatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentBatch.Location = new System.Drawing.Point(0, 202);
            this.buttonStudentBatch.Name = "buttonStudentBatch";
            this.buttonStudentBatch.Size = new System.Drawing.Size(221, 46);
            this.buttonStudentBatch.TabIndex = 11;
            this.buttonStudentBatch.Text = "Student Batch";
            this.buttonStudentBatch.UseVisualStyleBackColor = false;
            this.buttonStudentBatch.Click += new System.EventHandler(this.buttonStudentBatch_Click);
            // 
            // buttonGenarateID
            // 
            this.buttonGenarateID.BackColor = System.Drawing.Color.White;
            this.buttonGenarateID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonGenarateID.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenarateID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGenarateID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenarateID.Location = new System.Drawing.Point(0, 254);
            this.buttonGenarateID.Name = "buttonGenarateID";
            this.buttonGenarateID.Size = new System.Drawing.Size(221, 46);
            this.buttonGenarateID.TabIndex = 12;
            this.buttonGenarateID.Text = "Genarate ID";
            this.buttonGenarateID.UseVisualStyleBackColor = false;
            this.buttonGenarateID.Click += new System.EventHandler(this.buttonGenarateID_Click);
            // 
            // buttonProgramme
            // 
            this.buttonProgramme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonProgramme.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonProgramme.FlatAppearance.BorderSize = 3;
            this.buttonProgramme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonProgramme.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProgramme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonProgramme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProgramme.Location = new System.Drawing.Point(0, 150);
            this.buttonProgramme.Name = "buttonProgramme";
            this.buttonProgramme.Size = new System.Drawing.Size(221, 46);
            this.buttonProgramme.TabIndex = 13;
            this.buttonProgramme.Text = "Programme";
            this.buttonProgramme.UseVisualStyleBackColor = false;
            this.buttonProgramme.Click += new System.EventHandler(this.buttonProgramme_Click);
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
        private System.Windows.Forms.Button buttonSubject;
        private System.Windows.Forms.Panel panelform1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonWorking;
        private System.Windows.Forms.Button buttonTags;
        private System.Windows.Forms.Button buttonStudentList;
        private System.Windows.Forms.Button buttonAddBuilding;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Button buttonLecturer;
        private System.Windows.Forms.Button buttonStudentBatch;
        private System.Windows.Forms.Button buttonGenarateID;
        private System.Windows.Forms.Button buttonProgramme;
    }
}

