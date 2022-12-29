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
    public partial class SecretaryRegistration : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=HospitalProject; user ID=postgres; password=postgres");

        public SecretaryRegistration()
        {
            InitializeComponent();
        }

        private void SecretaryRegistration_Load(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dt1 = new DataTable();
            Npgsql.NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select * from \"public\".\"Policlinic\"", connection);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            DataTable dt3 = new DataTable();
            Npgsql.NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("SELECT * FROM \"Person\".\"Person\" INNER JOIN \"Person\".\"Employee\"ON \"Person\".\"Person\".\"personId\" = \"Person\".\"Employee\".\"personId\"  INNER JOIN \"Person\".\"Secretary\" ON \"Person\".\"Employee\".\"personId\" = \"Person\".\"Secretary\".\"personId\"", connection);
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command4 = new NpgsqlCommand("INSERT INTO \"Person\".\"Person\"(\"name\", \"surname\", \"tc\", \"age\", \"password\", \"gender\", \"employee\", \"patient\") values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connection);
            command4.Parameters.AddWithValue("@p1", txtname.Text);
            command4.Parameters.AddWithValue("@p2", txtsurname.Text);
            command4.Parameters.AddWithValue("@p3", mskdCno.Text);
            command4.Parameters.AddWithValue("@p4", int.Parse(txtage.Text));
            command4.Parameters.AddWithValue("@p5", txtpassword.Text);
            if (cmbgender.Text == "Male")
            {
                command4.Parameters.AddWithValue("@p6", 'M');
            }
            else
            {
                command4.Parameters.AddWithValue("@p6", 'F');
            }
            command4.Parameters.AddWithValue("@p7", true);
            command4.Parameters.AddWithValue("@p8", false);
            command4.ExecuteNonQuery();
            NpgsqlCommand command5 = new NpgsqlCommand("INSERT INTO \"Person\".\"Employee\"(\"personId\", \"trackNo\", \"startDate\", \"doctor\", \"secretary\", \"staff\", \"policlinicId\") values (currval('\"Person\".\"Person_personId_seq\"'),@x2,@x3,@x4,@x5,@x6,@x7)", connection);
            command5.Parameters.AddWithValue("@x2", int.Parse(txtTrackno.Text));
            command5.Parameters.AddWithValue("@x3", DateTime.Parse(mskdDate.Text));
            command5.Parameters.AddWithValue("@x4", false);
            command5.Parameters.AddWithValue("@x5", true);
            command5.Parameters.AddWithValue("@x6", false);
            command5.Parameters.AddWithValue("@x7", int.Parse(txtpoliclinicId.Text));
            command5.ExecuteNonQuery();

            NpgsqlCommand command6 = new NpgsqlCommand("INSERT INTO \"Person\".\"Secretary\"(\"personId\", \"stExperience\", \"admin\", \"salary\") values (currval('\"Person\".\"Person_personId_seq\"'),@s2,@s3,@s4)", connection);
            command6.Parameters.AddWithValue("@s2",int.Parse(txtExperience.Text));
            command6.Parameters.AddWithValue("@s3",false);
            command6.Parameters.AddWithValue("@s4", int.Parse(txtsalary.Text));
            command6.ExecuteNonQuery();
            connection.Close();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtpoliclinicId.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecretaryRegistration fr = new SecretaryRegistration();
            fr.Show();
            this.Hide();
        }
    }
}
