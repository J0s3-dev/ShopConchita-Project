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
    class CRUDLACTEO
    {
        public void MostrarGrid(DataGridView dgv_4)
        {
            string servidor = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string vista = "SELECT * FROM lacteos";

            try
            {
                MySqlConnection con = new MySqlConnection(servidor);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(vista, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgv_4.DataSource = table;
            }
            catch (MySqlException ls)
            {

                MessageBox.Show("Request wrong, please contact engeenier" + ls.Message);
            }
        }


        public void InsertaDatos(TextBox txt_code,TextBox txt_date,TextBox txt_caducidad,TextBox txt_producto,TextBox txt_detalle,TextBox txt_cantidad)
        {
            string servidor1 = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string datos = "INSERT INTO lacteos(CodeProduct,Datreceived,Datecaducity,Producto,Detalle,Cantidad)" +
                "VALUES(@code,@date1,@date2,@producto,@detalle,@cantidad)";

            try
            {
                MySqlConnection con1 = new MySqlConnection(servidor1);
                con1.Open();
                MySqlCommand cmd1 = new MySqlCommand(datos, con1);

                cmd1.Parameters.AddWithValue("@code", txt_code.Text);
                cmd1.Parameters.AddWithValue("@date1", txt_date.Text);
                cmd1.Parameters.AddWithValue("@date2", txt_caducidad.Text);
                cmd1.Parameters.AddWithValue("@producto", txt_producto.Text);
                cmd1.Parameters.AddWithValue("@detalle", txt_detalle.Text);
                cmd1.Parameters.AddWithValue("@cantidad", txt_cantidad.Text);
                cmd1.ExecuteNonQuery();

                con1.Close();

                MessageBox.Show("Input data with success in table 'LACTEOS'");
            }
            catch (MySqlException las)
            {

                MessageBox.Show("Request is wrong, call engeenier please" + las.Message);
            }
        }

        public void ActualizaDatos(TextBox txt_code, TextBox txt_date, TextBox txt_caducidad, TextBox txt_producto, TextBox txt_detalle, TextBox txt_cantidad)
        {
            
            string servicio = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string actualizar = "UPDATE lacteos SET CodeProduct=@code,Datreceived=@date1,Datecaducity=@date2,Producto=@producto ,Detalle=@detalle ,Cantidad=@cantidad " +
                "WHERE CodeProduct=@code";
            try
            {
                MySqlConnection con2 = new MySqlConnection(servicio);
                con2.Open();
                MySqlCommand cmd2 = new MySqlCommand(actualizar, con2);

                cmd2.Parameters.AddWithValue("@code", txt_code.Text);
                cmd2.Parameters.AddWithValue("@date1", txt_date.Text);
                cmd2.Parameters.AddWithValue("@date2", txt_caducidad.Text);
                cmd2.Parameters.AddWithValue("@producto", txt_producto.Text);
                cmd2.Parameters.AddWithValue("@detalle", txt_detalle.Text);
                cmd2.Parameters.AddWithValue("@cantidad", txt_cantidad.Text);
                cmd2.ExecuteNonQuery();

                con2.Close();

                MessageBox.Show("Updated data with successfully in table 'Lacteos' thanks for your preference");

            }
            catch (MySqlException vd)
            {

                MessageBox.Show("Request wrong, call engeenier please" + vd.Message);
            }

        }

        public void DeleteData(TextBox txt_code)
        {
            string servidor = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string erase = "DELETE FROM lacteos WHERE CodeProduct=@code";

            try
            {
                MySqlConnection ces = new MySqlConnection(servidor);
                ces.Open();
                MySqlCommand cddm = new MySqlCommand(erase, ces);

                cddm.Parameters.AddWithValue("@code", txt_code.Text);
                cddm.ExecuteNonQuery();

                ces.Close();

              

                MessageBox.Show("Deleted data with successfully in table 'lacteos', thanks for your preference");

            }
            catch (MySqlException fd)
            {

                MessageBox.Show("Request wrong, call engeenier please " + fd.HelpLink);

            }
        }

        public void CleanData(TextBox txt_code, TextBox txt_date, TextBox txt_caducidad,TextBox txt_producto,TextBox txt_detalle,TextBox txt_cantidad)
        {

            txt_code.Clear();
            txt_date.Clear();
            txt_caducidad.Clear();
            txt_producto.Clear();
            txt_detalle.Clear();
            txt_cantidad.Clear();

            txt_code.Focus();

        }

    }
}
