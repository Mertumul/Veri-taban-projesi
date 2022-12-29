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
    public partial class FrmSecretaryDetail : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=HospitalProject; user ID=postgres; password=postgres");
        public string TCNO;
        public string patientId;
        public string name_surname;
        public FrmSecretaryDetail()
        {
            InitializeComponent();
        }

        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCNO;
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select \"personId\",\"name\",\"surname\" from \"Person\".\"Person\" where tc=@c1", connection);
            command.Parameters.AddWithValue("@c1", lblTC.Text);
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                label6.Text = dr[0].ToString();
                lblNameSurname.Text = dr[1].ToString() + "  " + dr[2].ToString();
            }
            patientId = label1.Text;
            name_surname = lblNameSurname.Text;
            connection.Close();
            connection.Open();
            DataTable dt1 = new DataTable();
            Npgsql.NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select \"announcement\",\"date\" from \"public\".\"Announcement\"", connection);
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            DataTable dt3 = new DataTable();
            Npgsql.NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("SELECT * FROM \"Person\".\"Person\" INNER JOIN \"Person\".\"Employee\"ON \"Person\".\"Person\".\"personId\" = \"Person\".\"Employee\".\"personId\"  INNER JOIN \"Person\".\"Doctor\" ON \"Person\".\"Employee\".\"personId\" = \"Person\".\"Doctor\".\"personId\"", connection);
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;

            DataTable dt2 = new DataTable();
            Npgsql.NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("SELECT * FROM  \"public\".\"Department\"", connection);
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            DataTable dt4 = new DataTable();
            Npgsql.NpgsqlDataAdapter da4 = new NpgsqlDataAdapter("SELECT * FROM  \"public\".\"Title\"", connection);
            da4.Fill(dt4);
            dataGridView4.DataSource = dt4;

            DataTable dt5 = new DataTable();
            Npgsql.NpgsqlDataAdapter da5 = new NpgsqlDataAdapter("SELECT * FROM  \"public\".\"Appointment\"", connection);
            da5.Fill(dt5);
            dataGridView5.DataSource = dt5;



            connection.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView3.SelectedCells[0].RowIndex;
            txtdoctorid.Text = dataGridView3.Rows[chosen].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            connection.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO \"public\".\"Appointment\"(\"appointmentDr\",\"date\",\"time\",\"appointmentStatus\",\"drStatus\") values (@p0,@p1,@p2,true,false)", connection);
            command1.Parameters.AddWithValue("@p0",int.Parse(txtdoctorid.Text));
            command1.Parameters.AddWithValue("@p1", DateTime.Parse(mskdDate.Text));
            command1.Parameters.AddWithValue("@p2", DateTime.Parse(maskedTextBox1.Text));

            command1.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Add is done ,Appoinment:" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("INSERT INTO \"public\".\"Announcement\"(\"personId\",\"announcement\",\"date\") values (@s1,@s2,CURRENT_TIMESTAMP)", connection);
            command2.Parameters.AddWithValue("@s1", int.Parse(label6.Text));
            command2.Parameters.AddWithValue("@s2", richTextBox1.Text);
            command2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Add is done ,Announcement:", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSecretaryDetail fr = new FrmSecretaryDetail();
            fr.Show();
            fr.label1.Text = patientId;
            fr.lblNameSurname.Text = name_surname;
            this.Hide();
        }
    }
}
