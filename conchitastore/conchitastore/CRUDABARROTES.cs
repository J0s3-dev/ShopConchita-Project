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
    class CRUDABARROTES
    {

        public void Muestra(DataGridView dgv_6)
        {
            string ordenador = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string mostrar = "Select * From abarrote";

            try
            {
                MySqlConnection con = new MySqlConnection(ordenador);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(mostrar, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dgv_6.DataSource = tabla;

            }
            catch (MySqlException kñ)
            {

                MessageBox.Show("Request is wrong, contact engeenier" + kñ.HelpLink);
            }
        }

        public void Insertar(TextBox txt_code,TextBox txt_date,TextBox txt_producto,TextBox txt_tipo,TextBox txt_detalle,TextBox txt_cantidad)
        {
            string ordenador1 = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string ingresar = "Insert Into abarrote(CodeAbte,Fecha,Producto,Tipo,Detalle,Cantidad)" +
                "Values(@code,@date,@producto,@tipo,@detalle,@cantidad)";

            try
            {

                MySqlConnection con2 = new MySqlConnection(ordenador1);
                con2.Open();
                MySqlCommand cmd2 = new MySqlCommand(ingresar, con2);

                cmd2.Parameters.AddWithValue("@code", txt_code.Text);
                cmd2.Parameters.AddWithValue("@date", txt_date.Text);
                cmd2.Parameters.AddWithValue("@producto", txt_producto.Text);
                cmd2.Parameters.AddWithValue("@tipo", txt_tipo.Text);
                cmd2.Parameters.AddWithValue("@detalle", txt_detalle.Text);
                cmd2.Parameters.AddWithValue("@cantidad", txt_cantidad.Text);
                cmd2.ExecuteNonQuery();

                con2.Close();

                MessageBox.Show("Data Input with successfully in table 'Abarrotes'");

            }
            catch (MySqlException hj)
            {

                MessageBox.Show("Request is wrong, contact engeenier" + hj.HelpLink);
            }
        }

        public void UpdateData(TextBox txt_code, TextBox txt_date, TextBox txt_producto,TextBox  txt_tipo, TextBox txt_detalle, TextBox txt_cantidad)
        {
            string servicio = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string actualizar = "UPDATE abarrote SET CodeAbte=@code,Fecha=@date ,Producto=@name,Tipo=@tipo ,Detalle=@detalle ,Cantidad=@cantidad " +
                "WHERE CodeAbte=@code";

            try
            {

                MySqlConnection cde = new MySqlConnection(servicio);
                cde.Open();
                MySqlCommand dmc = new MySqlCommand(actualizar, cde);

                dmc.Parameters.AddWithValue("@code", txt_code.Text);
                dmc.Parameters.AddWithValue("@date", txt_date.Text);
                dmc.Parameters.AddWithValue("@name", txt_producto.Text);
                dmc.Parameters.AddWithValue("@tipo", txt_tipo.Text);
                dmc.Parameters.AddWithValue("@detalle", txt_detalle.Text);
                dmc.Parameters.AddWithValue("@cantidad", txt_cantidad.Text);
                dmc.ExecuteNonQuery();

                cde.Close();

                MessageBox.Show("Updated data with success on table 'Abarrotes', thanks¡¡¡");


            }
            catch (MySqlException mnl)
            {

                MessageBox.Show(mnl.Message);
            }
        }

        public void Eliminar(TextBox txt_code)
        {
            string servidor = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string erase = "DELETE FROM abarrote WHERE CodeAbte=@code";

            try
            {
                MySqlConnection ces = new MySqlConnection(servidor);
                ces.Open();
                MySqlCommand cddm = new MySqlCommand(erase, ces);

                cddm.Parameters.AddWithValue("@code", txt_code.Text);
                cddm.ExecuteNonQuery();

                ces.Close();

                MessageBox.Show("Erase data with success from table Abarrotes, thanks¡¡");

            }
            catch (MySqlException JK)
            {

                MessageBox.Show("Request is wrong, contact engeenier" + JK.HelpLink);
            }
        }

        public void LimmpiarCasillas(TextBox txt_code,TextBox txt_date,TextBox txt_producto,TextBox txt_tipo,TextBox txt_detalle,TextBox txt_cantidad)
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
