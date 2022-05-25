using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace conchitastore
{
    public partial class Form4 : Form
    {
        CRUDFEMSA obj1 = new CRUDFEMSA();
        CRUDFEMSA obj2 = new CRUDFEMSA();
        CRUDFEMSA obj3 = new CRUDFEMSA();
        CRUDFEMSA obj4 = new CRUDFEMSA();
        
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            obj1.Mostra(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 dos = new Form2();
            dos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj4.UpdateData(txt_code,txt_date,txt_producto,txt_desc,txt_quanty);
            obj1.Mostra(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj2.InsertData(txt_code,txt_date, txt_producto, txt_desc, txt_quanty);
            obj1.Mostra(dataGridView1);

            txt_code.Clear();
            txt_date.Clear();
            txt_producto.Clear();
            txt_desc.Clear();
            txt_quanty.Clear();

            txt_code.Focus();

        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            txt_code.Clear();
            txt_date.Clear();
            txt_producto.Clear();
            txt_desc.Clear();
            txt_quanty.Clear();

            txt_code.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj3.Delete(txt_code);
            obj1.Mostra(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_code.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_date.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_producto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_desc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_quanty.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }
            catch (Exception k)
            {

                MessageBox.Show(k.Message);
            }
        }
    }
}
