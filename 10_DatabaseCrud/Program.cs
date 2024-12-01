﻿using System;
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
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("--------------------------------------");

            #region Kategori Ekleme İşlemi
            //Crud-->Create-Read-Update-Delete

            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("--------------------------------------");
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categorName=Console.ReadLine();

            //SqlConnection connection=new SqlConnection("Data Source=MONSTER\\SQLEXPRESS;initial catalog=EgitimKampiDb;" +
            //    "integrated security=true");

            //connection.Open();
            //SqlCommand command=new SqlCommand("insert into TblCategory(CategoryName) values(@p1)",connection);
            //command.Parameters.AddWithValue("@p1",categorName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;


            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MONSTER\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün eklemesi başarılı!");





            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=MONSTER\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable datatable=new DataTable();
            //adapter.Fill(datatable);

            //foreach (DataRow row in datatable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün ID: ");
            //int productid=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MONSTER\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where Productid=@Productid",connection);
            //command.Parameters.AddWithValue("@Productid",productid);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme İşlemi Yapıldı");




            #endregion

            #region Ürün Güncelleme İşlemi 

            //Console.Write("Güncellenecek Ürün Id: ");
            //int Productid=int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName=Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice=decimal.Parse(Console.ReadLine());
   

            //SqlConnection connection = new SqlConnection("Data Source=MONSTER\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command=new SqlCommand("Update TblProduct Set ProductName=@ProductName,ProductPrice=@ProductPrice Where Productid=@Productid",connection);
            //command.Parameters.AddWithValue("@ProductName", productName);
            //command.Parameters.AddWithValue("@ProductPrice", productPrice);
            //command.Parameters.AddWithValue("@Productid", Productid);
            //command.ExecuteNonQuery();



            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı!");

            #endregion



            Console.Read();
        }
    }
}
