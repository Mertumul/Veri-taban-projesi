using Npgsql;
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

    public partial class FrmDoctorLogin : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=HospitalProject; user ID=postgres; password=postgres");

        public FrmDoctorLogin()
        {
            InitializeComponent();
        }
        private void FrmDoctorLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"Person\".\"Person\" INNER JOIN \"Person\".\"Employee\"ON \"Person\".\"Person\".\"personId\" = \"Person\".\"Employee\".\"personId\"  INNER JOIN \"Person\".\"Doctor\" ON \"Person\".\"Employee\".\"personId\" = \"Person\".\"Doctor\".\"personId\" where \"tc\"=@c1 and \"password\"=@c2 and \"doctor\"=true", connection);
            command.Parameters.AddWithValue("@c1", mskTC.Text);
            command.Parameters.AddWithValue("@c2", txtpassword.Text);
            NpgsqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                FrmDoctorDetail fr = new FrmDoctorDetail();
                fr.TCNO = mskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed Please Try Again");
                mskTC.Focus();
            }
            connection.Close();

        }
    }
}
