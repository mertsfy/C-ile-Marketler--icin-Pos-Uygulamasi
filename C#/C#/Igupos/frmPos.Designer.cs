namespace Igupos
{
    partial class frmPos
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            grdProduct = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            splitContainer2 = new SplitContainer();
            grdCart = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            btnOrder = new Button();
            txtChange = new TextBox();
            lblChange = new Label();
            txtPaid = new TextBox();
            lblAmount = new Label();
            txtTotalAmount = new TextBox();
            lbTotalAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdCart).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(grdProduct);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(937, 440);
            splitContainer1.SplitterDistance = 591;
            splitContainer1.TabIndex = 0;
            // 
            // grdProduct
            // 
            grdProduct.AllowUserToAddRows = false;
            grdProduct.AllowUserToDeleteRows = false;
            grdProduct.AllowUserToResizeColumns = false;
            grdProduct.AllowUserToResizeRows = false;
            grdProduct.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProduct.Columns.AddRange(new DataGridViewColumn[] { Id, ProductName, CategoryName, Quantity, Price });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdProduct.DefaultCellStyle = dataGridViewCellStyle2;
            grdProduct.GridColor = SystemColors.ControlDark;
            grdProduct.Location = new Point(3, 3);
            grdProduct.Name = "grdProduct";
            grdProduct.ReadOnly = true;
            grdProduct.RowTemplate.Height = 25;
            grdProduct.Size = new Size(585, 426);
            grdProduct.TabIndex = 2;
            grdProduct.CellContentClick += grdProduct_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 5;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Ürün Adı";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 180;
            // 
            // CategoryName
            // 
            CategoryName.HeaderText = "Kategori";
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            CategoryName.Width = 120;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Adet";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 70;
            // 
            // Price
            // 
            Price.HeaderText = "Fiyat";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 70;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(grdCart);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnOrder);
            splitContainer2.Panel2.Controls.Add(txtChange);
            splitContainer2.Panel2.Controls.Add(lblChange);
            splitContainer2.Panel2.Controls.Add(txtPaid);
            splitContainer2.Panel2.Controls.Add(lblAmount);
            splitContainer2.Panel2.Controls.Add(txtTotalAmount);
            splitContainer2.Panel2.Controls.Add(lbTotalAmount);
            splitContainer2.Size = new Size(342, 440);
            splitContainer2.SplitterDistance = 275;
            splitContainer2.TabIndex = 0;
            // 
            // grdCart
            // 
            grdCart.AllowUserToAddRows = false;
            grdCart.AllowUserToDeleteRows = false;
            grdCart.AllowUserToResizeColumns = false;
            grdCart.AllowUserToResizeRows = false;
            grdCart.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCart.ColumnHeadersVisible = false;
            grdCart.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            grdCart.DefaultCellStyle = dataGridViewCellStyle4;
            grdCart.GridColor = SystemColors.ControlDark;
            grdCart.Location = new Point(3, 3);
            grdCart.Name = "grdCart";
            grdCart.ReadOnly = true;
            grdCart.RowTemplate.Height = 25;
            grdCart.Size = new Size(336, 292);
            grdCart.TabIndex = 3;
            grdCart.CellContentClick += grdCart_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Ürün Adı";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 120;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.Location = new Point(114, 120);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(95, 29);
            btnOrder.TabIndex = 8;
            btnOrder.Text = "Ödeme";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // txtChange
            // 
            txtChange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtChange.Location = new Point(252, 87);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(78, 29);
            txtChange.TabIndex = 7;
            txtChange.Text = "0";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChange.Location = new Point(7, 87);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(76, 21);
            lblChange.TabIndex = 6;
            lblChange.Text = "Para Üstü";
            // 
            // txtPaid
            // 
            txtPaid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaid.Location = new Point(252, 50);
            txtPaid.Name = "txtPaid";
            txtPaid.Size = new Size(78, 29);
            txtPaid.TabIndex = 5;
            txtPaid.Text = "0";
            txtPaid.TextChanged += txtPaid_TextChanged;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.Location = new Point(7, 50);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(65, 21);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Ödenen";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalAmount.Location = new Point(252, 12);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(78, 29);
            txtTotalAmount.TabIndex = 3;
            txtTotalAmount.Text = "0";
            // 
            // lbTotalAmount
            // 
            lbTotalAmount.AutoSize = true;
            lbTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotalAmount.Location = new Point(7, 12);
            lbTotalAmount.Name = "lbTotalAmount";
            lbTotalAmount.Size = new Size(100, 21);
            lbTotalAmount.TabIndex = 1;
            lbTotalAmount.Text = "Toplam Tutar";
            // 
            // frmPos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 440);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POS Satış";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdProduct).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdCart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView grdProduct;
        private SplitContainer splitContainer2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridView grdCart;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label lbTotalAmount;
        private TextBox txtTotalAmount;
        private Label lblAmount;
        private TextBox txtChange;
        private Label lblChange;
        private TextBox txtPaid;
        private Button btnOrder;
    }
}