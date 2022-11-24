using System;
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
            lb_username.Text = Form1.LoggedUser;
            Auto();
        }
        public void Auto()

        {

            da = new SqlDataAdapter("select pn from stock order by name asc", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)

            {

                for (int i = 0; i < dt.Rows.Count; i++)

                {
                    coll.Add(dt.Rows[i]["Name"].ToString());
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
    }
}
