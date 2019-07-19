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
    public partial class Apartment : Form
    {
        public Apartment()
        {
            InitializeComponent();
        }

        private void Apartment_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'apartmentDataSet.apart' table. 
            //this.apartTableAdapter.Fill(this.apartmentDataSet.apart);
            using (SqlConnection con1 = new SqlConnection(@"workstation id=apartment.mssql.somee.com;packet size=4096;user id=daniomena_SQLLogin_1;pwd=x8qc4bjh5f;data source=apartment.mssql.somee.com;persist security info=False;initial catalog=apartment"))
            {

                string str2 = "SELECT * FROM apart";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);

            }
            SqlConnection con = new SqlConnection(@"workstation id=apartment.mssql.somee.com;packet size=4096;user id=daniomena_SQLLogin_1;pwd=x8qc4bjh5f;data source=apartment.mssql.somee.com;persist security info=False;initial catalog=apartment");
            con.Open();
            string str1 = "select max(id) from entry;";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox1.Text = a.ToString();
                }
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"workstation id=apartment.mssql.somee.com;packet size=4096;user id=daniomena_SQLLogin_1;pwd=x8qc4bjh5f;data source=apartment.mssql.somee.com;persist security info=False;initial catalog=apartment");
            con.Open();
            try
            {
                string str = "INSERT INTO apart(owner_name,family_member,email,gender,mobile,wing,floor,flat_number,area,c_position) VALUES('" + textBox2.Text + "','" +textBox3.Text  + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','"+textBox10.Text +"','"+textBox11.Text +"'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(Id) from apart;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("New Appartment Information Saved Successfully..");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    
                    using (SqlConnection con1 = new SqlConnection(@"workstation id=apartment.mssql.somee.com;packet size=4096;user id=daniomena_SQLLogin_1;pwd=x8qc4bjh5f;data source=apartment.mssql.somee.com;persist security info=False;initial catalog=apartment"))
                    {

                        string str2 = "SELECT * FROM apart";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);

                    }
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
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";

        }
    }
}
