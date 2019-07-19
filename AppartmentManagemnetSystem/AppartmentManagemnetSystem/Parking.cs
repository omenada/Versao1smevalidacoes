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
    public partial class Parking : Form
    {
        public Parking()
        {
            InitializeComponent();
        }

        private void Parking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentDataSet2.parking' table. You can move, or remove it, as needed.
            //this.parkingTableAdapter.Fill(this.apartmentDataSet2.parking);
            SqlConnection con = new SqlConnection(@"workstation id=apartment.mssql.somee.com;packet size=4096;user id=daniomena_SQLLogin_1;pwd=x8qc4bjh5f;data source=apartment.mssql.somee.com;persist security info=False;initial catalog=apartment");
            con.Open();
            string str1 = "select max(id) from parking;";

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
            using (SqlConnection con1 = new SqlConnection(@"workstation id=apartment.mssql.somee.com;packet size=4096;user id=daniomena_SQLLogin_1;pwd=x8qc4bjh5f;data source=apartment.mssql.somee.com;persist security info=False;initial catalog=apartment"))
            {

                string str2 = "SELECT * FROM parking";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"workstation id=apartment.mssql.somee.com;packet size=4096;user id=daniomena_SQLLogin_1;pwd=x8qc4bjh5f;data source=apartment.mssql.somee.com;persist security info=False;initial catalog=apartment");
            con.Open();
            try
            {
                string str = "INSERT INTO parking(brand_name,model,year,veh_type) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(Id) from parking;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("New parking Details Saved Successfully..");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                 

                    using (SqlConnection con1 = new SqlConnection(@"workstation id=apartment.mssql.somee.com;packet size=4096;user id=daniomena_SQLLogin_1;pwd=x8qc4bjh5f;data source=apartment.mssql.somee.com;persist security info=False;initial catalog=apartment"))
                    {

                        string str2 = "SELECT * FROM parking";
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
            SqlConnection con = new SqlConnection(@"workstation id=apartment.mssql.somee.com;packet size=4096;user id=daniomena_SQLLogin_1;pwd=x8qc4bjh5f;data source=apartment.mssql.somee.com;persist security info=False;initial catalog=apartment");

            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select brand_name,model,year,veh_type from parking where id=" + Convert.ToInt32(textBox1.Text) + " ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox2.Text = dr.GetValue(0).ToString();
                        textBox3.Text = dr.GetValue(1).ToString();
                        textBox4.Text = dr.GetValue(2).ToString();
                        textBox5.Text = dr.GetValue(3).ToString();                       
                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This ID, " + textBox1.Text + " parking Record is not Available.   ");
                        textBox1.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
