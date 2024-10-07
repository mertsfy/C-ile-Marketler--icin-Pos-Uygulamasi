using Igupos.database;
using Igupos.models;
using MySql.Data.MySqlClient;

namespace Igupos.services
{
    public class OrderService
    {
        public bool AddOrder(List<OrderItem> items)
        {
            bool status = false;
            int orderId = 0;

            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "INSERT INTO orders(created_at) VALUES(NOW())";
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                cmd.ExecuteNonQuery();
                orderId = (int)cmd.LastInsertedId;

                foreach (OrderItem item in items)
                {
                    sql = "INSERT INTO order_items(product_id, order_id, quantity, price) VALUES(" + item.ProductId + "," + orderId + "," + item.Quantity + "," + item.Price + ")";
                    cmd = new MySqlCommand(sql, conn.connect);
                    cmd.ExecuteNonQuery();

                    sql = "UPDATE products SET quantity = (quantity - " + item.Quantity + ") WHERE id = " + item.ProductId;
                    cmd = new MySqlCommand(sql, conn.connect);
                    cmd.ExecuteNonQuery();
                }
                status = true;

                MessageBox.Show("Satış tamamlandı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            return status;
        }

        public float GetDailyTotalSales()
        {
            float totalAmount = 0;
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "SELECT SUM(b.price* b.quantity) as total FROM `orders` a JOIN order_items b ON b.order_id = a.id WHERE DATE(created_at) = CURDATE()";
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        totalAmount = rdr["total"] == DBNull.Value ? 0 : rdr.GetFloat("total");
                    }
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return totalAmount;
        }

        public float GetTotalSales()
        {
            float totalAmount = 0;
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "SELECT SUM(b.price* b.quantity) as total FROM `orders` a JOIN order_items b ON b.order_id = a.id";
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        totalAmount = rdr["total"] == DBNull.Value ? 0 : rdr.GetFloat("total");
                    }
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return totalAmount;
        }

        public List<Sale> GetSales()
        {
            List<Sale> sales = new List<Sale>();
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "SELECT SUM(b.price * b.quantity) as total, DATE(created_at) as date, COUNT(DISTINCT a.id) as count FROM orders a JOIN order_items b ON b.order_id = a.id GROUP BY DATE(created_at) ORDER BY date";
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        sales.Add(new Sale(rdr.GetDateTime("date"), rdr.GetInt32("count"), rdr.GetFloat("total")));  
                    }
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return sales;
        }

    }
}
