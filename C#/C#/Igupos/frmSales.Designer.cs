namespace Igupos
{
    partial class frmSales
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            txtTotalAmount = new TextBox();
            lblTotalAmount = new Label();
            txtDailyAmount = new TextBox();
            lblDailyAmount = new Label();
            grdSale = new DataGridView();
            SaleDate = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSale).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(txtTotalAmount);
            splitContainer1.Panel1.Controls.Add(lblTotalAmount);
            splitContainer1.Panel1.Controls.Add(txtDailyAmount);
            splitContainer1.Panel1.Controls.Add(lblDailyAmount);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grdSale);
            splitContainer1.Size = new Size(710, 450);
            splitContainer1.SplitterDistance = 260;
            splitContainer1.TabIndex = 0;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalAmount.Location = new Point(42, 160);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(180, 29);
            txtTotalAmount.TabIndex = 5;
            txtTotalAmount.Text = "0";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalAmount.Location = new Point(42, 127);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(97, 21);
            lblTotalAmount.TabIndex = 6;
            lblTotalAmount.Text = "Toplam Satış";
            // 
            // txtDailyAmount
            // 
            txtDailyAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDailyAmount.Location = new Point(42, 86);
            txtDailyAmount.Name = "txtDailyAmount";
            txtDailyAmount.ReadOnly = true;
            txtDailyAmount.Size = new Size(180, 29);
            txtDailyAmount.TabIndex = 3;
            txtDailyAmount.Text = "0";
            // 
            // lblDailyAmount
            // 
            lblDailyAmount.AutoSize = true;
            lblDailyAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDailyAmount.Location = new Point(42, 53);
            lblDailyAmount.Name = "lblDailyAmount";
            lblDailyAmount.Size = new Size(97, 21);
            lblDailyAmount.TabIndex = 4;
            lblDailyAmount.Text = "Günlük Satış";
            // 
            // grdSale
            // 
            grdSale.AllowUserToAddRows = false;
            grdSale.AllowUserToDeleteRows = false;
            grdSale.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSale.Columns.AddRange(new DataGridViewColumn[] { SaleDate, Quantity, Amount });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            grdSale.DefaultCellStyle = dataGridViewCellStyle4;
            grdSale.GridColor = SystemColors.ControlDark;
            grdSale.Location = new Point(3, 3);
            grdSale.Name = "grdSale";
            grdSale.ReadOnly = true;
            grdSale.RowTemplate.Height = 25;
            grdSale.Size = new Size(439, 435);
            grdSale.TabIndex = 2;
            // 
            // SaleDate
            // 
            SaleDate.HeaderText = "Satış Tarihi";
            SaleDate.Name = "SaleDate";
            SaleDate.ReadOnly = true;
            SaleDate.Width = 150;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Adet";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 80;
            // 
            // Amount
            // 
            Amount.HeaderText = "Satış Toplamı";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 150;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 450);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satışlar";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtTotalAmount;
        private Label lblTotalAmount;
        private TextBox txtDailyAmount;
        private Label lblDailyAmount;
        private DataGridView grdSale;
        private DataGridViewTextBoxColumn SaleDate;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
    }
}