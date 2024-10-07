namespace Igupos
{
    partial class frmAddStock
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
            panel1 = new Panel();
            btnSave = new Button();
            txtQuantity = new TextBox();
            lbStock = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(lbStock);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 183);
            panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(103, 112);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(18, 46);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(180, 29);
            txtQuantity.TabIndex = 5;
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbStock.Location = new Point(18, 13);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(76, 21);
            lbStock.TabIndex = 6;
            lbStock.Text = "Stok Adet";
            // 
            // frmAddStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 204);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Ekleme";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private TextBox txtQuantity;
        private Label lbStock;
    }
}