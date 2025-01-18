﻿using System;
using System.Data.SqlClient;
using System.Data;


namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud--> Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli");
            Console.WriteLine();

            Console.WriteLine("------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori ad: ");
            //string categoryName = Console.ReadLine();


            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-62BUQ4D\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;User ID=Dh2024Dev;Password=1234; TrustServerCertificate=True");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); 
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            // string productName;
            // decimal productPrice;
            //// bool productStatus;

            // Console.Write("Ürün adı: ");
            // productName =Console.ReadLine();
            // Console.Write("Ürün Fiyatı");
            // productPrice=decimal.Parse(Console.ReadLine());


            // SqlConnection connection = new SqlConnection("Data Source=DESKTOP-62BUQ4D\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;User ID=Dh2024Dev;Password=1234; TrustServerCertificate=True");
            // connection.Open();
            // SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
            // command.Parameters.AddWithValue("@productName", productName);
            // command.Parameters.AddWithValue("productPrice",productPrice);
            // command.Parameters.AddWithValue("productStatus",true);
            // command.ExecuteNonQuery(); 
            // connection.Close();

            // Console.WriteLine("ürün eklemesi başarılı");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-62BUQ4D\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;User ID=Dh2024Dev;Password=1234; TrustServerCertificate=True");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("select * from TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("silinecek ürün Id: ");
            //int productId= int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-62BUQ4D\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;User ID=Dh2024Dev;Password=1234; TrustServerCertificate=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("delete from TblProduct where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı");


            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-62BUQ4D\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;User ID=Dh2024Dev;Password=1234; TrustServerCertificate=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("update TblProduct set ProductName=@productName,ProductPrice=@productprice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productprice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı"); 
            #endregion

            Console.Read();



        }
    }
}
