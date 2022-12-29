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
    public partial class FrmPatientDetail : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=HospitalProject; user ID=postgres; password=postgres");

        public string TCNO;
        public string patientId;
        public string name_surname;



        public FrmPatientDetail()
        {
            InitializeComponent();
        }

        private void FrmPatientDetail_Load(object sender, EventArgs e)
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
            connection.Open();
            DataTable dt1 = new DataTable();
            Npgsql.NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("SELECT * FROM \"Person\".\"Person\" INNER JOIN \"public\".\"Appointment\"ON \"Person\".\"Person\".\"personId\" = \"public\".\"Appointment\".\"appointmentDr\" where \"appointmentStatus\"=true and \"drStatus\"=false", connection);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();
            Npgsql.NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("SELECT * FROM \"Person\".\"Person\" INNER JOIN \"public\".\"Appointment\"ON \"Person\".\"Person\".\"personId\" = \"public\".\"Appointment\".\"personId\" where \"appointmentStatus\"=false and \"drStatus\"=true", connection);
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            DataTable dt3 = new DataTable();
            Npgsql.NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("SELECT * FROM \"public\".\"Prescription\" Where \"patientNo\"=" + label1.Text + "", connection);
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
            connection.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtdoctorid.Text = dataGridView1.Rows[chosen].Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("UPDATE \"public\".\"Appointment\" SET \"personId\"=@d1,\"complaint\"=@d2,\"appointmentStatus\"=false,\"drStatus\"=true where \"appointmentId\"=@d3", connection);
            command2.Parameters.AddWithValue("@d1", int.Parse(label1.Text));
            command2.Parameters.AddWithValue("@d2",richTextBox1.Text);
            command2.Parameters.AddWithValue("@d3", int.Parse(txtdoctorid.Text));
            command2.ExecuteNonQuery();
            connection.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmPatientDetail fr = new FrmPatientDetail();
            fr.label1.Text = patientId;
            fr.lblNameSurname.Text = name_surname;
            fr.lblTC.Text = TCNO;

            fr.Show();
            this.Hide();
        }
    }
}
