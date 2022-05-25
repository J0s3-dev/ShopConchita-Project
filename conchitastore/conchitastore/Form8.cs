using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace conchitastore
{
    public partial class Form8 : Form
    {
        CRUDABARROTES observa = new CRUDABARROTES();
        CRUDABARROTES ingresar = new CRUDABARROTES();
        CRUDABARROTES change = new CRUDABARROTES();
        CRUDABARROTES delete = new CRUDABARROTES();
        CRUDABARROTES Clear = new CRUDABARROTES();
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            observa.Muestra(dgv_6);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 ng = new Form2();
            ng.Show();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            ingresar.Insertar(txt_code, txt_date, txt_producto, txt_tipo, txt_detalle, txt_cantidad);
            observa.Muestra(dgv_6);
        }

        private void dgv_6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_code.Text = dgv_6.CurrentRow.Cells[0].Value.ToString();
                txt_date.Text = dgv_6.CurrentRow.Cells[1].Value.ToString();
                txt_producto.Text = dgv_6.CurrentRow.Cells[2].Value.ToString();
                txt_tipo.Text = dgv_6.CurrentRow.Cells[3].Value.ToString();
                txt_detalle.Text = dgv_6.CurrentRow.Cells[4].Value.ToString();
                txt_cantidad.Text = dgv_6.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception j)
            {

                MessageBox.Show(j.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            delete.Eliminar(txt_code);
            observa.Muestra(dgv_6);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            change.UpdateData(txt_code, txt_date, txt_producto, txt_tipo, txt_detalle, txt_cantidad);
            observa.Muestra(dgv_6);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Clear.LimmpiarCasillas(txt_code, txt_date, txt_producto, txt_tipo, txt_detalle, txt_cantidad);
        }
    }
}
