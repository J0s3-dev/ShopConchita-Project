using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace conchitastore
{
    public partial class Form6 : Form
    {
        CRUDLACTEO view = new CRUDLACTEO();
        CRUDLACTEO insertar = new CRUDLACTEO();
        CRUDLACTEO actualizar = new CRUDLACTEO();
        CRUDLACTEO elimina = new CRUDLACTEO();
        CRUDLACTEO limpia = new CRUDLACTEO();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            view.MostrarGrid(dgv_4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 other = new Form2();
            other.Show();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            insertar.InsertaDatos(txt_code, txt_date, txt_caducidad, txt_producto, txt_detalle, txt_cantidad);
            view.MostrarGrid(dgv_4);
        }

        private void dgv_4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_code.Text = dgv_4.CurrentRow.Cells[0].Value.ToString();
                txt_date.Text = dgv_4.CurrentRow.Cells[1].Value.ToString();
                txt_caducidad.Text = dgv_4.CurrentRow.Cells[2].Value.ToString();
                txt_producto.Text = dgv_4.CurrentRow.Cells[3].Value.ToString();
                txt_detalle.Text = dgv_4.CurrentRow.Cells[4].Value.ToString();
                txt_cantidad.Text = dgv_4.CurrentRow.Cells[5].Value.ToString();

            }
            catch (Exception ls)
            {

                MessageBox.Show("That request is wrong, please contact your technic support" + ls.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizar.ActualizaDatos(txt_code, txt_date, txt_caducidad, txt_producto, txt_detalle, txt_cantidad);
            view.MostrarGrid(dgv_4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elimina.DeleteData(txt_code);
            view.MostrarGrid(dgv_4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpia.CleanData(txt_code,txt_date,txt_caducidad,txt_producto,txt_detalle,txt_cantidad);
        }
    }
}
