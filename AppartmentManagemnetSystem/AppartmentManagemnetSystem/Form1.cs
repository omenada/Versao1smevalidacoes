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

namespace AppartmentManagemnetSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    
                SqlConnection con = new SqlConnection(@"workstation id=apartment.mssql.somee.com;packet size=4096;user id=daniomena_SQLLogin_1;pwd=x8qc4bjh5f;data source=apartment.mssql.somee.com;persist security info=False;initial catalog=apartment");
                con.Open();
                        
                string str = "SELECT id FROM register WHERE name = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                        
            if (dr.Read())
            {
                this.Hide();
                Home obj2 = new Home();
                obj2.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";

            }
            else
            {
                MessageBox.Show("Invalid username and Password.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register obj2 = new AppartmentManagemnetSystem.Register();
            obj2.ShowDialog();
        }
    }
}
