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

namespace LoginPage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentInfo;Integrated Security=True");
            con.Open();
            SqlCommand sqcmd = new SqlCommand("SELECT * FROM LoginDetails WHERE UserName='" + txt_user.Text + "' and Password='" + txt_pass.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Form1 wel = new Form1();
                wel.Show();

                wel.login_panel.Visible = false;
            }

            else
            {
                MessageBox.Show("Please check your username and/or password.");
            }

            con.Close();
        }
    }
}
