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
    class Connection
    {
        

        public void Conectar(Label label6)
        {

            string connection = "server=127.0.0.1;port=3306;uid=root;pwd='';database=shop;";

            try
            {
                MySqlConnection con = new MySqlConnection(connection);
                con.Open();
                label6.Text = " Estado: Conectado a Base de datos";
                
            }
            catch (Exception con)
            {

                MessageBox.Show("The connection is failure, please contact your Engeenier" + con.Message);
            }



        }

        public void Desconection(Label label6)
        {
            string connection = "server=127.0.0.1;port=3306;uid=root;pwd='';database=shop;";

            try
            {
                MySqlConnection cn = new MySqlConnection(connection);
                cn.Close();
                label6.Text = "Estado: Desconectado, adios¡¡";
               
            }
            catch (Exception ml)
            {

                MessageBox.Show("Ths conection is failure, try again please");
            }

        }



    }
}
