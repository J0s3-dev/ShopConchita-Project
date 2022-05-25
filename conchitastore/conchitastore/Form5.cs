using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace conchitastore
{
    public partial class Form5 : Form
    {
        CRUDBIMBO view = new CRUDBIMBO();
        CRUDBIMBO ingresar = new CRUDBIMBO();
        CRUDBIMBO atualizar = new CRUDBIMBO();
        CRUDBIMBO limpia = new CRUDBIMBO();
        CRUDBIMBO borrar = new CRUDBIMBO();
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 nuevo = new Form2();
            nuevo.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            view.MostrarDatos(dgv_2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingresar.InsertarDatos(txt_code, txt_date, txt_producto, txt_detalle, txt_cantidad);
            view.MostrarDatos(dgv_2);
        }

        private void dgv_2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_code.Text = dgv_2.CurrentRow.Cells[0].Value.ToString();
                txt_date.Text = dgv_2.CurrentRow.Cells[1].Value.ToString();
                txt_producto.Text = dgv_2.CurrentRow.Cells[2].Value.ToString();
                txt_detalle.Text = dgv_2.CurrentRow.Cells[3].Value.ToString();
                txt_cantidad.Text = dgv_2.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ls)
            {

                MessageBox.Show(ls.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            atualizar.ActualizarDatos(txt_code, txt_date, txt_producto, txt_detalle, txt_cantidad);
            view.MostrarDatos(dgv_2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpia.CleanData(txt_code,txt_date,txt_producto,txt_detalle,txt_cantidad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            borrar.EraseData(txt_code);
            view.MostrarDatos(dgv_2);
        }
    }
}
