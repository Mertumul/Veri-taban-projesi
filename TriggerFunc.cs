using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalProject
{
    public partial class TriggerFunc : Form
    {
        public TriggerFunc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View fr = new View();
            fr.query = "select * from personsearch(5)";
            fr.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View fr1 = new View();
            fr1.query = "select salary,tax(salary) from \"Person\".\"Doctor\"";
            fr1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View fr2 = new View();
            fr2.query = "select * from total_Expense()";
            fr2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View fr3 = new View();
            fr3.query = "select * from totoal_Income()";
            fr3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            View fr4 = new View();
            fr4.query = "select * from total_paidSalary()";
            fr4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            View fr5 = new View();
            fr5.query = "select * from \"Person\".\"totalPatient\"";
            fr5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            View fr6 = new View();
            fr6.query = "select * from \"Person\".\"totalEmployee\"";
            fr6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            View fr7 = new View();
            fr7.query = "select * from \"public\".\"viewTheSalaryChange\"";
            fr7.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            View fr8 = new View();
            fr8.query = "select * from \"public\".\"deleted_department\"";
            fr8.Show();
        }
    }
}
