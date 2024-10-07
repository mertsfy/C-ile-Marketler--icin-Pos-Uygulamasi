namespace Igupos
{
    public partial class frmAddStock : Form
    {
        public int Quantity { get; set; }

        public frmAddStock()
        {
            this.Quantity = 0;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Adet Girin");
            }
            else
            {
                this.Quantity = Convert.ToInt32(txtQuantity.Text);
                this.Close();
            }
        }
    }
}
