using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace conchitastore
{
    public partial class Form7 : Form
    {
        CRUDBOTANAS ver = new CRUDBOTANAS();
        CRUDBOTANAS insertar = new CRUDBOTANAS();
        CRUDBOTANAS update = new CRUDBOTANAS();
        CRUDBOTANAS delete = new CRUDBOTANAS();
        CRUDBOTANAS cleaninig = new CRUDBOTANAS();

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            ver.MuestraDatos(dgv_5);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 vd = new Form2();
            vd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertar.InsertarDatos(txt_code, txt_date, txt_producto, txt_tipo, txt_detalle, txt_cantidad);
            ver.MuestraDatos(dgv_5);
        }

        private void dgv_5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_code.Text = dgv_5.CurrentRow.Cells[0].Value.ToString();
                txt_date.Text = dgv_5.CurrentRow.Cells[1].Value.ToString();
                txt_producto.Text = dgv_5.CurrentRow.Cells[2].Value.ToString();
                txt_tipo.Text = dgv_5.CurrentRow.Cells[3].Value.ToString();
                txt_detalle.Text = dgv_5.CurrentRow.Cells[4].Value.ToString();
                txt_cantidad.Text = dgv_5.CurrentRow.Cells[5].Value.ToString();

            }
            catch (Exception g)
            {

                MessageBox.Show("That request is wrong" + g.Message);
            }
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            delete.EliminaDatos(txt_code);
            ver.MuestraDatos(dgv_5);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update.ActualizaDatos(txt_code, txt_date, txt_producto, txt_tipo, txt_detalle, txt_cantidad);
            ver.MuestraDatos(dgv_5);
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            cleaninig.LimpiarDatos(txt_code, txt_date, txt_producto, txt_tipo, txt_detalle, txt_cantidad);
        }
    }
}
