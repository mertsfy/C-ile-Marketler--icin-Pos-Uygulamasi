using Igupos.database;
using Igupos.models;
using MySql.Data.MySqlClient;

namespace Igupos.services
{
    public class UserService
    {

        public User? Login(string email, string password)
        {
            User user = null;
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "SELECT id, name, email, password, role FROM users WHERE email='" + email + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        if (rdr["password"].ToString() == password)
                        {
                            user = new User(rdr.GetInt32("id"), rdr.GetString("name"), rdr.GetString("email"), rdr.GetString("role"));
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bilgisi hatalı");
                        }
                    }
                    rdr.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bilgisi hatalı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return user;
        }
    }
}
