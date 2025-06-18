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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\source\repos\CafeManagementSystem\CafeDB.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            con.Open();
            string query = "select * from OrdersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrdersGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("******* MY CAFE *******", new Font("Abeezee", 25, FontStyle.Bold), Brushes.RosyBrown, new Point(260, 40));
            e.Graphics.DrawString("*******Orders Summary*******", new Font("Abeezee", 25, FontStyle.Bold), Brushes.RosyBrown, new Point(215, 70));

            e.Graphics.DrawString("Order No: " + OrdersGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Abeezee", 22, FontStyle.Underline), Brushes.Black, new Point(100, 230));
            e.Graphics.DrawString("Order Date: " + OrdersGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Abeezee", 20, FontStyle.Bold), Brushes.Black, new Point(100, 270));
            e.Graphics.DrawString("Seller Name: " + OrdersGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Abeezee", 20, FontStyle.Bold), Brushes.Black, new Point(100, 300));
            e.Graphics.DrawString("Order Amount: " + OrdersGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Abeezee", 20, FontStyle.Bold), Brushes.Black, new Point(100, 330));

            
        }

        private void btnyear_Click(object sender, EventArgs e)
        {
           

        }
    }
}
