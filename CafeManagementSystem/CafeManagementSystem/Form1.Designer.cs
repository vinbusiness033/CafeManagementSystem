namespace CafeManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            unameTb = new TextBox();
            PasswordTb = new TextBox();
            LoginBtn = new Button();
            GuestBtn = new Button();
            cbshow = new CheckBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(514, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 791);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Firebrick;
            label4.Font = new Font("Segoe Marker", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(765, 9);
            label4.Name = "label4";
            label4.Size = new Size(29, 35);
            label4.TabIndex = 5;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(93, 9);
            label1.Name = "label1";
            label1.Size = new Size(370, 60);
            label1.TabIndex = 0;
            label1.Text = "My Cafe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Marker", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 108);
            label2.Name = "label2";
            label2.Size = new Size(138, 40);
            label2.TabIndex = 1;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Marker", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 229);
            label3.Name = "label3";
            label3.Size = new Size(133, 40);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // unameTb
            // 
            unameTb.Font = new Font("Segoe Marker", 18F, FontStyle.Regular, GraphicsUnit.Point);
            unameTb.ForeColor = Color.FromArgb(255, 128, 128);
            unameTb.Location = new Point(11, 151);
            unameTb.Multiline = true;
            unameTb.Name = "unameTb";
            unameTb.Size = new Size(487, 51);
            unameTb.TabIndex = 3;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Segoe Marker", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTb.ForeColor = Color.FromArgb(255, 128, 128);
            PasswordTb.Location = new Point(11, 272);
            PasswordTb.Multiline = true;
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(345, 49);
            PasswordTb.TabIndex = 4;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.RosyBrown;
            LoginBtn.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.Location = new Point(11, 347);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(118, 61);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button1_Click;
            // 
            // GuestBtn
            // 
            GuestBtn.BackColor = Color.RosyBrown;
            GuestBtn.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            GuestBtn.Location = new Point(171, 347);
            GuestBtn.Name = "GuestBtn";
            GuestBtn.Size = new Size(118, 61);
            GuestBtn.TabIndex = 7;
            GuestBtn.Text = "Guest";
            GuestBtn.UseVisualStyleBackColor = false;
            GuestBtn.Click += button2_Click;
            // 
            // cbshow
            // 
            cbshow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbshow.Location = new Point(376, 263);
            cbshow.Name = "cbshow";
            cbshow.Size = new Size(132, 65);
            cbshow.TabIndex = 8;
            cbshow.Text = "Show";
            cbshow.UseVisualStyleBackColor = true;
            cbshow.CheckedChanged += cbshow_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1290, 790);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(1843, 802);
            Controls.Add(cbshow);
            Controls.Add(GuestBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTb);
            Controls.Add(unameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox unameTb;
        private TextBox PasswordTb;
        private Label label4;
        private Button LoginBtn;
        private Button GuestBtn;
        private CheckBox cbshow;
        private PictureBox pictureBox1;
    }
}