using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace Tavern.Data {
    public class Database {
        private readonly string connectionString;
        public Database() {
            connectionString = Environment.GetEnvironmentVariable("ConnectionStr");
        }

        public DataTable MySQLConnection_Datatable(string query) {

            DataTable dtDaten = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand selectCommand = new MySqlCommand(query, conn);
                using (MySqlDataReader rdr = selectCommand.ExecuteReader())
                {
                    dtDaten.Load(rdr);
                }
                conn.Close();
            }
            return dtDaten;

        }

        public int Add_Entry(string query){
            int records = 0;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();    
                using (MySqlCommand selectCommand = new MySqlCommand(query, conn)) {
                    records = selectCommand.ExecuteNonQuery();
                }
                // to insert, update, and delete data.
                 
                conn.Close();
            }
            return records;
        }
        public void Update_Entry(string query){
            
        }

        public int Delete_Entry(string query){

            int records = 0;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand selectCommand = new MySqlCommand(query);
                // to insert, update, and delete data.
                records = selectCommand.ExecuteNonQuery();
                conn.Close();
            }

            return records;
            
        }
    }
}