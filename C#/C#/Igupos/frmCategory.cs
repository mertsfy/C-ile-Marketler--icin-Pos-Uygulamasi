using Igupos.models;
using Igupos.services;

namespace Igupos
{
    public partial class frmCategory : Form
    {
        private int CategoryId { get; set; }

        public frmCategory()
        {
            this.CategoryId = 0;
            InitializeComponent();
            initCategoryGrid();
            fillCategoryGrid();
        }

        private void initCategoryGrid()
        {
            DataGridViewButtonColumn button1 = new DataGridViewButtonColumn();
            button1.HeaderText = "";
            button1.Text = "Güncelle";
            button1.Width = 100;
            button1.UseColumnTextForButtonValue = true;
            button1.FlatStyle = FlatStyle.Popup;
            button1.CellTemplate.Style.BackColor = Color.AliceBlue;
            grdCategory.Columns.Add(button1);

            DataGridViewButtonColumn button2 = new DataGridViewButtonColumn();
            button2.HeaderText = "";
            button2.Text = "Sil";
            button2.Width = 100;
            button2.UseColumnTextForButtonValue = true;
            button2.FlatStyle = FlatStyle.Popup;
            button2.CellTemplate.Style.BackColor = Color.AliceBlue;
            grdCategory.Columns.Add(button2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Kategori adı girin");
                txtName.Focus();
            }
            else
            {
                CategoryService service = new CategoryService();

                if (service.GetCategoryByName(txtName.Text, this.CategoryId) == null)
                {
                    if (this.CategoryId == 0)
                    {
                        if (service.AddCategory(txtName.Text))
                        {
                            fillCategoryGrid();
                            btnClear_Click(sender, e);
                        }
                    }
                    else
                    {
                        if (service.UpdateCategory(txtName.Text, this.CategoryId))
                        {
                            fillCategoryGrid();
                            btnClear_Click(sender, e);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bu kategori kayıtlıdır");
                }
            }
        }

        private void fillCategoryGrid()
        {
            grdCategory.Rows.Clear();

            CategoryService service = new CategoryService();
            List<Category> categories = service.GetCategories();

            foreach (Category item in categories)
            {
                int n = grdCategory.Rows.Add();
                grdCategory.Rows[n].Cells[0].Value = item.Id;
                grdCategory.Rows[n].Cells[1].Value = item.Name;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Text = "Kategori Ekle";
            btnSave.Text = "Kaydet";
            txtName.Clear();
            this.CategoryId = 0;
        }

        private void grdCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                txtName.Text = (string)grdCategory.Rows[e.RowIndex].Cells[1].Value;
                this.CategoryId = (int)grdCategory.Rows[e.RowIndex].Cells[0].Value;
                this.Text = "Kategori Güncelle";
                btnSave.Text = "Güncelle";
            }
            else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                DialogResult res = MessageBox.Show("Kategoriyi silmek istiyormusunuz?", "Onay", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    CategoryService service = new CategoryService();
                    if (service.DeleteCategory((int)grdCategory.Rows[e.RowIndex].Cells[0].Value))
                    {
                        fillCategoryGrid();
                        btnClear_Click(sender, e);
                    }
                }
            }
        }
    }
}
