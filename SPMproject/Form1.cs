using Location;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPMproject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLecturer_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();
            lecturerForm lectureform = new lecturerForm();
            lectureform.TopLevel = false;
            panelform1.Controls.Add(lectureform);
            lectureform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lectureform.Dock = DockStyle.Fill;
            lectureform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSubject_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();
            subjectForm subjectform = new subjectForm();
            subjectform.TopLevel = false;
            panelform1.Controls.Add(subjectform);
            subjectform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            subjectform.Dock = DockStyle.Fill;
            subjectform.Show();
        }

        private void buttonSession_Click(object sender, EventArgs e)
        {
           

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonWorking_Click(object sender, EventArgs e)
        {
            //Add_WorkingHours_And_WorkingDays.Form2 frm = new Add_WorkingHours_And_WorkingDays.Form2();
            //DialogResult selectButton = frm.ShowDialog();
            panelform1.Controls.Clear();
            //lecturerForm lectureform = new lecturerForm();
            Add_WorkingHours_And_WorkingDays.Form2 frm = new Add_WorkingHours_And_WorkingDays.Form2();
            frm.TopLevel = false;
            panelform1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void buttonAddBuilding_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();
            //lecturerForm lectureform = new lecturerForm();
            Add_WorkingHours_And_WorkingDays.Form2 frm = new Add_WorkingHours_And_WorkingDays.Form2();
            Building build = new Building();
            build.TopLevel = false;
            panelform1.Controls.Add(build);
            build.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            build.Dock = DockStyle.Fill;
            build.Show();

        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();
            //lecturerForm lectureform = new lecturerForm();
            //Add_WorkingHours_And_WorkingDays.Form2 frm = new Add_WorkingHours_And_WorkingDays.Form2();
            Room rm = new Room();
            rm.TopLevel = false;
            panelform1.Controls.Add(rm);
            rm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rm.Dock = DockStyle.Fill;
            rm.Show();
        }

        private void buttonStudentBatch_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();

            StudentBatch_and_Tags.EditStBatch std = new StudentBatch_and_Tags.EditStBatch();
            std.TopLevel = false;
            panelform1.Controls.Add(std);
            std.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            std.Dock = DockStyle.Fill;
            std.Show();

        }

        private void buttonProgramme_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();
            
            StudentBatch_and_Tags.Programme prgrm = new StudentBatch_and_Tags.Programme();
            prgrm.TopLevel = false;
            panelform1.Controls.Add(prgrm);
            prgrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            prgrm.Dock = DockStyle.Fill;
            prgrm.Show();

        }

        private void buttonGenarateID_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();

            StudentBatch_and_Tags.GenerateGroups gengrp = new StudentBatch_and_Tags.GenerateGroups();
            gengrp.TopLevel = false;
            panelform1.Controls.Add(gengrp);
            gengrp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gengrp.Dock = DockStyle.Fill;
            gengrp.Show();
        }

        private void buttonStudentList_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();

            StudentBatch_and_Tags.StudentList stdList = new StudentBatch_and_Tags.StudentList();
            stdList.TopLevel = false;
            panelform1.Controls.Add(stdList);
            stdList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            stdList.Dock = DockStyle.Fill;
            stdList.Show();
        }

        private void buttonTags_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();

            StudentBatch_and_Tags.CreateEditDeleteTag tags = new StudentBatch_and_Tags.CreateEditDeleteTag();
            tags.TopLevel = false;
            panelform1.Controls.Add(tags);
            tags.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tags.Dock = DockStyle.Fill;
            tags.Show();
        }
    }
}
