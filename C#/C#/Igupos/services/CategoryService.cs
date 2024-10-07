using Igupos.database;
using Igupos.models;
using MySql.Data.MySqlClient;

namespace Igupos.services
{
    public class CategoryService
    {

        public Category? GetCategoryByName(string name, int categoryId)
        {
            Category? category = null;
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "SELECT * FROM categories WHERE name='" + name + "' AND id!=" + categoryId;
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        category = new Category(rdr.GetInt32("id"), rdr.GetString("name"));
                    }
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return category;
        }


        public bool AddCategory(string name)
        {
            bool status = false;
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "INSERT INTO categories(name) VALUES('" + name + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                cmd.ExecuteNonQuery();
                status = true;

                MessageBox.Show("Kategori eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return status;
        }


        public bool UpdateCategory(string name, int categoryId)
        {
            bool status = false;
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "UPDATE categories SET name='" + name + "' WHERE id=" + categoryId;
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                cmd.ExecuteNonQuery();
                status = true;

                MessageBox.Show("Kategori güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return status;
        }

        public bool DeleteCategory(int categoryId)
        {
            bool status = false;
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "DELETE FROM categories WHERE id=" + categoryId;
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                cmd.ExecuteNonQuery();
                status = true;

                MessageBox.Show("Kategori silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return status;
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "SELECT * FROM categories";
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        categories.Add(new Category(rdr.GetInt32("id"), rdr.GetString("name")));
                    }
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return categories;
        }
    }
}
