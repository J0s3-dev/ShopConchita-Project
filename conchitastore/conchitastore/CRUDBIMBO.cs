using System;
using System.Collections.Generic;
using System.Text;
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
    class CRUDBIMBO
    {

        public void MostrarDatos(DataGridView dgv_2)
        {
            string servidor1 = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string muestra = "Select * From productbimbo";

            try
            {

                MySqlConnection con1 = new MySqlConnection(servidor1);
                con1.Open();
                MySqlCommand dcm = new MySqlCommand(muestra, con1);
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(dcm);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);

                dgv_2.DataSource = table1;

            }
            catch (MySqlException ls)
            {

                MessageBox.Show("Bad request, try again" + ls.Message);
            }
        }

        public void InsertarDatos(TextBox txt_code,TextBox txt_date,TextBox txt_producto,TextBox txt_detalle,TextBox txt_cantidad)
        {
            string servidor2 = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string insertar = "Insert Into productbimbo(CodeBimbo,Date,Producto,Detalle,Cantidad)" +
                "Values(@code,@date,@producto,@detalle,@cantidad)";

            try
            {
                MySqlConnection con2 = new MySqlConnection(servidor2);
                con2.Open();
                MySqlCommand cmd1 = new MySqlCommand(insertar, con2);

                cmd1.Parameters.AddWithValue("@code", txt_code.Text);
                cmd1.Parameters.AddWithValue("@date", txt_date.Text);
                cmd1.Parameters.AddWithValue("@producto", txt_producto.Text);
                cmd1.Parameters.AddWithValue("@detalle", txt_detalle.Text);
                cmd1.Parameters.AddWithValue("@cantidad", txt_cantidad.Text);
                cmd1.ExecuteNonQuery();

                con2.Close();

                MessageBox.Show("Loaded data with successfully in table BIMBO");


            }
            catch (MySqlException lo)
            {

                MessageBox.Show("Request wrong, contact engeenier" + lo.Message);
            }
        }

        public void ActualizarDatos(TextBox txt_code, TextBox txt_date, TextBox txt_producto, TextBox txt_detalle, TextBox txt_cantidad)
        {
            string servidor3 = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string actualizar = "UPDATE productbimbo SET CodeBimbo=@code ,Date=@date ,Producto=@producto ,Detalle=@detalle ,Cantidad=@cantidad " +
                "WHERE CodeBimbo=@code";

            try
            {
                MySqlConnection con3 = new MySqlConnection(servidor3);
                con3.Open();
                MySqlCommand cmd2 = new MySqlCommand(actualizar, con3);

                cmd2.Parameters.AddWithValue("@code", txt_code.Text);
                cmd2.Parameters.AddWithValue("@date", txt_date.Text);
                cmd2.Parameters.AddWithValue("@producto", txt_producto.Text);
                cmd2.Parameters.AddWithValue("@detalle", txt_detalle.Text);
                cmd2.Parameters.AddWithValue("@cantidad", txt_cantidad.Text);
                cmd2.ExecuteNonQuery();

                con3.Close();

                MessageBox.Show("Updated data with successfully in table BIMBO");
            }
            catch (MySqlException los)
            {

                MessageBox.Show("Request wrong, contact engeenier" + los.Message);
            }
        }

        public void EraseData(TextBox txt_code)
        {
            string servidor4 = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string erase = "DELETE FROM productbimbo WHERE CodeBimbo=@code";

            try
            {

                MySqlConnection con4 = new MySqlConnection(servidor4);
                con4.Open();
                MySqlCommand cmd3 = new MySqlCommand(erase, con4);

                cmd3.Parameters.AddWithValue("@code", txt_code.Text);
                cmd3.ExecuteNonQuery();

                con4.Close();

                MessageBox.Show("Data erased with successfully in table BIMBO");

            }
            catch (MySqlException lo)
            {

                MessageBox.Show("Request wrong, contact engeenier" + lo.Message);
            }
        }

        public void CleanData(TextBox txt_code, TextBox txt_date, TextBox txt_producto, TextBox txt_detalle, TextBox txt_cantidad)
        {
            txt_code.Clear();
            txt_date.Clear();
            txt_producto.Clear();
            txt_detalle.Clear();
            txt_cantidad.Clear();

            txt_code.Focus();
        }


    }
}
