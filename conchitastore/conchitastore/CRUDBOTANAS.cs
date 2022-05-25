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
    class CRUDBOTANAS
    {

        public void MuestraDatos(DataGridView dgv_5)
        {
            string servidores = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string consulta = "Select * From producbotanas";

            try
            {

                MySqlConnection con = new MySqlConnection(servidores);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(consulta, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adaptador.Fill(table);

                dgv_5.DataSource = table;

            }
            catch (MySqlException kl)
            {

                MessageBox.Show("Data wrong, could be Impossible recover data please contact engeenier. " + kl);
            }
        }

        public void InsertarDatos(TextBox txt_code,TextBox txt_date,TextBox txt_producto,TextBox txt_tipo,TextBox txt_detalle,TextBox txt_cantidad)
        {
            string servidor1 = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string insercion = "Insert Into producbotanas(CodeBotana,Fecha,Producto,Tipo,Detalle,Cantidad)" +
                "Values(@code,@date,@producto,@tipo,@detalle,@cantidad)";

            try
            {
                MySqlConnection con1 = new MySqlConnection(servidor1);
                con1.Open();
                MySqlCommand cmd1 = new MySqlCommand(insercion, con1);

                cmd1.Parameters.AddWithValue("@code", txt_code.Text);
                cmd1.Parameters.AddWithValue("@date", txt_date.Text);
                cmd1.Parameters.AddWithValue("@producto", txt_producto.Text);
                cmd1.Parameters.AddWithValue("@tipo", txt_tipo.Text);
                cmd1.Parameters.AddWithValue("@detalle", txt_detalle.Text);
                cmd1.Parameters.AddWithValue("@cantidad", txt_cantidad.Text);
                cmd1.ExecuteNonQuery();

                con1.Close();

                MessageBox.Show("Data input with successffully, in table Botanas.");

            }
            catch (MySqlException des)
            {

                MessageBox.Show("This request is wrong, contact engeenier." + des.HelpLink);
            }
        }

        public void ActualizaDatos(TextBox txt_code, TextBox txt_date, TextBox txt_producto, TextBox txt_tipo, TextBox txt_detalle, TextBox txt_cantidad)
        {
            string servicio = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string actualizar = "UPDATE producbotanas SET CodeBotana=@code,Fecha=@date ,Producto=@producto,Tipo=@tipo ,Detalle=@detalle ,Cantidad=@cantidad " +
                "WHERE CodeBotana=@code";

            try
            {
                MySqlConnection con2 = new MySqlConnection(servicio);
                con2.Open();
                MySqlCommand cmd2 = new MySqlCommand(actualizar, con2);

                cmd2.Parameters.AddWithValue("@code", txt_code.Text);
                cmd2.Parameters.AddWithValue("@date", txt_date.Text);
                cmd2.Parameters.AddWithValue("@producto", txt_producto.Text);
                cmd2.Parameters.AddWithValue("@tipo", txt_tipo.Text);
                cmd2.Parameters.AddWithValue("@detalle", txt_detalle.Text);
                cmd2.Parameters.AddWithValue("@cantidad", txt_cantidad.Text);
                cmd2.ExecuteNonQuery();

                con2.Close();

                MessageBox.Show("Data update with successffully, in table Botanas.");

            }
            catch (MySqlException fd)
            {

                MessageBox.Show("This request is wrong, contact engeenier." + fd.HelpLink);
            }
        }

        public void EliminaDatos(TextBox txt_code)
        {
            string servidor = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string erase = "DELETE FROM producbotanas WHERE CodeBotana=@code";

            try
            {
                MySqlConnection ces = new MySqlConnection(servidor);
                ces.Open();
                MySqlCommand cddm = new MySqlCommand(erase, ces);

                cddm.Parameters.AddWithValue("@code", txt_code.Text);
                cddm.ExecuteNonQuery();

                ces.Close();

                MessageBox.Show("Data erase with successffully, in table Botanas.");

            }
            catch (MySqlException lkjh)
            {

                MessageBox.Show("This request is wrong, contact engeenier." + lkjh.HelpLink);
            }
        }

        public void LimpiarDatos(TextBox txt_code, TextBox txt_date, TextBox txt_producto, TextBox txt_tipo, TextBox txt_detalle, TextBox txt_cantidad)
        {
            txt_code.Clear();
            txt_date.Clear();
            txt_producto.Clear();
            txt_tipo.Clear();
            txt_detalle.Clear();
            txt_cantidad.Clear();

            txt_code.Focus();
        }

    }
}
