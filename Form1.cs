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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentInfo;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [StudentInfo]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGrid.DataSource = dta;
            dataGrid2.DataSource = dta;
            con.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           

                this.Hide();
                Login wel = new Login();
                wel.Show();
         
        }

        /*public void FormLoadWidgets()
        {
            txt_reg.Text = "";
            txt_name.Text = "";
            pictureBox1.Image = null;

            txt_reg.Enabled = false;
            txt_name.Enabled = false;
            txt_course.Enabled = false;
            txt_dept.Enabled = false;

            btn_login.Show();
            btn_display.Show();
            btn_search.Show();

            btn_login.Enabled = true;
            btn_display.Enabled = true;
            btn_search.Enabled = true;

            btn_insert.Hide();
            btn_update.Hide();
            btn_delete.Hide();

     
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentInfoDataSet2.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter2.Fill(this.studentInfoDataSet2.StudentInfo);
            // TODO: This line of code loads data into the 'studentInfoDataSet1.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter1.Fill(this.studentInfoDataSet1.StudentInfo);
            // TODO: This line of code loads data into the 'studentInfoDataSet.StudentInfo' table. You can move, or remove it, as needed.
            // this.studentInfoTableAdapter.Fill(this.studentInfoDataSet.StudentInfo);


        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myindex = e.RowIndex;
            DataGridViewRow row = dataGrid.Rows[myindex];

            string reg = row.Cells[0].Value.ToString();
            string value1 = row.Cells[1].Value.ToString();
            string value2 = row.Cells[2].Value.ToString();
            string value3 = row.Cells[3].Value.ToString();
            string value4 = row.Cells[4].Value.ToString();

            txt_reg.Text = reg;
            txt_reg.Enabled = false;

            txt_name.Text = value1;
            txt_course.Text = value2;
            txt_dept.Text = value3;
            txt_year.Text = value4;

            btn_insert.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            string search = txt_search.Text;
            SqlCommand sqcmd = new SqlCommand("SELECT * FROM [StudentInfo] WHERE Name Like '%" + search + "%' OR Department Like '%" + search + "%' OR Course Like '%" + search  + "%' OR Year Like '%" + search + "%'", con);

            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0 )
            {
                dataGrid.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("No record found.");
                con.Close();
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sqcmd = new SqlCommand("Select * from [StudentInfo] where RegID='" + txt_reg.Text + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                con.Close();
                MessageBox.Show("Register ID already exists.");
            }

            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [StudentInfo] (RegID, Name, Course, Department, Year) values ('" + txt_reg.Text + "','" + txt_name.Text + "','" + txt_course.Text + "','" + txt_dept.Text + "','" + txt_year.Text + "')";

                cmd.ExecuteNonQuery();
                con.Close();
                txt_reg.Text = "";
                txt_name.Text = "";
                txt_course.Text = "";
                txt_course.Text = "";
                display_data();
                MessageBox.Show("Data insterted Successfully.");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [StudentInfo] set Name='" + txt_name.Text + "', Course='" + txt_course.Text + "', Department='" + txt_dept.Text + "', Year='" + txt_year.Text +  "'where RegID='" + txt_reg.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();
            display_data();

            txt_reg.Text = "";
            txt_name.Text = "";
            txt_course.Text = "";
            txt_dept.Text = "";

            btn_insert.Enabled = true;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;

            txt_reg.Enabled = true;

            MessageBox.Show("Data updated successfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string confirmDelete = "Are you sure you want to delete this record?";
            string header = "Confirm deletion";

            MessageBoxButtons messagebtn = MessageBoxButtons.OKCancel;

            DialogResult dialog = MessageBox.Show(confirmDelete, header, messagebtn);

            if (dialog == DialogResult.OK)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [StudentInfo] where RegID='" + txt_reg.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();



                txt_reg.Text = "";
                txt_name.Text = "";
                txt_course.Text = "";
                txt_dept.Text = "";
                txt_year.Text = "";

                btn_insert.Enabled = true;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;

                txt_reg.Enabled = true;

                MessageBox.Show("Data deleted successfully");
            }
            else if (dialog == DialogResult.Cancel)
            {

            }

            
        }

        //Start page panel

        private void btn_login2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login wel = new Login();
            wel.Show();
        }

        private void btn_search2_Click(object sender, EventArgs e)
        {
            con.Open();
            string search = txt_search2.Text;
            SqlCommand sqcmd = new SqlCommand("SELECT * FROM [StudentInfo] WHERE Name Like '%" + search + "%' OR Department Like '%" + search + "%' OR Course Like '%" + search + "%' OR Year Like '%" + search + "%'", con);

            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGrid2.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("No record found.");
                con.Close();
            }
        }

        private void dataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myindex = e.RowIndex;
            DataGridViewRow row = dataGrid2.Rows[myindex];

            string reg = row.Cells[0].Value.ToString();
            string value1 = row.Cells[1].Value.ToString();
            string value2 = row.Cells[2].Value.ToString();
            string value3 = row.Cells[3].Value.ToString();
            string value4 = row.Cells[4].Value.ToString();

            txt_reg.Text = reg;
            txt_reg.Enabled = false;

            txt_name.Text = value1;
            txt_course.Text = value2;
            txt_dept.Text = value3;
            txt_year.Text = value4;


        }

        private void btn_display2_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
