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
    public partial class FrmDoctorDetail : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=HospitalProject; user ID=postgres; password=postgres");

        public string TCNO;
        public string patientId;
        public string name_surname;
        public FrmDoctorDetail()
        {
            InitializeComponent();
        }

        private void FrmDoctorDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCNO;
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select \"personId\",\"name\",\"surname\" from \"Person\".\"Person\" where tc=@c1", connection);
            command.Parameters.AddWithValue("@c1", lblTC.Text);
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr[0].ToString();
                lblNameSurname.Text = dr[1].ToString() + "  " + dr[2].ToString();
            }
            patientId = label1.Text;
            name_surname = lblNameSurname.Text;
            connection.Close();

            txtdoctorid.Text = label1.Text;

            connection.Open();
            DataTable dt1 = new DataTable();
            Npgsql.NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("SELECT * FROM \"Person\".\"Person\" INNER JOIN \"public\".\"Appointment\"ON \"Person\".\"Person\".\"personId\" = \"public\".\"Appointment\".\"personId\" where \"appointmentStatus\"=false and \"drStatus\"=true and \"appointmentDr\"="+label1.Text+"", connection);
            da1.Fill(dt1);
            dataGridView3.DataSource = dt1;

            DataTable dt2 = new DataTable();
            Npgsql.NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("SELECT * FROM \"Person\".\"Person\" INNER JOIN \"Person\".\"Patient\"ON \"Person\".\"Person\".\"personId\" = \"Person\".\"Patient\".\"personId\"", connection);
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            DataTable dt3 = new DataTable();
            Npgsql.NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("SELECT \"announcement\",\"date\" FROM \"public\".\"Announcement\"", connection);
            da3.Fill(dt3);
            dataGridView4.DataSource = dt3;

            DataTable dt4 = new DataTable();
            Npgsql.NpgsqlDataAdapter da4 = new NpgsqlDataAdapter("SELECT \"patientNo\",\"medicineName\" FROM \"public\".\"Prescription\" where \"doctorNo\"="+label1.Text+"", connection);
            da4.Fill(dt4);
            dataGridView1.DataSource = dt4;


            connection.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            txtpatientid.Text = dataGridView2.Rows[chosen].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            connection.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO \"public\".\"Prescription\"(\"doctorNo\",\"patientNo\",\"medicineName\") values (@p0,@p1,@p2)", connection);
            command1.Parameters.AddWithValue("@p0", int.Parse(label1.Text));
            command1.Parameters.AddWithValue("@p1", int.Parse(txtpatientid.Text));
            command1.Parameters.AddWithValue("@p2", txtmedicinename.Text);

            command1.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Add is done ,Prescription:", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmDoctorDetail fr = new FrmDoctorDetail();
            fr.label1.Text = patientId;
            fr.lblNameSurname.Text = name_surname;
            fr.lblTC.Text = TCNO;
            fr.Show();
            this.Hide();
        }
    }
}
