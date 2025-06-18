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
using System.Security.Cryptography.X509Certificates;

namespace CafeManagementSystem
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\source\repos\CafeManagementSystem\CafeDB.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder uorder = new UserOrder();
            uorder.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm Item = new ItemsForm();
            Item.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (uphoneTb.TextLength == 10 && unameTb.Text != "" && upassTb.Text != "")
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select Uname from UserTbl where Uname=@Uname", con);
                cmd2.Parameters.AddWithValue("Uname", unameTb.Text);
                SqlDataReader myreader = cmd2.ExecuteReader();
                if (myreader.Read())
                {
                    con.Close();
                    MessageBox.Show("duplicate data");
                }
                else
                {
                    con.Close();

                    con.Open();
                    string query = "insert into UserTbl values('" + unameTb.Text + "','" + uphoneTb.Text + "','" + upassTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfull created");
                    con.Close();
                    populate();
                    reset();
                }
            }
            else
            {
                MessageBox.Show("Error, full fill the requirment");
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            unameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            uphoneTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            upassTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (unameTb.Text == "" || uphoneTb.Text == "" || upassTb.Text == "")
            {
                MessageBox.Show("Fill All the Field");
            }
            else
            {
                con.Open();
                string query = "update UserTbl set Uname='" + unameTb.Text + "',UPassword='" + upassTb.Text + "'where Uphone='" + uphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("user successfully updated");
                con.Close();
                populate();
                reset();
            }
        }

        public void reset()
        {
            unameTb.Text = "";
            upassTb.Text = "";
            uphoneTb.Text = "";
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from UserTbl where Uphone='" + uphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully deleted");
                con.Close();
                populate();
                reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void uphoneTb_TextChanged(object sender, EventArgs e)
        {
            if (uphoneTb.TextLength == 10)
            {
                uphoneTb.ForeColor = Color.Black;
            }
            else
            {
                uphoneTb.ForeColor = Color.Red;
            }
        }

        private void uphoneTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error, Enter only numbers");
            }
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if (uphoneTb.TextLength == 10)
            {
                MessageBox.Show("validate sucessfully");
            }
            else
            {
                MessageBox.Show("phone number should contain 10 characters");
            }
        }

        private void unameTb_TextChanged(object sender, EventArgs e)
        {


        }

        private void unameTb_KeyPress(object sender, KeyPressEventArgs e)
        {



        }
    }
}
