namespace CafeManagementSystem
{
    partial class ViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            panel1 = new Panel();
            AddToCartBtn = new Button();
            OrdersGV = new DataGridView();
            label1 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(AddToCartBtn);
            panel1.Controls.Add(OrdersGV);
            panel1.Location = new Point(12, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(1397, 623);
            panel1.TabIndex = 0;
            // 
            // AddToCartBtn
            // 
            AddToCartBtn.AccessibleRole = AccessibleRole.Grip;
            AddToCartBtn.BackColor = Color.RosyBrown;
            AddToCartBtn.Font = new Font("Segoe Marker", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddToCartBtn.Location = new Point(570, 529);
            AddToCartBtn.Name = "AddToCartBtn";
            AddToCartBtn.Size = new Size(222, 61);
            AddToCartBtn.TabIndex = 9;
            AddToCartBtn.Text = "Close";
            AddToCartBtn.UseVisualStyleBackColor = false;
            AddToCartBtn.Click += AddToCartBtn_Click;
            // 
            // OrdersGV
            // 
            OrdersGV.BackgroundColor = SystemColors.Control;
            OrdersGV.BorderStyle = BorderStyle.None;
            OrdersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGV.Location = new Point(3, 3);
            OrdersGV.Name = "OrdersGV";
            OrdersGV.RowHeadersWidth = 51;
            OrdersGV.RowTemplate.Height = 29;
            OrdersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrdersGV.Size = new Size(1391, 520);
            OrdersGV.TabIndex = 5;
            OrdersGV.CellContentClick += OrdersGV_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(495, 132);
            label1.Name = "label1";
            label1.Size = new Size(409, 58);
            label1.TabIndex = 4;
            label1.Text = "LIST OF ORDERS";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(1421, 837);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrders";
            Load += ViewOrders_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView OrdersGV;
        private Label label1;
        private Button AddToCartBtn;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}