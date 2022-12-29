using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.Data.SqlClient;
namespace HospitalProject
{


    public partial class FrmDoctorRegistreation : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=HospitalProject; user ID=postgres; password=postgres");

        public FrmDoctorRegistreation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void FrmDoctorRegistreation_Load(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dt1 = new DataTable();
            Npgsql.NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select * from \"public\".\"Policlinic\"", connection);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();
            Npgsql.NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from \"public\".\"Title\"", connection);
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            DataTable dt3 = new DataTable();
            Npgsql.NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("SELECT * FROM \"Person\".\"Person\" INNER JOIN \"Person\".\"Employee\"ON \"Person\".\"Person\".\"personId\" = \"Person\".\"Employee\".\"personId\"  INNER JOIN \"Person\".\"Doctor\" ON \"Person\".\"Employee\".\"personId\" = \"Person\".\"Doctor\".\"personId\"", connection);
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;


            connection.Close();
           


        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"public\".\"Policlinic\"(\"policlinicName\") values (@p0)", connection);
            command.Parameters.AddWithValue("@p0", txtpoliclinicname.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Add is done ,Policlinic:" + txtpoliclinicname.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtpoliclinicId.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("UPDATE \"public\".\"Policlinic\" SET \"policlinicName\"=@d1 where \"policlinicId\"=@d2", connection);
            command2.Parameters.AddWithValue("@d1", txtpoliclinicname.Text);
            command2.Parameters.AddWithValue("@d2", Int16.Parse(txtpoliclinicId.Text));
            command2.ExecuteNonQuery();
            connection.Close();




        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmDoctorRegistreation fr = new FrmDoctorRegistreation();
            fr.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("DELETE FROM  \"public\".\"Policlinic\" WHERE \"policlinicId\"=@a1", connection);
            command3.Parameters.AddWithValue("@a1", Int16.Parse(txtpoliclinicId.Text));
            command3.ExecuteNonQuery();
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             INSERT INTO "Person"."Person"("name", "surname", "tc", "age", "password", "gender", "employee", "patient")
             VALUES('Buse', 'Alevli', '33333333333', '25', 'pass123', 'F', true, false);
INSERT INTO "Person"."Employee"("personId","trackNo","startDate","doctor","secretary","staff","policlinicId")
VALUES (currval('"Person"."Person_personId_seq"'),100,'2019-01-01',false,true,false,1);
INSERT INTO "Person"."Secretary"("personId","stExperience","admin")
VALUES (currval('"Person"."Person_personId_seq"'),3,true);
            */

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
            command5.Parameters.AddWithValue("@x4",true);
            command5.Parameters.AddWithValue("@x5", false);
            command5.Parameters.AddWithValue("@x6", false);
            command5.Parameters.AddWithValue("@x7", int.Parse(txtpoliclinicId.Text));
            command5.ExecuteNonQuery();
            NpgsqlCommand command6 = new NpgsqlCommand("INSERT INTO \"Person\".\"Doctor\"(\"personId\", \"drAdress\", \"drTelephone\", \"drExperince\", \"drEmail\", \"salary\", \"titleId\") values (currval('\"Person\".\"Person_personId_seq\"'),@s2,@s3,@s4,@s5,@s6,@s7)", connection);
            command6.Parameters.AddWithValue("@s2",txtadres.Text);
            command6.Parameters.AddWithValue("@s3",mskdTel.Text);
            command6.Parameters.AddWithValue("@s4", int.Parse(txtexperience.Text));
            command6.Parameters.AddWithValue("@s5", txtdremail.Text);
            command6.Parameters.AddWithValue("@s6", int.Parse(txtsalary.Text));
            command6.Parameters.AddWithValue("@s7", int.Parse(txtTiitleId.Text));
            command6.ExecuteNonQuery();
            connection.Close();



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            txtTiitleId.Text = dataGridView2.Rows[chosen].Cells[0].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void mskdDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTiitleId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtpoliclinicId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdremail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtexperience_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void mskdTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtadres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTrackno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskdCno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtsurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtpoliclinicname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
