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
    public partial class FrmFinancial : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=HospitalProject; user ID=postgres; password=postgres");

        public FrmFinancial()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmFinancial_Load(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dt1 = new DataTable();
            Npgsql.NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("SELECT * FROM \"Person\".\"Person\" INNER JOIN \"Person\".\"Employee\"ON \"Person\".\"Person\".\"personId\" = \"Person\".\"Employee\".\"personId\"  INNER JOIN \"Person\".\"Secretary\" ON \"Person\".\"Employee\".\"personId\" = \"Person\".\"Secretary\".\"personId\" where \"admin\"=true ", connection);
            da1.Fill(dt1);
            dataGridView3.DataSource = dt1;

            DataTable dt2 = new DataTable();
            Npgsql.NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("SELECT * FROM \"public\".\"Income\" ", connection);
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            connection.Close();

            DataTable dt3 = new DataTable();
            Npgsql.NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("SELECT * FROM \"public\".\"Expense\" ", connection);
            da3.Fill(dt3);
            dataGridView2.DataSource = dt3;
            connection.Close();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView3.SelectedCells[0].RowIndex;
            txtpersonId.Text = dataGridView3.Rows[chosen].Cells[0].Value.ToString();
            txtpersonId2.Text = dataGridView3.Rows[chosen].Cells[0].Value.ToString();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtıncomePk.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"public\".\"Income\"(\"personId\",\"donation\",\"appointmentFee\") values (@p0,@p1,@p2)", connection);
            command.Parameters.AddWithValue("@p0", int.Parse(txtpersonId.Text));
            command.Parameters.AddWithValue("@p1", int.Parse(txtdonation.Text));
            command.Parameters.AddWithValue("@p2",int.Parse(txtappointmentfee.Text));
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmFinancial fr = new FrmFinancial();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command2 = new NpgsqlCommand("UPDATE \"public\".\"Income\" SET \"donation\"=@d1,\"appointmentFee\"=@d2 where \"IncomeId\"=@d3", connection);
            command2.Parameters.AddWithValue("@d1", int.Parse(txtdonation.Text));
            command2.Parameters.AddWithValue("@d2", int.Parse(txtappointmentfee.Text));
            command2.Parameters.AddWithValue("@d3", int.Parse(txtıncomePk.Text));
            command2.ExecuteNonQuery();
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command3 = new NpgsqlCommand("DELETE FROM  \"public\".\"Income\" WHERE \"IncomeId\"=@a1", connection);
            command3.Parameters.AddWithValue("@a1", int.Parse(txtıncomePk.Text));
            command3.ExecuteNonQuery();
            connection.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            txtExpenseId.Text = dataGridView2.Rows[chosen].Cells[0].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command4 = new NpgsqlCommand("INSERT INTO \"public\".\"Expense\"(\"personId\",\"electric\",\"water\",\"naturalGas\",\"medicalSupplies\") values (@s0,@s1,@s2,@s3,@s4)", connection);
            command4.Parameters.AddWithValue("@s0", int.Parse(txtpersonId2.Text));
            command4.Parameters.AddWithValue("@s1", int.Parse(txtelectric.Text));
            command4.Parameters.AddWithValue("@s2", int.Parse(tctwater.Text));
            command4.Parameters.AddWithValue("@s3", int.Parse(txtgas.Text));
            command4.Parameters.AddWithValue("@s4", int.Parse(txtmedicalsupply.Text));

            command4.ExecuteNonQuery();
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command5 = new NpgsqlCommand("UPDATE \"public\".\"Expense\" SET \"electric\"=@z1,\"water\"=@z2,\"naturalGas\"=@z3,\"medicalSupplies\"=@z4 where \"expenseId\"=@z5", connection);
            command5.Parameters.AddWithValue("@z1", int.Parse(txtelectric.Text));
            command5.Parameters.AddWithValue("@z2", int.Parse(tctwater.Text));
            command5.Parameters.AddWithValue("@z3", int.Parse(txtgas.Text));
            command5.Parameters.AddWithValue("@z4", int.Parse(txtmedicalsupply.Text));
            command5.Parameters.AddWithValue("@z5", int.Parse(txtExpenseId.Text));
            command5.ExecuteNonQuery();
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command6 = new NpgsqlCommand("DELETE FROM  \"public\".\"Expense\" WHERE \"expenseId\"=@f1", connection);
            command6.Parameters.AddWithValue("@f1", int.Parse(txtExpenseId.Text));
            command6.ExecuteNonQuery();
            connection.Close();
        }
    }
}
