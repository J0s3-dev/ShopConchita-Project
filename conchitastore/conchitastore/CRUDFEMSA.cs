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
    class CRUDFEMSA 
    {


        public void Conectar(Label label6)
        {
            string servidor = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";

            try
            {
                MySqlConnection con = new MySqlConnection(servidor);
                con.Open();
                label6.Text = "Estado : Conectado";

                MessageBox.Show("Connection with successfully¡¡¡");

            }
            catch (MySqlException ls)
            {

                MessageBox.Show("Connection Failure, check on your sintaxis" + ls.Message);
            }
        }


        public void Desconectar(Label label6)
        {
            string servidor = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";

            try
            {
                MySqlConnection con = new MySqlConnection(servidor);
                con.Close();
                label6.Text = "Estado: Desconectado";
            }
            catch (MySqlException ml)
            {

                MessageBox.Show("Connection Failure, check on your sintaxis" + ml.Message); 
            }
        }





        public void Mostra(DataGridView dataGridView1)
        {

            string server = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string query = "SELECT * FROM productfemsa";

            try
            {
                MySqlConnection con = new MySqlConnection(server);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                dataGridView1.DataSource = tabla;

            }
            catch (MySqlException li)
            {

                MessageBox.Show("Requested wrong try again " + li.Message);
            }

        }

        public void InsertData(TextBox txt_code ,TextBox txt_date,TextBox txt_producto,TextBox txt_desc,TextBox txt_quanty)
        {
            string bases = "server=127.0.0.1;uid=root;database=shop;port=3306";
            string insertar = "Insert Into productfemsa(CodeFem,Date,Producto,Detalle,Cantidad)" +
                "Values(@code,@date,@name,@detalle,@sales)";
            int code;

            try
            {
                code = Convert.ToInt16(txt_code.Text);
                MySqlConnection cen = new MySqlConnection(bases);
                cen.Open();
                MySqlCommand cdm = new MySqlCommand(insertar, cen);

                cdm.Parameters.AddWithValue("@code", code.ToString());
                cdm.Parameters.AddWithValue("@date", txt_date.Text);
                cdm.Parameters.AddWithValue("@name", txt_producto.Text);
                cdm.Parameters.AddWithValue("@detalle", txt_desc.Text);
                cdm.Parameters.AddWithValue("@sales", txt_quanty.Text);
                cdm.ExecuteNonQuery();

                cen.Close();

                MessageBox.Show("Load data with successfully into database SHOP, Table FEMSA, thanks¡¡¡");

            }
            catch (Exception ls)
            {

                MessageBox.Show(ls.Message);
            }

        }

        public void Delete(TextBox txt_code)
        {
            string servidor = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string erase = "DELETE FROM productfemsa WHERE CodeFem=@code";

            try
            {
                MySqlConnection ces = new MySqlConnection(servidor);
                ces.Open();
                MySqlCommand cddm = new MySqlCommand(erase, ces);

                cddm.Parameters.AddWithValue("@code", txt_code.Text);
                cddm.ExecuteNonQuery();

                ces.Close();

                MessageBox.Show("Erase data with success from table FEMSA, thanks¡¡");

            }
            catch (MySqlException klm)
            {

                MessageBox.Show(klm.Message);
            }
        }

        public void UpdateData(TextBox txt_code,TextBox txt_date,TextBox txt_producto, TextBox txt_desc, TextBox txt_quanty)
        {
            string servicio = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306";
            string actualizar = "UPDATE productfemsa SET CodeFem=@code,Date=@date ,Producto=@name ,Detalle=@detail ,Cantidad=@sales " +
                "WHERE CodeFem=@code";

            try
            {

                MySqlConnection cde = new MySqlConnection(servicio);
                cde.Open();
                MySqlCommand dmc = new MySqlCommand(actualizar, cde);

                dmc.Parameters.AddWithValue("@code", txt_code.Text);
                dmc.Parameters.AddWithValue("@date", txt_date.Text);
                dmc.Parameters.AddWithValue("@name", txt_producto.Text);
                dmc.Parameters.AddWithValue("@detail", txt_desc.Text);
                dmc.Parameters.AddWithValue("@sales", txt_quanty.Text);
                dmc.ExecuteNonQuery();

                cde.Close();

                MessageBox.Show("Updated data with success on table FEMSA, thanks¡¡¡");


            }
            catch (MySqlException mnl)
            {

                MessageBox.Show(mnl.Message);
            }
        }


    }
}
