using System.Data;
using System.Data.SqlClient;
namespace stocks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static string LoggedUser;

        private void bt_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-LLLKH3O;Initial Catalog=stocks;Integrated Security=True";
            con.Open();
            string userid = tb_username.Text;
            string password = tb_password.Text;
            SqlCommand cmd = new SqlCommand("select Username,Password from users where Username='" + userid + "'and Password='" + password + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess");
                this.Hide();
                new Form2().Show();
                LoggedUser = userid;
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();

        }


    }
}