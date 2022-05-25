using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conchitastore
{
    class password
    {


        public void Contraseña(TextBox textBox1, TextBox textBox2)
        {
            string user, pass;


            try
            {

                user = textBox1.Text;
                pass = textBox2.Text;


                if (user == "Carmen" && pass == "tienda12345678")
                {
                    Program.form1.Hide();
                    Form2 nv = new Form2();
                    nv.Show();

                }
                if (user == "" && pass == "")
                {
                    MessageBox.Show("Please Complete the fields, You have clears textbox");
                }
                



            } catch (Exception lk) { 



                MessageBox.Show("Wrong Input, only letters, never numbers or mixed, please try again¡¡" + " " + lk.Message);
            }   
            
        }


    }
}
