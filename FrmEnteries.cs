using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPatientLogin fr = new FrmPatientLogin();
            fr.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDoctorLogin fr1 = new FrmDoctorLogin();
            fr1.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin fr2 = new FrmSecretaryLogin();
            fr2.Show();
            this.Hide();


        }
    }
}
