using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace AppartmentManagemnetSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"workstation id = apartment.mssql.somee.com; packet size = 4096; user id = daniomena_SQLLogin_1; pwd = x8qc4bjh5f; data source = apartment.mssql.somee.com; persist security info = False; initial catalog = apartment");
            con.Open();
            try
            {
                string gen = string.Empty;
                if (radioButton1.Checked)
                {
                    gen = "Male";
                }
                else
                {
                    gen = "Female";
                }
                string str = "INSERT INTO register(name,gender,mobile,email,position,pass) VALUES('" + textBox2.Text + "','" + gen + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(Id) from register;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("New User Information Saved Successfully..");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    radioButton1.Checked = true ;
                    this.Hide();
                    //Login obj2 = new AppartmentManagemnetSystem.Login();
                    //obj2.ShowDialog();
                }

            }
            
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            radioButton1.Checked = true;
        }
    }
}
