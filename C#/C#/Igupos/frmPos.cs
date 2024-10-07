using Igupos.models;
using Igupos.services;
using System.Data;

namespace Igupos
{
    public partial class frmPos : Form
    {
        private List<Product> products;
        public frmPos()
        {
            InitializeComponent();
            initProductGrid();
            initCartGrid();
            fillProductGrid();
        }

        private void initProductGrid()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "İşlem";
            button.Text = "Ekle";
            button.Width = 100;
            button.UseColumnTextForButtonValue = true;
            button.FlatStyle = FlatStyle.Popup;
            button.CellTemplate.Style.BackColor = Color.AliceBlue;
            grdProduct.Columns.Add(button);
        }

        private void fillProductGrid()
        {
            grdProduct.Rows.Clear();

            CategoryService service1 = new CategoryService();
            List<Category> categories = service1.GetCategories();

            ProductService service2 = new ProductService();
            products = service2.GetProducts();

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
            }
        }

        private void grdProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowNo = -1;

            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                for (int i = 0; i < grdCart.Rows.Count; i++)
                {
                    if (grdCart.Rows[i].Cells[0].Value == grdProduct.Rows[e.RowIndex].Cells[0].Value)
                    {
                        rowNo = i;
                        break;
                    }
                }
                if (checkStock((int)grdProduct.Rows[e.RowIndex].Cells[0].Value, rowNo == -1 ? 1 : (int)grdCart.Rows[rowNo].Cells[3].Value + 1))
                {
                    if (rowNo == -1)
                    {
                        int n = grdCart.Rows.Add();
                        grdCart.Rows[n].Cells[0].Value = grdProduct.Rows[e.RowIndex].Cells[0].Value;
                        grdCart.Rows[n].Cells[1].Value = (string)grdProduct.Rows[e.RowIndex].Cells[1].Value;
                        grdCart.Rows[n].Cells[3].Value = 1;
                        grdCart.Rows[n].Cells[5].Value = grdProduct.Rows[e.RowIndex].Cells[4].Value;
                        calculateTotalAmount();
                    }
                    else
                    {
                        updateCartGrid(rowNo, 1);
                    }
                }
            }
        }

        private void initCartGrid()
        {
            DataGridViewButtonColumn button1 = new DataGridViewButtonColumn();
            button1.Text = "-";
            button1.Width = 30;
            button1.UseColumnTextForButtonValue = true;
            button1.FlatStyle = FlatStyle.Popup;
            button1.CellTemplate.Style.BackColor = Color.Aquamarine;
            grdCart.Columns.Add(button1);

            DataGridViewTextBoxColumn text1 = new DataGridViewTextBoxColumn();
            text1.Width = 30;
            grdCart.Columns.Add(text1);

            DataGridViewButtonColumn button2 = new DataGridViewButtonColumn();
            button2.Text = "+";
            button2.Width = 30;
            button2.UseColumnTextForButtonValue = true;
            button2.FlatStyle = FlatStyle.Popup;
            button2.CellTemplate.Style.BackColor = Color.Aquamarine;
            grdCart.Columns.Add(button2);

            DataGridViewTextBoxColumn text2 = new DataGridViewTextBoxColumn();
            text2.Width = 60;
            grdCart.Columns.Add(text2);
        }

        private void grdCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 2 || e.ColumnIndex == 4) && e.RowIndex >= 0)
            {
                if (checkStock((int)grdCart.Rows[e.RowIndex].Cells[0].Value, e.ColumnIndex == 2 ? 0 : (int)grdCart.Rows[e.RowIndex].Cells[3].Value + 1))
                {
                    updateCartGrid(e.RowIndex, e.ColumnIndex == 2 ? -1 : 1);
                }
            }
        }

        private bool checkStock(int productId, int quantity)
        {
            bool status = true;
            var product = (from x in products
                           where x.Id == productId
                           select x).First();


            if (product.Quantity < quantity)
            {
                status = false;
                MessageBox.Show("Stok yeterli değil");
            }

            return status;
        }

        private void updateCartGrid(int rowNo, int quantity)
        {
            if ((int)grdCart.Rows[rowNo].Cells[3].Value + quantity == 0)
            {
                grdCart.Rows.RemoveAt(rowNo);
            }
            else
            {
                var product = (from x in products
                               where x.Id == (int)grdCart.Rows[rowNo].Cells[0].Value
                               select x).First();

                grdCart.Rows[rowNo].Cells[3].Value = (int)grdCart.Rows[rowNo].Cells[3].Value + quantity;
                grdCart.Rows[rowNo].Cells[5].Value = (int)grdCart.Rows[rowNo].Cells[3].Value * product.Price;
            }
            calculateTotalAmount();
        }

        private void calculateTotalAmount()
        {
            float totalAmount = 0;
            for (int i = 0; i < grdCart.Rows.Count; i++)
            {
                totalAmount += (float)grdCart.Rows[i].Cells[5].Value;
            }
            txtTotalAmount.Text = totalAmount.ToString();
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            txtChange.Text = ((float)Convert.ToDouble(txtPaid.Text) - (float)Convert.ToDouble(txtTotalAmount.Text)).ToString();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (grdCart.Rows.Count == 0)
            {
                MessageBox.Show("Ürün Seçin");
            }
            else
            {
                if ((float)Convert.ToDouble(txtPaid.Text) < (float)Convert.ToDouble(txtTotalAmount.Text))
                {
                    MessageBox.Show("Ödeme yapılmadı");
                }
                else
                {
                    OrderService service = new OrderService();
                    List<OrderItem> items = new List<OrderItem>();

                    for (int i = 0; i < grdCart.Rows.Count; i++)
                    {
                        var product = (from x in products
                                       where x.Id == (int)grdCart.Rows[i].Cells[0].Value
                                       select x).First();

                        items.Add(new OrderItem(0, (int)grdCart.Rows[i].Cells[0].Value, (int)grdCart.Rows[i].Cells[3].Value, product.Price));
                    }

                    if (service.AddOrder(items))
                    {
                        fillProductGrid();
                        grdCart.Rows.Clear();
                        txtChange.Text = "0";
                        txtTotalAmount.Text = "0";
                        txtPaid.Text = "0";
                    }
                }
            }
        }
    }
}
