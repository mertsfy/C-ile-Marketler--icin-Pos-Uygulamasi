using Igupos.models;
using Igupos.services;

namespace Igupos
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
            OrderService service = new OrderService();
            txtDailyAmount.Text = service.GetDailyTotalSales().ToString();
            txtTotalAmount.Text = service.GetTotalSales().ToString();
            fillSaleGrid();
        }

        private void fillSaleGrid()
        {
            grdSale.Rows.Clear();

            OrderService service = new OrderService();
            List<Sale> sales = service.GetSales();

            foreach (Sale item in sales)
            {
                int n = grdSale.Rows.Add();
                grdSale.Rows[n].Cells[0].Value = item.Date.ToString("dd/MM/yyyy");
                grdSale.Rows[n].Cells[1].Value = item.Count;
                grdSale.Rows[n].Cells[2].Value = item.Amount;
            }
        }

    }
}
