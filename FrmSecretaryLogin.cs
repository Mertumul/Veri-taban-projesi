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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=HospitalProject; user ID=postgres; password=postgres");

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            /* 
            */
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"Person\".\"Person\" INNER JOIN \"Person\".\"Employee\"ON \"Person\".\"Person\".\"personId\" = \"Person\".\"Employee\".\"personId\"  INNER JOIN \"Person\".\"Secretary\" ON \"Person\".\"Employee\".\"personId\" = \"Person\".\"Secretary\".\"personId\" where \"tc\"=@c1 and \"password\"=@c2 and  \"admin\"=@c3", connection);

            command.Parameters.AddWithValue("@c1", mskTC.Text);
            command.Parameters.AddWithValue("@c2", txtpassword.Text);
            bool admin;
            if (checkBox1.Checked)
            {
                admin = true;
            }
            else
            {
                admin = false;
            }
            command.Parameters.AddWithValue("@c3",admin);
            NpgsqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                if (admin == true)
                {
                    superAdmin fr = new superAdmin();
                    fr.TCNO = mskTC.Text;
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    FrmSecretaryDetail fr2 = new FrmSecretaryDetail();
                    fr2.TCNO = mskTC.Text;
                    fr2.Show();
                    this.Hide();
                }

            }
            else
            {
                connection.Close();
                MessageBox.Show("Login Failed Please Try Again");
                mskTC.Focus();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void FrmSecretaryLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
