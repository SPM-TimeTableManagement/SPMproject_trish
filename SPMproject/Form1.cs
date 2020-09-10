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

    }
}
