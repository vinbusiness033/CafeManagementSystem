using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace CafeManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\source\repos\CafeManagementSystem\CafeDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder Guest = new GuestOrder();
            Guest.Show();
        }
        public static string User;


        private void button1_Click(object sender, EventArgs e)
        {
            User = unameTb.Text;

            if (unameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Please Enter username and password");
            }
            else
            {
                con.Open();
                SqlDataAdapter sad = new SqlDataAdapter("select count(*) from UserTbl where Uname='" + unameTb.Text + "'and UPassword='" + PasswordTb.Text + "'", con);
                DataTable dt = new DataTable();
                sad.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    UserOrder Uorder = new UserOrder();
                    Uorder.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("wrong username or password");

                }
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void cbshow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshow.Checked)
            {
                PasswordTb.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordTb.UseSystemPasswordChar = false;
            }

        }
    }
}