using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD - Create Read Update Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");

            #region Kategori Eklemek
            //Console.Write("Eklemek istediğiniz kategori adı:");
            //string categoryName = Console.ReadLine();

            //SqlConnection sqlConnection = new SqlConnection("Data Source=IBRAHIMTATAR\\MSSQLSERVER01;Initial Catalog=EgitimKampiDb;Integrated Security=True;");
            //sqlConnection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", sqlConnection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            ////@p1 ile parametre değerini atıyoruz. sqldeki parametre değerine benzer
            //command.ExecuteNonQuery(); //Direk sorguyu çalıştır. 
            //sqlConnection.Close();

            //Console.Write("Kategori başarıyla eklendi");
            #endregion

            #region Ürün ekleme işlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName=Console.ReadLine();

            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data source=IBRAHIMTATAR\\MSSQLSERVER01;initial catalog=EgitimKampiDb;integrated security=true");

            //conn.Open();

            //SqlCommand cmd = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",conn);

            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productStatus", true);
            //cmd.ExecuteNonQuery();

            //conn.Close();
            //Console.WriteLine("Ürün eklemesi başarılı");
            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection conn = new SqlConnection("Data Source =IBRAHIMTATAR\\MSSQLSERVER01;initial catalog=EgitimKampiDb;integrated security=true");
            //conn.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item+" ");
            //    }
            //    Console.WriteLine() ;
            //}



            //conn.Close();
            #endregion

            #region Ürün silme işlemi

            //Console.Write("Silinecek ürün idsi:");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data Source =IBRAHIMTATAR\\MSSQLSERVER01;initial catalog=EgitimKampiDb;integrated security=true");
            //conn.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",conn);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //Console.WriteLine("Silme İşlemi Yapıldı");
            //conn.Close();
            #endregion

            #region Güncelleme işlemi

            Console.Write("Ürün idsini giriniz:");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Ürün adını giriniz:");
            string productName = Console.ReadLine();

            Console.Write("Ürün fiyatını giriniz:");
            decimal productPrice = decimal.Parse(Console.ReadLine());   

            SqlConnection conn = new SqlConnection("Data Source =IBRAHIMTATAR\\MSSQLSERVER01;initial catalog=EgitimKampiDb;integrated security=true");
            conn.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice WHERE ProductId=@productId",conn);
            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.ExecuteNonQuery();

            conn.Close();

            Console.WriteLine("Güncelleme başarılı");
            #endregion

            Console.ReadKey();

        }
    }
}
