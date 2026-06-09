using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_4_Information_Management_Final_Project
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PatientsForm_AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void Patient_ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Patient_GobackHomeBtn_Click(object sender, EventArgs e)
        {
            Home Patient_homeForm = new Home();
            Patient_homeForm.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
