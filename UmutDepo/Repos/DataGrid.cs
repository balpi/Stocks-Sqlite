
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UmutDepo.Interfaces;

namespace UmutDepo.Repos
{
    public class DataGrid
    {
        

        public async Task<DataTable> GetData(string tableName)
        {

            string conString = "Data source = " + Path.Combine(Application.StartupPath, "Umut.db;Version=3;");
            using (var connection =  new SQLiteConnection("Data source = " + Path.Combine(Application.StartupPath, "base/Umut.db;Version=3;")))
            {

                connection.Open();

                
                
                SQLiteDataAdapter read = new SQLiteDataAdapter("SELECT * FROM " + tableName,connection);
                DataSet ds = new DataSet();
                read.Fill(ds);
                DataTable datagridSource = ds.Tables[0];
                connection.Close();
                return datagridSource;

            }
        }

        public async Task<DataTable> GetData(string tableName, int id)
        {
            using (var connection = new SQLiteConnection("Data Source=Data/Umut.db"))
            {
                connection.Open();
                SQLiteDataAdapter read = new SQLiteDataAdapter("SELECT * FROM " + tableName, connection);
                DataSet ds = new DataSet();
                read.Fill(ds);
                DataTable datagridSource = ds.Tables[0];
                connection.Close();
                return datagridSource;
            }
        }

        public void GridRowSelected(int index)
        {

        }
    }
}
