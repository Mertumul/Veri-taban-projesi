
namespace HospitalProject
{
    partial class FrmFinancial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtıncomePk = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpersonId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtappointmentfee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdonation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtExpenseId = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.txtmedicalsupply = new System.Windows.Forms.TextBox();
            this.txtpersonId2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtgas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tctwater = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtelectric = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 49);
            this.label1.TabIndex = 21;
            this.label1.Text = "Income";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtıncomePk);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtpersonId);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtappointmentfee);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdonation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 756);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(88, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 56;
            this.label5.Text = "IncomeId:";
            // 
            // txtıncomePk
            // 
            this.txtıncomePk.Enabled = false;
            this.txtıncomePk.Location = new System.Drawing.Point(199, 382);
            this.txtıncomePk.Name = "txtıncomePk";
            this.txtıncomePk.Size = new System.Drawing.Size(247, 23);
            this.txtıncomePk.TabIndex = 55;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(413, 564);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 56);
            this.button3.TabIndex = 54;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 56);
            this.button2.TabIndex = 53;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 56);
            this.button1.TabIndex = 52;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpersonId
            // 
            this.txtpersonId.Enabled = false;
            this.txtpersonId.Location = new System.Drawing.Point(199, 424);
            this.txtpersonId.Name = "txtpersonId";
            this.txtpersonId.Size = new System.Drawing.Size(247, 23);
            this.txtpersonId.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(93, 421);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 23);
            this.label15.TabIndex = 50;
            this.label15.Text = "PersonId:";
            // 
            // txtappointmentfee
            // 
            this.txtappointmentfee.Location = new System.Drawing.Point(199, 503);
            this.txtappointmentfee.Name = "txtappointmentfee";
            this.txtappointmentfee.Size = new System.Drawing.Size(247, 23);
            this.txtappointmentfee.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "appointmentFee:";
            // 
            // txtdonation
            // 
            this.txtdonation.Location = new System.Drawing.Point(199, 461);
            this.txtdonation.Name = "txtdonation";
            this.txtdonation.Size = new System.Drawing.Size(247, 23);
            this.txtdonation.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Donation:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(90, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 266);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.txtExpenseId);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.txtmedicalsupply);
            this.groupBox2.Controls.Add(this.txtpersonId2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtgas);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tctwater);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtelectric);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(1090, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 756);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(411, 660);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 56);
            this.button5.TabIndex = 59;
            this.button5.Text = "DELETE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(131, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 23);
            this.label10.TabIndex = 60;
            this.label10.Text = "ExpenseId:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(222, 660);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 56);
            this.button6.TabIndex = 58;
            this.button6.Text = "UPDATE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtExpenseId
            // 
            this.txtExpenseId.Enabled = false;
            this.txtExpenseId.Location = new System.Drawing.Point(242, 375);
            this.txtExpenseId.Name = "txtExpenseId";
            this.txtExpenseId.Size = new System.Drawing.Size(247, 23);
            this.txtExpenseId.TabIndex = 59;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(29, 660);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(161, 56);
            this.button7.TabIndex = 57;
            this.button7.Text = "ADD";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtmedicalsupply
            // 
            this.txtmedicalsupply.Location = new System.Drawing.Point(245, 591);
            this.txtmedicalsupply.Name = "txtmedicalsupply";
            this.txtmedicalsupply.Size = new System.Drawing.Size(247, 23);
            this.txtmedicalsupply.TabIndex = 64;
            // 
            // txtpersonId2
            // 
            this.txtpersonId2.Enabled = false;
            this.txtpersonId2.Location = new System.Drawing.Point(242, 417);
            this.txtpersonId2.Name = "txtpersonId2";
            this.txtpersonId2.Size = new System.Drawing.Size(247, 23);
            this.txtpersonId2.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(82, 591);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 23);
            this.label8.TabIndex = 63;
            this.label8.Text = "Medical Supplies:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(143, 414);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 23);
            this.label11.TabIndex = 57;
            this.label11.Text = "PersonId:";
            // 
            // txtgas
            // 
            this.txtgas.Location = new System.Drawing.Point(245, 549);
            this.txtgas.Name = "txtgas";
            this.txtgas.Size = new System.Drawing.Size(247, 23);
            this.txtgas.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(120, 549);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 61;
            this.label9.Text = "Natural Gas:";
            // 
            // tctwater
            // 
            this.tctwater.Location = new System.Drawing.Point(242, 508);
            this.tctwater.Name = "tctwater";
            this.tctwater.Size = new System.Drawing.Size(247, 23);
            this.tctwater.TabIndex = 60;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(128, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 257);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(386, 235);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(163, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 59;
            this.label6.Text = "Water:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(225, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 49);
            this.label3.TabIndex = 21;
            this.label3.Text = "Expense";
            // 
            // txtelectric
            // 
            this.txtelectric.Location = new System.Drawing.Point(242, 466);
            this.txtelectric.Name = "txtelectric";
            this.txtelectric.Size = new System.Drawing.Size(247, 23);
            this.txtelectric.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(155, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Electric:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView3);
            this.groupBox5.Location = new System.Drawing.Point(656, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(387, 262);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "admins";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(381, 240);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(767, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 56);
            this.button4.TabIndex = 57;
            this.button4.Text = "REFRESH";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmFinancial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1690, 832);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFinancial";
            this.Text = "FrmFinancial";
            this.Load += new System.EventHandler(this.FrmFinancial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtappointmentfee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdonation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpersonId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtıncomePk;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtExpenseId;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtmedicalsupply;
        private System.Windows.Forms.TextBox txtpersonId2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtgas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tctwater;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtelectric;
        private System.Windows.Forms.Label label7;
    }
}