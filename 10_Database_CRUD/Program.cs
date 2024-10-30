using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Database_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Create --> Read --> Update --> Delete (CRUD) 
            
            */

            #region Kategori Ekleme İşlemi

            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------");
            //Console.Write("Eklemek istediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection conn = new SqlConnection("data source=CIHATTURGUT\\SQLCHTTRGT; initial catalog=EgitimKampiDb; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Insert into tblCategory (CategoryName) values(@p1) ", conn);
            //cmd.Parameters.AddWithValue("@p1", categoryName);
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //Console.WriteLine("Kategori başarılı bir şekilde eklendi!");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //Console.Write("Ürün Durumu: ");
            //productStatus = bool.Parse(Console.ReadLine());

            //SqlConnection con = new SqlConnection("data source=CIHATTURGUT\\SQLCHTTRGT; initial catalog=EgitimKampiDb; integrated security=true");
            //con.Open();

            //SqlCommand cmd = new SqlCommand("Insert into tblProduct(productName,productPrice,productStatus) values(@pName,@pPrice,@pStatus)", con);
            //cmd.Parameters.AddWithValue("@pName", productName);
            //cmd.Parameters.AddWithValue("@pPrice", productPrice);
            //cmd.Parameters.AddWithValue("@pStatus", productStatus);
            //cmd.ExecuteNonQuery();

            //con.Close();

            //Console.WriteLine("Ürününüz başarıyla eklenmiştir!");



            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection con = new SqlConnection("data source=CIHATTURGUT\\SQLCHTTRGT; initial catalog=EgitimKampiDb; integrated security=true");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select * From tblProduct", con);
            //SqlDataAdapter ad = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //ad.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    foreach (var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }

            //    Console.WriteLine();
            //}

            //con.Close();
            #endregion

            #region Ürün Silme İşlemi

            //SqlConnection con = new SqlConnection("data source=CIHATTURGUT\\SQLCHTTRGT; initial catalog=EgitimKampiDb; integrated security=true");
            //con.Open();
            //SqlCommand cmd1 = new SqlCommand("Select * From tblProduct Where productId=11", con);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    foreach (var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString());
            //    }
            //    Console.WriteLine("\nBu ürünü silmek istiyor musunuz?");
            //}
            //string res = Console.ReadLine();
            //if (res == "y")
            //{
            //    SqlCommand cmd2 = new SqlCommand("Delete From tblProduct Where productId=@pID", con);
            //    cmd2.Parameters.AddWithValue("@pID", 11);
            //    cmd2.ExecuteNonQuery();
            //    SqlCommand cmd3 = new SqlCommand("Select * From tblProduct", con);
            //    SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            //    DataTable dt2 = new DataTable();
            //    adapter2.Fill(dt2);
            //    foreach (DataRow dr in dt2.Rows)
            //    {
            //        foreach (var item in dr.ItemArray)
            //        {
            //            Console.Write(item.ToString() + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //con.Close();

            //Console.WriteLine("Ürün başarıyla silinmiştir!");

            #endregion

            #region Ürün Güncelleme İşlemi
            //Console.Write("Güncellenecek Ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection con = new SqlConnection("data source=CIHATTURGUT\\SQLCHTTRGT; initial catalog=EgitimKampiDb; integrated security=true");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Update tblProduct set productName=@productName, productPrice=@productPrice Where productId=@productId ", con);
            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productId", productId);

            //cmd.ExecuteNonQuery();

            //con.Close();

            //Console.WriteLine("Güncelleme başarılı!");

            #endregion

            Console.Read();

        }
    }
}
