using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace HospitalProject
{
    public partial class superAdmin : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=HospitalProject; user ID=postgres; password=postgres");


        public string TCNO;

        public superAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNameSurname_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoctorRegistreation fr = new FrmDoctorRegistreation();
            fr.Show();
        }

        private void superAdmin_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCNO;
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select name,surname from \"Person\".\"Person\" where tc=@c1", connection);
            command.Parameters.AddWithValue("@c1", lblTC.Text);
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblNameSurname.Text = dr[0].ToString() +"  "+ dr[1].ToString();
            }
            connection.Close();





        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecretaryRegistration fr1 = new SecretaryRegistration();
            fr1.Show();
            
            
                }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmStaff fr2 = new FrmStaff();
            fr2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmFinancial fr3 = new FrmFinancial();
            fr3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmPatient fr4 = new FrmPatient();
            fr4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TriggerFunc fr5 = new TriggerFunc();
            fr5.Show();
        }
    }
}
