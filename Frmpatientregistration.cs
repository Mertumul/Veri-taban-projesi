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
    public partial class Frmpatientregistration : Form
    {
        public Frmpatientregistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=HospitalProject; user ID=postgres; password=postgres");

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            /*
            INSERT INTO "Person"."Person"("name", "surname", "tc", "age", "password", "gender", "employee", "patient")
            VALUES('Tuncer', 'Alevli', '17777777777', '19', 'hardpass', 'M', false, true);

            INSERT INTO "Person"."Patient"("personId","companion","mothersName","fathersName")
	        VALUES (currval('"Person"."Person_personId_seq"'),'xxxxx','xxxxx','xxxxxx');*/

            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"Person\".\"Person\"(\"name\", \"surname\", \"tc\", \"age\", \"password\", \"gender\", \"employee\", \"patient\") values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connection);
            command.Parameters.AddWithValue("@p1", txtname.Text);
            command.Parameters.AddWithValue("@p2", txtsurname.Text);
            command.Parameters.AddWithValue("@p3", mskdCno.Text);
            command.Parameters.AddWithValue("@p4", int.Parse(txtage.Text));
            command.Parameters.AddWithValue("@p5", txtpassword.Text);
            if (cmbgender.Text == "Male")
            {
               command.Parameters.AddWithValue("@p6", 'M');
            }
            else
            {
               command.Parameters.AddWithValue("@p6", 'F');
            }
            command.Parameters.AddWithValue("@p7", false);
            command.Parameters.AddWithValue("@p8", true);
            command.ExecuteNonQuery();

            NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO \"Person\".\"Patient\"(\"personId\",\"companion\",\"mothersName\",\"fathersName\") values (currval('\"Person\".\"Person_personId_seq\"'),@p9,@p10,@p11)", connection);
            command1.Parameters.AddWithValue("@p9", txtcompanion.Text);
            command1.Parameters.AddWithValue("@p10", txtmom.Text);
            command1.Parameters.AddWithValue("@p11", txtdad.Text);
            command1.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Registration is done ,Your Password:" + txtpassword.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
