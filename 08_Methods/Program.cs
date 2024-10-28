using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer-->Listele,ekle,sil,güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ömer Faruk Subaşı");
            //    Console.WriteLine("Ünal Buğra Özbek");
            //    Console.WriteLine("Ömer Faruk Künkül");
            //    Console.WriteLine("Turab Ali Emin Ay");


            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + 3;
            //    Console.WriteLine(z);

            //}
            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}
            //WriteMethod("Oğuz Güven");

            //void CustomerCard(string Name,string Surname)
            //{
            //    Console.WriteLine("Müşteri: " + Name + " " + Surname);
            //}
            //CustomerCard("Mehmet","yıldız");
            //CustomerCard("Mehmet","Akif");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar 

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);


            #endregion

            #region Geriye Değer Döndüren Metotlar 

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";

            //    return name+ " " + surname;


            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren string Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo="Ülke: "+countryName + " -Başkent:  " + capital + " -Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x,y,z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y= Console.ReadLine();

            //Console.Write("Bayrak Rengi Giriniz: ");
            //z=Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));



            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));



            #endregion

            #region Örnek Uygulama

            string ExamResult(string student,int exam1,int exam2,int exam3)
            {
                int result=(exam1+ exam2+exam3)/3;
                if (result >= 50)
                {
                    return student+" isimli öğrenci sınavı geçti" + "Ortalama: "+result ;
                }
                else
                {
                    return student+ " İsimli öğrenci başarısız oldu"+"Ortalama: "+result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            Console.WriteLine(ExamResult("Ayşe",36, 88, 33));

            #endregion

            Console.Read();


            
        }
    }
}
