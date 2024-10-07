namespace Igupos
{
    partial class frmLogin
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
            pnl1 = new Panel();
            ıbıTitle = new Label();
            pnl2 = new Panel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            pnl1.SuspendLayout();
            pnl2.SuspendLayout();
            SuspendLayout();
            // 
            // pnl1
            // 
            pnl1.BackColor = SystemColors.ControlLight;
            pnl1.BorderStyle = BorderStyle.FixedSingle;
            pnl1.Controls.Add(ıbıTitle);
            pnl1.Location = new Point(48, 61);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(215, 67);
            pnl1.TabIndex = 0;
            // 
            // ıbıTitle
            // 
            ıbıTitle.AutoSize = true;
            ıbıTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ıbıTitle.Location = new Point(52, 18);
            ıbıTitle.Name = "ıbıTitle";
            ıbıTitle.Size = new Size(107, 25);
            ıbıTitle.TabIndex = 0;
            ıbıTitle.Text = "Şen Market";
            // 
            // pnl2
            // 
            pnl2.BorderStyle = BorderStyle.FixedSingle;
            pnl2.Controls.Add(btnLogin);
            pnl2.Controls.Add(txtPassword);
            pnl2.Controls.Add(lblPassword);
            pnl2.Controls.Add(txtEmail);
            pnl2.Controls.Add(lblEmail);
            pnl2.Location = new Point(48, 134);
            pnl2.Name = "pnl2";
            pnl2.Size = new Size(215, 233);
            pnl2.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(99, 188);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(14, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(180, 29);
            txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(14, 97);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(42, 21);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Şifre";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(14, 56);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 29);
            txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(14, 23);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 450);
            Controls.Add(pnl2);
            Controls.Add(pnl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            pnl1.ResumeLayout(false);
            pnl1.PerformLayout();
            pnl2.ResumeLayout(false);
            pnl2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl1;
        private Label ıbıTitle;
        private Panel pnl2;
        private Label lblEmail;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtEmail;
    }
}