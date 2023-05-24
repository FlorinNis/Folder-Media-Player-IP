using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Media_Player
{
  
    public class DatabaseConnector
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        private SqlConnection _con;

        public DatabaseConnector()
        {
            _con = new SqlConnection(_connectionString);
        } 

        public void ExecuteQuery(string sqlQuery)
        {
            try
            {
                _con.Open();
                SqlCommand sc = new SqlCommand(sqlQuery, _con);
                sc.ExecuteNonQuery();
                _con.Close();
            } catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Could not execute query.", "Query Error");
            } catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Could not connect to media database.", "Database Error");
            }
        }

        public List<string> RetrieveQueryData(string sqlQuery)
        {
            List<string> tableData = new List<string>();
            try
            {
                _con.Open();
                SqlCommand sc = new SqlCommand(sqlQuery, _con);
                using (SqlDataReader reader = sc.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       string data = String.Format("{0} - {1}", reader["SongName"], reader["SongAuthor"]);
                       tableData.Add(data);
                       
                    }
                }
                _con.Close();
            } catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Could not execute query.", "Query Error");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Could not connect to media database.", "Database Error");
            }
            return tableData;
        }

        public List<string> ListPlaylists()
        {
            List<string> tables = new List<string>();
            try
            {
                _con.Open();
                DataTable dt = _con.GetSchema("Tables");
                foreach (DataRow row in dt.Rows)
                {
                    string tablename = (string)row[2];
                    tables.Add(tablename);
                }
                _con.Close();
            } catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            };
            return tables;
        }
    }
}
