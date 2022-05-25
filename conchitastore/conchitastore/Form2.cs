using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace conchitastore
{
    public partial class Form2 : Form
    {
        Connection cn = new Connection();
        Connection cn1 = new Connection();
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ve = new Form1();
            ve.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 er = new Form3();
            er.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_provider_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 nv = new Form4();
            nv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 des = new Form5();
            des.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 gn = new Form6();
            gn.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 nm = new Form7();
            nm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 vn = new Form8();
            vn.Show();
        }
    }
}
