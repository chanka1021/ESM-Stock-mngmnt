using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stocks
{
    public partial class Form2 : Form
    {
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LLLKH3O;Initial Catalog=stocks;Integrated Security=True");
        SqlDataAdapter da;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Auto();
            lb_username.Text = Form1.LoggedUser;
            da = new SqlDataAdapter("select * from histo ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg_histo.DataSource = dt;

        }
        public void Auto()

        {
            da = new SqlDataAdapter("select * from stock order by pn asc", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    coll.Add(dt.Rows[i]["pn"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Name not found");
            }
            tb_pn.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_pn.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb_pn.AutoCompleteCustomSource = coll;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_machine.Enabled = true;
            numericUp_qtt.Enabled = true;
            bt_insert.Enabled = true;
            //stock check
            da = new SqlDataAdapter("select * from stock where  Pn = '" + tb_pn.Text+ "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string pn = tb_pn.Text;
           int stock = (from DataRow dr in dt.Rows
                  where (string)dr["Pn"] == pn
                  select (int)dr["Stock"]).FirstOrDefault();
            tb_stock.Text=stock.ToString();
            numericUp_qtt.Maximum = stock;
            ///
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            con.Open();
if (tb_machine.Text.All(Char.IsDigit) && tb_machine.Text !="" && tb_stock.Text.All(Char.IsDigit) && tb_stock.Text != "") 
            {
            //// UPDATE STOCK
            int newstock = Int32.Parse(tb_stock.Text)- Decimal.ToInt32(numericUp_qtt.Value);
            string pn = tb_pn.Text;
            string querystk = "UPDATE stock SET stock=@newstock WHERE Pn=@pn";
            SqlCommand cmd2 = new SqlCommand(querystk, con);
            cmd2.Parameters.AddWithValue("@newstock", newstock);
            cmd2.Parameters.AddWithValue("@pn", pn);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("stock updated");
            /////////////////INSERT INTO HISTORIQUE TABLE
            ///

            
                DateTime Date = DateTime.Now;
                string username = Form1.LoggedUser;
                string qtt = numericUp_qtt.Text;
                string machine = tb_machine.Text;

                try
                {
                    SqlCommand cmd = new SqlCommand("Insert Into histo (date,username,pn,qtt,machine) values (@Date,@username,@pn,@qtt,@machine)", con);
                    cmd.Parameters.AddWithValue("@date", Date);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pn", pn);
                    cmd.Parameters.AddWithValue("@qtt", qtt);
                    cmd.Parameters.AddWithValue("@machine", machine);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("historique Inserted Successfully!");
                        tb_pn.Text = "";
                        numericUp_qtt.Text = "1";
                        tb_machine.Text = "";
                        //RELOAD DATAGRID
                        dg_histo.DataSource = null;
                        da = new SqlDataAdapter("select * from histo ", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dg_histo.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("We have found error with operation on database: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("We have found error in your code: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }else { MessageBox.Show(" values is null or not digit !!!"); }
           

        }
    }
}
