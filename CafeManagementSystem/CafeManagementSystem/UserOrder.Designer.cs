namespace CafeManagementSystem
{
    partial class UserOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOrder));
            panel1 = new Panel();
            label2 = new Label();
            button3 = new Button();
            DateLbl = new Label();
            button1 = new Button();
            PlaceOrderBtn = new Button();
            QtyTb = new TextBox();
            label3 = new Label();
            AddToCartBtn = new Button();
            OrderGV = new DataGridView();
            OrderAmtLbl = new Label();
            SellerNameTb = new TextBox();
            OrderNumTb = new TextBox();
            ItemGV = new DataGridView();
            CatCb = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(DateLbl);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(PlaceOrderBtn);
            panel1.Controls.Add(QtyTb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(AddToCartBtn);
            panel1.Controls.Add(OrderGV);
            panel1.Controls.Add(OrderAmtLbl);
            panel1.Controls.Add(SellerNameTb);
            panel1.Controls.Add(OrderNumTb);
            panel1.Controls.Add(ItemGV);
            panel1.Controls.Add(CatCb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(192, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 917);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkSalmon;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(122, 147);
            label2.Name = "label2";
            label2.Size = new Size(220, 38);
            label2.TabIndex = 16;
            label2.Text = "Filter";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSalmon;
            button3.Font = new Font("Segoe Marker", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(885, 777);
            button3.Name = "button3";
            button3.Size = new Size(195, 58);
            button3.TabIndex = 15;
            button3.Text = "View Orders";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // DateLbl
            // 
            DateLbl.AutoSize = true;
            DateLbl.Font = new Font("Segoe Marker", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            DateLbl.Location = new Point(751, 23);
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new Size(74, 40);
            DateLbl.TabIndex = 14;
            DateLbl.Text = "Date";
            DateLbl.Click += DateLbl_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(155, 241);
            button1.Name = "button1";
            button1.Size = new Size(150, 47);
            button1.TabIndex = 12;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PlaceOrderBtn
            // 
            PlaceOrderBtn.BackColor = Color.DarkSalmon;
            PlaceOrderBtn.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PlaceOrderBtn.Location = new Point(537, 714);
            PlaceOrderBtn.Name = "PlaceOrderBtn";
            PlaceOrderBtn.Size = new Size(222, 51);
            PlaceOrderBtn.TabIndex = 11;
            PlaceOrderBtn.Text = "Place the Order";
            PlaceOrderBtn.UseVisualStyleBackColor = false;
            PlaceOrderBtn.Click += PlaceOrderBtn_Click;
            // 
            // QtyTb
            // 
            QtyTb.Font = new Font("Segoe Marker", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            QtyTb.ForeColor = Color.DarkGray;
            QtyTb.Location = new Point(361, 349);
            QtyTb.Multiline = true;
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(222, 51);
            QtyTb.TabIndex = 10;
            QtyTb.Text = "Quantity";
            QtyTb.TextAlign = HorizontalAlignment.Right;
            QtyTb.TextChanged += QtyTb_TextChanged;
            QtyTb.Enter += QtyTb_Enter;
            QtyTb.Leave += QtyTb_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Marker", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(628, 425);
            label3.Name = "label3";
            label3.Size = new Size(154, 40);
            label3.TabIndex = 9;
            label3.Text = "Your Order";
            // 
            // AddToCartBtn
            // 
            AddToCartBtn.BackColor = Color.DarkSalmon;
            AddToCartBtn.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddToCartBtn.Location = new Point(589, 349);
            AddToCartBtn.Name = "AddToCartBtn";
            AddToCartBtn.Size = new Size(222, 51);
            AddToCartBtn.TabIndex = 8;
            AddToCartBtn.Text = "Add To Cart";
            AddToCartBtn.UseVisualStyleBackColor = false;
            AddToCartBtn.Click += AddToCartBtn_Click;
            // 
            // OrderGV
            // 
            OrderGV.BackgroundColor = SystemColors.Control;
            OrderGV.BorderStyle = BorderStyle.None;
            OrderGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGV.Location = new Point(309, 485);
            OrderGV.Name = "OrderGV";
            OrderGV.RowHeadersWidth = 51;
            OrderGV.RowTemplate.Height = 29;
            OrderGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderGV.Size = new Size(771, 220);
            OrderGV.TabIndex = 7;
            OrderGV.CellContentClick += OrderGV_CellContentClick;
            // 
            // OrderAmtLbl
            // 
            OrderAmtLbl.AutoSize = true;
            OrderAmtLbl.Font = new Font("Segoe Marker", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            OrderAmtLbl.Location = new Point(885, 714);
            OrderAmtLbl.Name = "OrderAmtLbl";
            OrderAmtLbl.Size = new Size(195, 40);
            OrderAmtLbl.TabIndex = 6;
            OrderAmtLbl.Text = "Order Amount";
            // 
            // SellerNameTb
            // 
            SellerNameTb.Font = new Font("Segoe Marker", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SellerNameTb.ForeColor = Color.FromArgb(192, 0, 0);
            SellerNameTb.Location = new Point(13, 12);
            SellerNameTb.Multiline = true;
            SellerNameTb.Name = "SellerNameTb";
            SellerNameTb.Size = new Size(267, 51);
            SellerNameTb.TabIndex = 5;
            SellerNameTb.Text = "Seller Name";
            SellerNameTb.TextChanged += SellerNameTb_TextChanged;
            // 
            // OrderNumTb
            // 
            OrderNumTb.Font = new Font("Segoe Marker", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            OrderNumTb.ForeColor = Color.Gray;
            OrderNumTb.Location = new Point(309, 711);
            OrderNumTb.Multiline = true;
            OrderNumTb.Name = "OrderNumTb";
            OrderNumTb.Size = new Size(222, 51);
            OrderNumTb.TabIndex = 4;
            OrderNumTb.Text = "Order Num";
            OrderNumTb.TextChanged += OrderNumTb_TextChanged;
            OrderNumTb.Enter += OrderNumTb_Enter;
            OrderNumTb.Leave += OrderNumTb_Leave;
            // 
            // ItemGV
            // 
            ItemGV.BackgroundColor = SystemColors.Control;
            ItemGV.BorderStyle = BorderStyle.None;
            ItemGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemGV.Location = new Point(361, 70);
            ItemGV.Name = "ItemGV";
            ItemGV.RowHeadersWidth = 51;
            ItemGV.RowTemplate.Height = 29;
            ItemGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemGV.Size = new Size(702, 273);
            ItemGV.TabIndex = 3;
            ItemGV.CellContentClick += ItemGV_CellContentClick;
            // 
            // CatCb
            // 
            CatCb.BackColor = SystemColors.Control;
            CatCb.Font = new Font("Segoe Marker", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Food", "Cold Drink", "Coffee" });
            CatCb.Location = new Point(122, 188);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(220, 47);
            CatCb.TabIndex = 2;
            CatCb.Text = "Categories";
            CatCb.SelectionChangeCommitted += CatCb_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSalmon;
            label1.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(381, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 58);
            label1.TabIndex = 1;
            label1.Text = "PLACE ORDER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Firebrick;
            label4.Font = new Font("Segoe Marker", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1256, 11);
            label4.Name = "label4";
            label4.Size = new Size(29, 35);
            label4.TabIndex = 9;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(29, 814);
            button2.Name = "button2";
            button2.Size = new Size(118, 61);
            button2.TabIndex = 11;
            button2.Text = "LogOut";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.RosyBrown;
            button4.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(29, 197);
            button4.Name = "button4";
            button4.Size = new Size(118, 61);
            button4.TabIndex = 12;
            button4.Text = "Item";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.RosyBrown;
            button5.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(29, 276);
            button5.Name = "button5";
            button5.Size = new Size(118, 61);
            button5.TabIndex = 13;
            button5.Text = "Users";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // UserOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(1312, 978);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserOrder";
            Load += UserOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button PlaceOrderBtn;
        private TextBox QtyTb;
        private Label label3;
        private Button AddToCartBtn;
        private DataGridView OrderGV;
        private Label OrderAmtLbl;
        private TextBox SellerNameTb;
        private TextBox OrderNumTb;
        private DataGridView ItemGV;
        private ComboBox CatCb;
        private Label label1;
        private Label label4;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button1;
        private Label DateLbl;
        private Button button3;
        private Label label2;
    }
}