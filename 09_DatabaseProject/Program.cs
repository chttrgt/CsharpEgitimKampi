using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ADO.NET

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişiler");
            Console.WriteLine("4-Çıkış Yap\n");
            Console.WriteLine("---------------------------------------\n");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();

            SqlConnection con = new SqlConnection("data source=CIHATTURGUT\\SQLCHTTRGT; initial catalog=EgitimKampiDb; integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tblCategory", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {

                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            con.Close();

            #endregion



            Console.Read();
        }
    }
}
