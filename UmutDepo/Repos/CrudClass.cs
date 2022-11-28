using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmutDepo.Repos
{
   public class CrudClass
    {
        public int StoktaVarmiCıkıs(string UrunAdi, string OlcuBirimi, double adet, string tarih)
        {
            using (var connection = new SQLiteConnection("Data source = " + Path.Combine(Application.StartupPath, "base/Umut.db;Version=3;Read Only=False;")))
            {
                SQLiteCommand cmd = new SQLiteCommand();

                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "SELECT count(*) FROM Stocks WHERE UrunAdi='" + UrunAdi + "'";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    connection.Close();
                    return 0;

                }
                else
                {
                    cmd.CommandText = "Select Id from Stocks where UrunAdi='" + UrunAdi + "'";
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    string idstring = "";
                    while (reader.Read())
                    {
                        idstring = reader["Id"].ToString();
                    }
                    
                    return Convert.ToInt32(idstring);
                }
              

                
                

            }
        }
        public int StoktaVarmi(string UrunAdi, string OlcuBirimi, double adet, string tarih)
        {
            using (var connection = new SQLiteConnection("Data source = " + Path.Combine(Application.StartupPath, "base/Umut.db;Version=3;Read Only=False;")))
            {
                SQLiteCommand cmd = new SQLiteCommand();

                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "SELECT count(*) FROM Stocks WHERE UrunAdi='"+UrunAdi+"'";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    cmd.CommandText = "INSERT INTO Stocks (UrunAdi, OlcuBirimi, StokMiktari, GuncellemeTarihi)" +
                        "VALUES('" + UrunAdi + "', '" + OlcuBirimi + "', " + adet + ", '" + tarih + "');";
                    cmd.ExecuteNonQuery();
                 
                }
                else
                {
                    cmd.CommandText = "Update Stocks Set StokMiktari=StokMiktari+" + adet +" where UrunAdi='"+UrunAdi+"'";
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = "Select Id from Stocks where UrunAdi='" + UrunAdi+"'";
                SQLiteDataReader reader= cmd.ExecuteReader();
                string idstring = "";
                while (reader.Read())
                {
                    idstring = reader["Id"].ToString();
                }
                
                connection.Close();
                return Convert.ToInt32(idstring);
                
            }
        }
        public string GrsKaydet(int id,string UrunAdi,string OlcuBirimi, string tarih,double adet)
        {
            try
            {
                using (var connection = new SQLiteConnection("Data source = " + Path.Combine(Application.StartupPath, "base/Umut.db;Version=3;Read Only=False;")))
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Girisler (UrunId,UrunAdi, OlcuBirimi, GuncellemeTarihi, GirisMiktari)" +
                        "VALUES(" + id + ",'" + UrunAdi + "', '" + OlcuBirimi + "', '" + tarih + "'," + adet + ");", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return "Kayıt Tamamlandı";
                }
            }
          catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string CksKaydet(int id, string UrunAdi, string OlcuBirimi, string tarih, double adet,string teslimAlan)
        {
            try
            {
                using (var connection = new SQLiteConnection("Data source = " + Path.Combine(Application.StartupPath, "base/Umut.db;Version=3;Read Only=False;")))
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Cikislar (UrunId,UrunAdi, OlcuBirimi, GuncellemeTarihi, CikisMiktari,TeslimAlan)" +
                        "VALUES(" + id + ",'" + UrunAdi + "', '" + OlcuBirimi + "', '" + tarih + "'," + adet + ",'" +teslimAlan+"');", connection);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Update Stocks Set StokMiktari=StokMiktari-" + adet + " where Id=" + id;
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    return "Kayıt Tamamlandı";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
