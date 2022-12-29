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
    public partial class FrmPatient : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=HospitalProject; user ID=postgres; password=postgres");

        public FrmPatient()
        {
            InitializeComponent();
        }

        private void FrmPatient_Load(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dt1 = new DataTable();
            Npgsql.NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("SELECT * FROM \"Person\".\"Person\" INNER JOIN \"Person\".\"Patient\"ON \"Person\".\"Person\".\"personId\" = \"Person\".\"Patient\".\"personId\"", connection);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            connection.Close();
        }
    }
}
