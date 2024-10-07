namespace Igupos
{
    partial class frmCategory
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
            btnSave = new Button();
            txtName = new TextBox();
            lbCategoryName = new Label();
            grdCategory = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdCategory).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ControlLight;
            splitContainer1.Panel1.Controls.Add(btnClear);
            splitContainer1.Panel1.Controls.Add(btnSave);
            splitContainer1.Panel1.Controls.Add(txtName);
            splitContainer1.Panel1.Controls.Add(lbCategoryName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grdCategory);
            splitContainer1.Size = new Size(719, 450);
            splitContainer1.SplitterDistance = 243;
            splitContainer1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightSalmon;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(114, 167);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(114, 132);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(29, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 29);
            txtName.TabIndex = 1;
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCategoryName.Location = new Point(29, 33);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new Size(95, 21);
            lbCategoryName.TabIndex = 2;
            lbCategoryName.Text = "Kategori Adı";
            // 
            // grdCategory
            // 
            grdCategory.AllowUserToAddRows = false;
            grdCategory.AllowUserToDeleteRows = false;
            grdCategory.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCategory.Columns.AddRange(new DataGridViewColumn[] { Id, name });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdCategory.DefaultCellStyle = dataGridViewCellStyle2;
            grdCategory.GridColor = SystemColors.ControlDark;
            grdCategory.Location = new Point(10, 12);
            grdCategory.Name = "grdCategory";
            grdCategory.ReadOnly = true;
            grdCategory.RowTemplate.Height = 25;
            grdCategory.Size = new Size(453, 426);
            grdCategory.TabIndex = 0;
            grdCategory.CellContentClick += grdCategory_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // name
            // 
            name.HeaderText = "Kategori Adı";
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 200;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 450);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategori Ekle";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtName;
        private Label lbCategoryName;
        private Button btnSave;
        private DataGridView grdCategory;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn name;
        private Button btnClear;
    }
}