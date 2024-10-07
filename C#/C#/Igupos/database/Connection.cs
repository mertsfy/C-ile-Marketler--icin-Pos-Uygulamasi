using MySql.Data.MySqlClient;

namespace Igupos.database
{
    public class Connection
    {
        public MySqlConnection connect;

        private string connStr = "server=localhost;user=igu;database=pos;port=3306;password=igu";

        public void Open()
        {
            connect = new MySqlConnection(connStr);
            try
            {
                connect.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Close()
        {
            connect.Close();
            connect.Dispose();
        }
    }
}
