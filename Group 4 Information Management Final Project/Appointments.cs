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
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Appointments_ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Appointments_GobackHomeBtn_Click(object sender, EventArgs e)
        {
            Home Appointments_homeForm = new Home();
            Appointments_homeForm.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
