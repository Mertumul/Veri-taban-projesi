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
    public partial class View : Form
    {
        public string query;
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=HospitalProject; user ID=postgres; password=postgres");


        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            Npgsql.NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(query, connection);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }
    }
}
