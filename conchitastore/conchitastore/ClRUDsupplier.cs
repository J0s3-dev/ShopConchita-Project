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
    class ClRUDsupplier : Connection
    {

        public void Ingresardata(TextBox txt_code,TextBox txt_name,TextBox txt_address,TextBox txt_phone,TextBox txt_sale)
        {
            string name, dir, tel, producto;
            int code;
            string server = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306;";
            string insertar = "Insert Into supplier(CodeSupplier,Name,Addres,Phone,ProductSale)" +
                "Values(@code,@name,@address,@phone,@sale)";

            try
            {
                code = Convert.ToInt16(txt_code.Text);
                name = txt_name.Text;
                dir = txt_address.Text;
                tel = txt_phone.Text;
                producto = txt_sale.Text;

                MySqlConnection con = new MySqlConnection(server);
                con.Open();

                MySqlCommand cmd = new MySqlCommand(insertar, con);


                cmd.Parameters.AddWithValue("@code", code.ToString());
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", dir);
                cmd.Parameters.AddWithValue("@phone", tel);
                cmd.Parameters.AddWithValue("@sale", producto);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Loaded data with successfully");

            }
            catch (Exception mes)
            {

                MessageBox.Show("Requested is FAILURE, please try again." + mes.Message);
            }
        }

        public void Limpiardatos(TextBox txt_code, TextBox txt_name, TextBox txt_address, TextBox txt_phone, TextBox txt_sale)
        {
            txt_code.Clear();
            txt_name.Clear();
            txt_address.Clear();
            txt_phone.Clear();
            txt_sale.Clear();


            txt_code.Focus();
        }

        public void Mostrar(DataGridView dgv_1)
        {
            string servidor = "server=127.0.0.1;uid=root;pwd='';database=shop;port=3306;";
            string query = "Select * From supplier";

            try
            {
                MySqlConnection cnt = new MySqlConnection(servidor);
                cnt.Open();
                MySqlCommand cdm = new MySqlCommand(query, cnt);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cdm);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                dgv_1.DataSource = tabla;

            }
            catch (Exception mk)
            {

                MessageBox.Show("Try again, is wrong to requested fields " + mk.Message);
            }
        }


        public void UpdateData(TextBox txt_code,TextBox txt_name,TextBox txt_address,TextBox txt_phone, TextBox txt_sale)
        {

            string server = "server=127.0.0.1;port=3306;uid=root;pwd='';database=shop";
            string actualizar = "UPDATE supplier SET CodeSupplier=@code ,Name=@name ,Addres=@adres ,Phone=@phone ,ProductSale=@sale " +
                "WHERE CodeSupplier=@code";
            try
            {
                MySqlConnection con = new MySqlConnection(server);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(actualizar, con);

                cmd.Parameters.AddWithValue("@code", txt_code.Text);
                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                cmd.Parameters.AddWithValue("@adres", txt_address.Text);
                cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                cmd.Parameters.AddWithValue("@sale", txt_sale.Text);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Data with Successfully");

            }
            catch (MySqlException sl)
            {

                MessageBox.Show("Incorrect Data, please call your operator system" + sl.Message);
            }





        }

        public void Delete(TextBox txt_code)
        {

            string servidor = "server=localhost;uid=root;pwd='';database=shop;port=3306";
            string erase = "DELETE FROM supplier WHERE CodeSupplier=@code";

            try
            {
                MySqlConnection con = new MySqlConnection(servidor);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(erase, con);

                cmd.Parameters.AddWithValue("@code", txt_code.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Erase data with success");

            }
            catch (MySqlException li)
            {

                MessageBox.Show("Bad request, try again¡¡" + li.Message);
            }

        }




        


    }
}
