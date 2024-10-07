using Igupos.database;
using Igupos.models;
using MySql.Data.MySqlClient;

namespace Igupos.services
{
    public class ProductService
    {

        public Product? GetProductByName(string name, int productId)
        {
            Product? product = null;
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "SELECT * FROM products WHERE name='" + name + "' AND id!=" + productId;
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        product = new Product(rdr.GetInt32("id"), rdr.GetString("name"), rdr.GetInt32("quantity"), rdr.GetFloat("price"), rdr.GetInt32("category_id"));
                    }
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return product;
        }

        public bool AddProduct(Product product)
        {
            bool status = false;
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "INSERT INTO products(name, quantity, price, category_id) VALUES('" + product.Name + "'," + product.Quantity + "," + product.Price + "," + product.CategoryId + ")";
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                cmd.ExecuteNonQuery();
                status = true;

                MessageBox.Show("Ürün eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return status;
        }

        public bool UpdateProduct(Product product)
        {
            bool status = false;
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "UPDATE products SET name='" + product.Name + "', price="+ product.Price +", category_id=" + product.CategoryId + " WHERE id=" + product.Id;
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                cmd.ExecuteNonQuery();
                status = true;

                MessageBox.Show("Ürün güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return status;
        }

        public bool AddStockProduct(int productId, int quantity)
        {
            bool status = false;
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "UPDATE products SET quantity = (quantity + " + quantity + ") WHERE id = " + productId;
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                cmd.ExecuteNonQuery();
                status = true;

                MessageBox.Show("Stok güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return status;
        }

        public bool DeleteProduct(int productId)
        {
            bool status = false;
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "DELETE FROM products WHERE id=" + productId;
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                cmd.ExecuteNonQuery();
                status = true;

                MessageBox.Show("Ürün silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return status;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        products.Add(new Product(rdr.GetInt32("id"), rdr.GetString("name"), rdr.GetInt32("quantity"), rdr.GetFloat("price"), rdr.GetInt32("category_id")));
                    }
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return products;
        }
    }
}
