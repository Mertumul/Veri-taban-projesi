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
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=HospitalProject; user ID=postgres; password=postgres");


        private void button1_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select * from \"Person\".\"Person\" where tc=@c1 and password=@c2 and patient=true", connection);
            command.Parameters.AddWithValue("@c1", mskTC.Text);
            command.Parameters.AddWithValue("@c2", txtpassword.Text);
            NpgsqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                FrmPatientDetail fr = new FrmPatientDetail();
                fr.TCNO = mskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed Please Try Again");
                mskTC.Focus();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmpatientregistration fr1 = new Frmpatientregistration();
            fr1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPatientLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
