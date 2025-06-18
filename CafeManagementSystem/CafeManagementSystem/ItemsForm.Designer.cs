namespace CafeManagementSystem
{
    partial class ItemsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsForm));
            panel1 = new Panel();
            DeleteBtn = new Button();
            EditBtn = new Button();
            label6 = new Label();
            ItemPrice = new TextBox();
            ItemNameTb = new TextBox();
            label5 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            ItemGV = new DataGridView();
            CatCb = new ComboBox();
            label1 = new Label();
            button5 = new Button();
            button4 = new Button();
            label4 = new Label();
            button2 = new Button();
            ItemNumTb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(ItemNumTb);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ItemPrice);
            panel1.Controls.Add(ItemNameTb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ItemGV);
            panel1.Controls.Add(CatCb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(183, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 837);
            panel1.TabIndex = 15;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.RosyBrown;
            DeleteBtn.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.Location = new Point(30, 639);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(141, 61);
            DeleteBtn.TabIndex = 18;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.RosyBrown;
            EditBtn.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.Location = new Point(30, 548);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(141, 61);
            EditBtn.TabIndex = 17;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Marker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 373);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 16;
            label6.Text = "ItemPrice";
            // 
            // ItemPrice
            // 
            ItemPrice.Font = new Font("Segoe Marker", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ItemPrice.ForeColor = Color.FromArgb(255, 128, 128);
            ItemPrice.Location = new Point(128, 367);
            ItemPrice.Multiline = true;
            ItemPrice.Name = "ItemPrice";
            ItemPrice.Size = new Size(193, 51);
            ItemPrice.TabIndex = 15;
            // 
            // ItemNameTb
            // 
            ItemNameTb.Font = new Font("Segoe Marker", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ItemNameTb.ForeColor = Color.FromArgb(255, 128, 128);
            ItemNameTb.Location = new Point(128, 217);
            ItemNameTb.Multiline = true;
            ItemNameTb.Name = "ItemNameTb";
            ItemNameTb.Size = new Size(193, 51);
            ItemNameTb.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Marker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 223);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 13;
            label5.Text = "ItemName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Marker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 141);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 12;
            label3.Text = "ItemNum";
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(30, 461);
            button1.Name = "button1";
            button1.Size = new Size(141, 61);
            button1.TabIndex = 8;
            button1.Text = "Add ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Marker", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(655, 168);
            label2.Name = "label2";
            label2.Size = new Size(135, 40);
            label2.TabIndex = 6;
            label2.Text = "Items List";
            // 
            // ItemGV
            // 
            ItemGV.BackgroundColor = SystemColors.Control;
            ItemGV.BorderStyle = BorderStyle.None;
            ItemGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemGV.Location = new Point(354, 217);
            ItemGV.Name = "ItemGV";
            ItemGV.RowHeadersWidth = 51;
            ItemGV.RowTemplate.Height = 29;
            ItemGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemGV.Size = new Size(702, 555);
            ItemGV.TabIndex = 3;
            ItemGV.CellContentClick += ItemGV_CellContentClick;
            // 
            // CatCb
            // 
            CatCb.BackColor = SystemColors.Control;
            CatCb.Font = new Font("Segoe Marker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Food", "Cold Drink", "Coffee" });
            CatCb.Location = new Point(128, 304);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(193, 36);
            CatCb.TabIndex = 2;
            CatCb.Text = "Categories";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSalmon;
            label1.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(409, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 58);
            label1.TabIndex = 1;
            label1.Text = "MANAGE ITEMS";
            // 
            // button5
            // 
            button5.BackColor = Color.RosyBrown;
            button5.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(21, 276);
            button5.Name = "button5";
            button5.Size = new Size(118, 61);
            button5.TabIndex = 18;
            button5.Text = "Users";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.RosyBrown;
            button4.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(21, 197);
            button4.Name = "button4";
            button4.Size = new Size(118, 61);
            button4.TabIndex = 17;
            button4.Text = "Order";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Firebrick;
            label4.Font = new Font("Segoe Marker", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1247, 11);
            label4.Name = "label4";
            label4.Size = new Size(29, 35);
            label4.TabIndex = 14;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(21, 824);
            button2.Name = "button2";
            button2.Size = new Size(118, 61);
            button2.TabIndex = 16;
            button2.Text = "LogOut";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ItemNumTb
            // 
            ItemNumTb.Font = new Font("Segoe Marker", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ItemNumTb.ForeColor = Color.FromArgb(255, 128, 128);
            ItemNumTb.Location = new Point(130, 141);
            ItemNumTb.Multiline = true;
            ItemNumTb.Name = "ItemNumTb";
            ItemNumTb.Size = new Size(193, 51);
            ItemNumTb.TabIndex = 19;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(1297, 884);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemsForm";
            Load += ItemsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label2;
        private DataGridView ItemGV;
        private ComboBox CatCb;
        private Label label1;
        private Button button5;
        private Button button4;
        private Label label4;
        private Button button2;
        private TextBox ItemNameTb;
        private Label label5;
        private Label label3;
        private Label label6;
        private TextBox ItemPrice;
        private Button EditBtn;
        private Button DeleteBtn;
        private TextBox ItemNumTb;
    }
}