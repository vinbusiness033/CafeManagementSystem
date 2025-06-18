namespace CafeManagementSystem
{
    partial class UserForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            button2 = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            label6 = new Label();
            upassTb = new TextBox();
            uphoneTb = new TextBox();
            label5 = new Label();
            label3 = new Label();
            button5 = new Button();
            button4 = new Button();
            AddBtn = new Button();
            label2 = new Label();
            UsersGV = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            unameTb = new TextBox();
            panel1 = new Panel();
            btn_validate = new Button();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(21, 818);
            button2.Name = "button2";
            button2.Size = new Size(118, 61);
            button2.TabIndex = 21;
            button2.Text = "LogOut";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.RosyBrown;
            DeleteBtn.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.Location = new Point(125, 590);
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
            EditBtn.Location = new Point(125, 499);
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
            label6.Location = new Point(30, 305);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 16;
            label6.Text = "Password";
            // 
            // upassTb
            // 
            upassTb.Font = new Font("Segoe Marker", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            upassTb.ForeColor = Color.Black;
            upassTb.Location = new Point(143, 305);
            upassTb.Multiline = true;
            upassTb.Name = "upassTb";
            upassTb.Size = new Size(193, 69);
            upassTb.TabIndex = 15;
            // 
            // uphoneTb
            // 
            uphoneTb.Font = new Font("Segoe Marker", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            uphoneTb.ForeColor = Color.FromArgb(255, 128, 128);
            uphoneTb.Location = new Point(143, 224);
            uphoneTb.MaxLength = 10;
            uphoneTb.Multiline = true;
            uphoneTb.Name = "uphoneTb";
            uphoneTb.Size = new Size(193, 71);
            uphoneTb.TabIndex = 14;
            uphoneTb.TextChanged += uphoneTb_TextChanged;
            uphoneTb.KeyPress += uphoneTb_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Marker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 224);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 13;
            label5.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Marker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 141);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 12;
            label3.Text = "Usersname";
            // 
            // button5
            // 
            button5.BackColor = Color.RosyBrown;
            button5.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(21, 270);
            button5.Name = "button5";
            button5.Size = new Size(118, 61);
            button5.TabIndex = 23;
            button5.Text = "Item";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.RosyBrown;
            button4.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(21, 191);
            button4.Name = "button4";
            button4.Size = new Size(118, 61);
            button4.TabIndex = 22;
            button4.Text = "Order";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.RosyBrown;
            AddBtn.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(125, 412);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(141, 61);
            AddBtn.TabIndex = 8;
            AddBtn.Text = "Add ";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Marker", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(655, 168);
            label2.Name = "label2";
            label2.Size = new Size(135, 40);
            label2.TabIndex = 6;
            label2.Text = "Users List";
            // 
            // UsersGV
            // 
            UsersGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersGV.BackgroundColor = SystemColors.Control;
            UsersGV.BorderStyle = BorderStyle.None;
            UsersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGV.Location = new Point(354, 224);
            UsersGV.Name = "UsersGV";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.RosyBrown;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UsersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UsersGV.RowHeadersVisible = false;
            UsersGV.RowHeadersWidth = 51;
            UsersGV.RowTemplate.Height = 29;
            UsersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGV.Size = new Size(702, 555);
            UsersGV.TabIndex = 3;
            UsersGV.CellContentClick += UsersGV_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSalmon;
            label1.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(409, 9);
            label1.Name = "label1";
            label1.Size = new Size(394, 58);
            label1.TabIndex = 1;
            label1.Text = "MANAGE USERS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Firebrick;
            label4.Font = new Font("Segoe Marker", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1247, 5);
            label4.Name = "label4";
            label4.Size = new Size(29, 35);
            label4.TabIndex = 19;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // unameTb
            // 
            unameTb.Font = new Font("Segoe Marker", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            unameTb.ForeColor = Color.Black;
            unameTb.Location = new Point(143, 141);
            unameTb.Multiline = true;
            unameTb.Name = "unameTb";
            unameTb.Size = new Size(193, 73);
            unameTb.TabIndex = 4;
            unameTb.TextChanged += unameTb_TextChanged;
            unameTb.KeyPress += unameTb_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btn_validate);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(upassTb);
            panel1.Controls.Add(uphoneTb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(unameTb);
            panel1.Controls.Add(UsersGV);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(183, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 837);
            panel1.TabIndex = 20;
            // 
            // btn_validate
            // 
            btn_validate.BackColor = Color.RosyBrown;
            btn_validate.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_validate.Location = new Point(125, 718);
            btn_validate.Name = "btn_validate";
            btn_validate.Size = new Size(159, 61);
            btn_validate.TabIndex = 19;
            btn_validate.Text = "Validate phone";
            btn_validate.UseVisualStyleBackColor = false;
            btn_validate.Click += btn_validate_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(1297, 884);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button DeleteBtn;
        private Button EditBtn;
        private Label label6;
        private TextBox upassTb;
        private TextBox uphoneTb;
        private Label label5;
        private Label label3;
        private Button button5;
        private Button button4;
        private Button AddBtn;
        private Label label2;
        private DataGridView UsersGV;
        private Label label1;
        private Label label4;
        private TextBox unameTb;
        private Panel panel1;
        private Button btn_validate;
    }
}