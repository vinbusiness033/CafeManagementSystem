namespace CafeManagementSystem
{
    partial class GuestOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestOrder));
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            DateLbl = new Label();
            button4 = new Button();
            button3 = new Button();
            QtyTb = new TextBox();
            label3 = new Label();
            button1 = new Button();
            OrderGV = new DataGridView();
            OrderAmtLbl = new Label();
            SellernameTb = new TextBox();
            OrderNumTb = new TextBox();
            ItemGV = new DataGridView();
            CatCb = new ComboBox();
            label1 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemGV).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Firebrick;
            label4.Font = new Font("Segoe Marker", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1256, 9);
            label4.Name = "label4";
            label4.Size = new Size(29, 35);
            label4.TabIndex = 6;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DateLbl);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(QtyTb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(OrderGV);
            panel1.Controls.Add(OrderAmtLbl);
            panel1.Controls.Add(SellernameTb);
            panel1.Controls.Add(OrderNumTb);
            panel1.Controls.Add(ItemGV);
            panel1.Controls.Add(CatCb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(192, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 837);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkSalmon;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(112, 127);
            label2.Name = "label2";
            label2.Size = new Size(220, 38);
            label2.TabIndex = 17;
            label2.Text = "Filter";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // DateLbl
            // 
            DateLbl.AutoSize = true;
            DateLbl.Font = new Font("Segoe Marker", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            DateLbl.Location = new Point(774, 27);
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new Size(74, 40);
            DateLbl.TabIndex = 13;
            DateLbl.Text = "Date";
            DateLbl.Click += DateLbl_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSalmon;
            button4.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(137, 221);
            button4.Name = "button4";
            button4.Size = new Size(171, 47);
            button4.TabIndex = 12;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSalmon;
            button3.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(566, 724);
            button3.Name = "button3";
            button3.Size = new Size(222, 51);
            button3.TabIndex = 11;
            button3.Text = "Place the Order";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // QtyTb
            // 
            QtyTb.Font = new Font("Segoe Marker", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            QtyTb.ForeColor = Color.Gray;
            QtyTb.Location = new Point(338, 388);
            QtyTb.Multiline = true;
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(186, 45);
            QtyTb.TabIndex = 10;
            QtyTb.Text = "Quantity";
            QtyTb.TextChanged += QtyTb_TextChanged;
            QtyTb.Enter += QtyTb_Enter;
            QtyTb.Leave += QtyTb_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSalmon;
            label3.Font = new Font("Segoe Marker", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(621, 455);
            label3.Name = "label3";
            label3.Size = new Size(154, 40);
            label3.TabIndex = 9;
            label3.Text = "Your Order";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(530, 388);
            button1.Name = "button1";
            button1.Size = new Size(222, 45);
            button1.TabIndex = 8;
            button1.Text = "Add To Cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OrderGV
            // 
            OrderGV.BackgroundColor = SystemColors.Control;
            OrderGV.BorderStyle = BorderStyle.None;
            OrderGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGV.Location = new Point(338, 498);
            OrderGV.Name = "OrderGV";
            OrderGV.RowHeadersWidth = 51;
            OrderGV.RowTemplate.Height = 29;
            OrderGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderGV.Size = new Size(752, 220);
            OrderGV.TabIndex = 7;
            // 
            // OrderAmtLbl
            // 
            OrderAmtLbl.AutoSize = true;
            OrderAmtLbl.Font = new Font("Segoe Marker", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            OrderAmtLbl.Location = new Point(895, 724);
            OrderAmtLbl.Name = "OrderAmtLbl";
            OrderAmtLbl.Size = new Size(195, 40);
            OrderAmtLbl.TabIndex = 6;
            OrderAmtLbl.Text = "Order Amount";
            // 
            // SellernameTb
            // 
            SellernameTb.Enabled = false;
            SellernameTb.Font = new Font("Segoe Marker", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SellernameTb.ForeColor = Color.FromArgb(255, 128, 128);
            SellernameTb.Location = new Point(14, 9);
            SellernameTb.Multiline = true;
            SellernameTb.Name = "SellernameTb";
            SellernameTb.Size = new Size(222, 51);
            SellernameTb.TabIndex = 5;
            SellernameTb.Text = "Guest";
            // 
            // OrderNumTb
            // 
            OrderNumTb.Font = new Font("Segoe Marker", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            OrderNumTb.ForeColor = Color.Gray;
            OrderNumTb.Location = new Point(338, 724);
            OrderNumTb.Multiline = true;
            OrderNumTb.Name = "OrderNumTb";
            OrderNumTb.Size = new Size(222, 51);
            OrderNumTb.TabIndex = 4;
            OrderNumTb.Text = "Order Num";
            OrderNumTb.Enter += OrderNumTb_Enter;
            OrderNumTb.Leave += OrderNumTb_Leave;
            // 
            // ItemGV
            // 
            ItemGV.BackgroundColor = SystemColors.Control;
            ItemGV.BorderStyle = BorderStyle.None;
            ItemGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemGV.Location = new Point(338, 85);
            ItemGV.Name = "ItemGV";
            ItemGV.RowHeadersWidth = 51;
            ItemGV.RowTemplate.Height = 29;
            ItemGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemGV.Size = new Size(752, 297);
            ItemGV.TabIndex = 3;
            ItemGV.CellContentClick += ItemGV_CellContentClick;
            // 
            // CatCb
            // 
            CatCb.BackColor = SystemColors.Control;
            CatCb.Font = new Font("Segoe Marker", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Food", "Cold Drink", "Coffee" });
            CatCb.Location = new Point(112, 168);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(222, 47);
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
            label1.Location = new Point(390, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 58);
            label1.TabIndex = 1;
            label1.Text = "PLACE ORDER";
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(46, 822);
            button2.Name = "button2";
            button2.Size = new Size(118, 62);
            button2.TabIndex = 8;
            button2.Text = "LogOut";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // GuestOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(1297, 896);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GuestOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemForm";
            Load += GuestOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel1;
        private Button button2;
        private Label label1;
        private ComboBox CatCb;
        private DataGridView ItemGV;
        private TextBox SellernameTb;
        private TextBox OrderNumTb;
        private Label OrderAmtLbl;
        private DataGridView OrderGV;
        private Button button1;
        private Button button3;
        private TextBox QtyTb;
        private Label label3;
        private Button button4;
        private Label DateLbl;
        private Label label2;
    }
}