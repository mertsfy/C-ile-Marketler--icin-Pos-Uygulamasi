using Igupos.models;
using Igupos.services;
using System.Xml.Linq;

namespace Igupos
{
    public partial class frmProduct : Form
    {
        private int ProductId { get; set; }
        public frmProduct()
        {
            this.ProductId = 0;
            InitializeComponent();
            initProductGrid();
            fillCategoryCombo();
            fillProductGrid();
        }

        private void initProductGrid()
        {
            DataGridViewButtonColumn button1 = new DataGridViewButtonColumn();
            button1.HeaderText = "";
            button1.Text = "Güncelle";
            button1.Width = 80;
            button1.UseColumnTextForButtonValue = true;
            button1.FlatStyle = FlatStyle.Popup;
            button1.CellTemplate.Style.BackColor = Color.AliceBlue;
            grdProduct.Columns.Add(button1);

            DataGridViewButtonColumn button2 = new DataGridViewButtonColumn();
            button2.HeaderText = "";
            button2.Text = "Sil";
            button2.Width = 80;
            button2.UseColumnTextForButtonValue = true;
            button2.FlatStyle = FlatStyle.Popup;
            button2.CellTemplate.Style.BackColor = Color.AliceBlue;
            grdProduct.Columns.Add(button2);

            DataGridViewButtonColumn button3 = new DataGridViewButtonColumn();
            button3.HeaderText = "";
            button3.Text = "Stok Ekle";
            button3.Width = 80;
            button3.UseColumnTextForButtonValue = true;
            button3.FlatStyle = FlatStyle.Popup;
            button3.CellTemplate.Style.BackColor = Color.AliceBlue;
            grdProduct.Columns.Add(button3);
        }

        private void fillCategoryCombo()
        {
            cmbCategory.Items.Clear();
            cmbCategory.DisplayMember = "Text";
            cmbCategory.ValueMember = "Value";

            CategoryService service = new CategoryService();
            List<Category> categories = service.GetCategories();

            foreach (Category item in categories)
            {
                cmbCategory.Items.Add(new { Value = item.Id, Text = item.Name });
            }
        }

        private void fillProductGrid()
        {
            grdProduct.Rows.Clear();

            CategoryService service1 = new CategoryService();
            List<Category> categories = service1.GetCategories();

            ProductService service2 = new ProductService();
            List<Product> products = service2.GetProducts();

            foreach (Product item in products)
            {
                var category = (from x in categories
                                where x.Id == item.CategoryId
                                select x).First();

                int n = grdProduct.Rows.Add();
                grdProduct.Rows[n].Cells[0].Value = item.Id;
                grdProduct.Rows[n].Cells[1].Value = item.Name;
                grdProduct.Rows[n].Cells[2].Value = category.Name;
                grdProduct.Rows[n].Cells[3].Value = item.Quantity;
                grdProduct.Rows[n].Cells[4].Value = item.Price;
                grdProduct.Rows[n].Cells[5].Value = item.CategoryId;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtQuantity.Text == "" || txtPrice.Text == "" || cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Ürün bilgilerini girin");
            }
            else
            {
                ProductService service = new ProductService();

                if (service.GetProductByName(txtName.Text, this.ProductId) == null)
                {
                    if (this.ProductId == 0)
                    {
                        if (service.AddProduct(new Product(0, txtName.Text, Convert.ToInt32(txtQuantity.Text), (float)Convert.ToDouble(txtPrice.Text), (cmbCategory.SelectedItem as dynamic).Value)))
                        {
                            fillProductGrid();
                            btnClear_Click(sender, e);
                        }
                    }
                    else
                    {
                        if (service.UpdateProduct(new Product(this.ProductId, txtName.Text, Convert.ToInt32(txtQuantity.Text), (float)Convert.ToDouble(txtPrice.Text), (cmbCategory.SelectedItem as dynamic).Value)))
                        {
                            fillProductGrid();
                            btnClear_Click(sender, e);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bu ürün kayıtlıdır");
                }
            }
        }

        private void grdProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                txtName.Text = (string)grdProduct.Rows[e.RowIndex].Cells[1].Value;
                txtQuantity.Text = grdProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrice.Text = grdProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbCategory.Text = (string)grdProduct.Rows[e.RowIndex].Cells[2].Value;
                this.ProductId = (int)grdProduct.Rows[e.RowIndex].Cells[0].Value;
                this.Text = "Ürün Güncelle";
                btnSave.Text = "Güncelle";
                txtQuantity.ReadOnly = true;
            }
            else if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                DialogResult res = MessageBox.Show("Ürünü silmek istiyormusunuz?", "Onay", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    ProductService service = new ProductService();
                    if (service.DeleteProduct((int)grdProduct.Rows[e.RowIndex].Cells[0].Value))
                    {
                        fillProductGrid();
                        btnClear_Click(sender, e);
                    }
                }
            }
            else if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                frmAddStock frm = new frmAddStock();
                frm.Text = (string)grdProduct.Rows[e.RowIndex].Cells[1].Value;
                frm.ShowDialog();

                if (frm.Quantity > 0)
                {
                    ProductService service = new ProductService();
                    if (service.AddStockProduct((int)grdProduct.Rows[e.RowIndex].Cells[0].Value, frm.Quantity))
                    {
                        fillProductGrid();
                        btnClear_Click(sender, e);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Text = "Ürün Ekle";
            btnSave.Text = "Kaydet";
            txtName.Clear();
            txtQuantity.Clear();
            txtQuantity.ReadOnly = false;
            txtPrice.Clear();
            cmbCategory.SelectedIndex = -1;
            this.ProductId = 0;
        }
    }
}
