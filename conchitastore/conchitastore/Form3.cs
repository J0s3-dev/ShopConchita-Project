using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace conchitastore
{
    public partial class Form3 : Form 
    {
        ClRUDsupplier no = new ClRUDsupplier();
        ClRUDsupplier no1 = new ClRUDsupplier();
        ClRUDsupplier no2 = new ClRUDsupplier();
        ClRUDsupplier no3 = new ClRUDsupplier();
        ClRUDsupplier no4 = new ClRUDsupplier();

        
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 vn = new Form2();
            vn.Show();
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            no.Mostrar(dgv_1);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            no1.Ingresardata(txt_code,txt_name,txt_address,txt_phone,txt_sale);
            no.Mostrar(dgv_1);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            no2.Limpiardatos(txt_code,txt_name,txt_address,txt_phone,txt_sale);
        }

        private void dgv_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

            try
            {
                txt_code.Text = dgv_1.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = dgv_1.CurrentRow.Cells[1].Value.ToString();
                txt_address.Text = dgv_1.CurrentRow.Cells[2].Value.ToString();
                txt_phone.Text = dgv_1.CurrentRow.Cells[3].Value.ToString();
                txt_sale.Text = dgv_1.CurrentRow.Cells[4].Value.ToString();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            no3.UpdateData(txt_code,txt_name,txt_address,txt_phone,txt_sale);
            no.Mostrar(dgv_1);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            no4.Delete(txt_code);
            no.Mostrar(dgv_1);
            
        }
    }
}
