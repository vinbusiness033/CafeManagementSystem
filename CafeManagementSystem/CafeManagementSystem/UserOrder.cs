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

namespace CafeManagementSystem
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\source\repos\CafeManagementSystem\CafeDB.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemGV.DataSource = ds.Tables[0];
            con.Close();
        }

        void Filterbycategory()
        {
            con.Open();
            string query = "select * from ItemTbl where ItemCat='" + CatCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemGV.DataSource = ds.Tables[0];
            con.Close();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm Item = new ItemsForm();
            Item.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm uform = new UserForm();
            uform.Show();
        }
        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;

        private void UserOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(String));
            table.Columns.Add("Category", typeof(String));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrderGV.DataSource = table;
            DateLbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            SellerNameTb.Text = Form1.User;
            SellerNameTb.ReadOnly = true;
        }

        int num = 0;
        int total, price, qty;
        string item, cat;
        private void ItemGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            item = ItemGV.SelectedRows[0].Cells[1].Value.ToString();
            cat = ItemGV.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;

        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("What is the quantity");
            }
            else if (flag == 0)
            {
                MessageBox.Show("select the product to be ordered");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(QtyTb.Text);
                table.Rows.Add(num, item, cat, price, total);
                OrderGV.DataSource = table;
                flag = 0;
            }
            sum = sum + total;
            OrderAmtLbl.Text = "" + sum;

        }

        private void QtyTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filterbycategory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void QtyTb_Enter(object sender, EventArgs e)
        {
            if (QtyTb.Text == "Quantity")
            {
                QtyTb.Text = "";
                QtyTb.ForeColor = Color.Black;
            }
        }

        private void QtyTb_Leave(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                QtyTb.Text = "Quantity";
                QtyTb.ForeColor = Color.Silver;
            }
        }

        private void DateLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            if (OrderNumTb.Text != "" || DateLbl.Text != "" || SellerNameTb.Text != "" || OrderAmtLbl.Text != "")
            {
                con.Open();
                SqlCommand cmd3 = new SqlCommand("select OrderNum from OrdersTbl where OrderNum=@OrderNum", con);
                cmd3.Parameters.AddWithValue("OrderNum", OrderNumTb.Text);
                SqlDataReader myreader = cmd3.ExecuteReader();
                if (myreader.Read())
                {
                    con.Close();
                    MessageBox.Show("Order Number already exist!!, Enter the Next number");
                }
                else
                {
                    con.Close();

                    con.Open();
                    string query = "insert into OrdersTbl values(" + OrderNumTb.Text + ",'" + DateLbl.Text + "','" + SellerNameTb.Text + "'," + OrderAmtLbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Successfull created");
                    con.Close();
                }
            }
            else
            {

                MessageBox.Show("Enter order number!! ");

            }





        }

        private void OrderNumTb_Enter(object sender, EventArgs e)
        {
            if (OrderNumTb.Text == "Order Num")
            {
                OrderNumTb.Text = "";
                OrderNumTb.ForeColor = Color.Black;
            }
        }

        private void OrderNumTb_Leave(object sender, EventArgs e)
        {
            if (OrderNumTb.Text == "")
            {
                OrderNumTb.Text = "Order Num";
                OrderNumTb.ForeColor = Color.Silver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void SellerNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderNumTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
