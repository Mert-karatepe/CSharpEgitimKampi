﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ado.net

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;


            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-62BUQ4D\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;User ID=Dh2024Dev;Password=1234; TrustServerCertificate=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }



            #endregion


            Console.Read();
        }
    }
}
