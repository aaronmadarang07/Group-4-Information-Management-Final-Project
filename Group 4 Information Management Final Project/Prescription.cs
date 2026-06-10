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
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void Prescription_ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Prescription_GobackHomeBtn_Click(object sender, EventArgs e)
        {
            Home Prescription_homeForm = new Home();
            Prescription_homeForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
