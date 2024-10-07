namespace Igupos
{
    partial class frmProduct
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
            splitContainer1 = new SplitContainer();
            btnClear = new Button();
            cmbCategory = new ComboBox();
            btnSave = new Button();
            txtPrice = new TextBox();
            label3 = new Label();
            txtQuantity = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            lbCategoryName = new Label();
            grdProduct = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            CategryId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdProduct).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(btnClear);
            splitContainer1.Panel1.Controls.Add(cmbCategory);
            splitContainer1.Panel1.Controls.Add(btnSave);
            splitContainer1.Panel1.Controls.Add(txtPrice);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtQuantity);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtName);
            splitContainer1.Panel1.Controls.Add(lbCategoryName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grdProduct);
            splitContainer1.Size = new Size(901, 450);
            splitContainer1.SplitterDistance = 233;
            splitContainer1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightSalmon;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(107, 410);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 29);
            btnClear.TabIndex = 11;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(22, 146);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(180, 29);
            cmbCategory.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(107, 375);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(22, 313);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(180, 29);
            txtPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 280);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 10;
            label3.Text = "Fiyat";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(22, 229);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(180, 29);
            txtQuantity.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 196);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 8;
            label2.Text = "Adet";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 113);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 6;
            label1.Text = "Kategori";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(22, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 29);
            txtName.TabIndex = 0;
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCategoryName.Location = new Point(22, 31);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new Size(72, 21);
            lbCategoryName.TabIndex = 4;
            lbCategoryName.Text = "Ürün Adı";
            // 
            // grdProduct
            // 
            grdProduct.AllowUserToAddRows = false;
            grdProduct.AllowUserToDeleteRows = false;
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
            grdProduct.Columns.AddRange(new DataGridViewColumn[] { Id, ProductName, CategoryName, Quantity, Price, CategryId });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdProduct.DefaultCellStyle = dataGridViewCellStyle2;
            grdProduct.GridColor = SystemColors.ControlDark;
            grdProduct.Location = new Point(3, 12);
            grdProduct.Name = "grdProduct";
            grdProduct.ReadOnly = true;
            grdProduct.RowTemplate.Height = 25;
            grdProduct.Size = new Size(649, 426);
            grdProduct.TabIndex = 1;
            grdProduct.CellContentClick += grdProduct_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Ürün Adı";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 150;
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
            Quantity.Width = 80;
            // 
            // Price
            // 
            Price.HeaderText = "Fiyat";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 80;
            // 
            // CategryId
            // 
            CategryId.HeaderText = "CategryId";
            CategryId.Name = "CategryId";
            CategryId.ReadOnly = true;
            CategryId.Visible = false;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 450);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekle";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtQuantity;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private Label lbCategoryName;
        private Button btnSave;
        private DataGridView grdProduct;
        private ComboBox cmbCategory;
        private Button btnClear;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn CategryId;
    }
}