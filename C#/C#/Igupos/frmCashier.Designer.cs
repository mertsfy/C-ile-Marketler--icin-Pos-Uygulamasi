namespace Igupos
{
    partial class frmCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashier));
            splitContainer2 = new SplitContainer();
            lblTitle = new Label();
            splitContainer1 = new SplitContainer();
            button4 = new Button();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(9, -18);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(lblTitle);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer1);
            splitContainer2.Size = new Size(783, 487);
            splitContainer2.SplitterDistance = 66;
            splitContainer2.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(302, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(263, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Şen Market POS";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ControlLight;
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(btnHome);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ButtonHighlight;
            splitContainer1.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel2.BackgroundImage");
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Zoom;
            splitContainer1.Size = new Size(776, 410);
            splitContainer1.SplitterDistance = 116;
            splitContainer1.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.Chocolate;
            button4.Location = new Point(19, 87);
            button4.Name = "button4";
            button4.Size = new Size(75, 72);
            button4.TabIndex = 11;
            button4.Text = "Çıkış";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Salmon;
            btnHome.Location = new Point(19, 9);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 72);
            btnHome.TabIndex = 7;
            btnHome.Text = "Ana Sayfa";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // frmCashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCashier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kasiyer Menü";
            FormClosed += frmCashier_FormClosed;
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer2;
        private Label lblTitle;
        private SplitContainer splitContainer1;
        private Button button4;
        private Button btnHome;
    }
}