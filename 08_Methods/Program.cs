using System;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Methotlar 

            //Geriye deger döndürmeyen metotlar

            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Yıldız");
            //    Console.WriteLine("Merve Yıldız");

            //}
            //customerList();

            //void Sum()
            //{
            //    int a = 5;
            //    int b = 10;
            //    int result = a + b;
            //    Console.WriteLine("Toplam: " + result);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Ali Yıldız");

            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //CustomerCard("Ali", "Yıldız");
            //CustomerCard("Ayşe", "Yıldız");

            #endregion

            #region Geriye Değer Döndürmeyen int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //  {
            //      int result = number1 + number2 + number3;
            //      Console.WriteLine("Toplam: " + result);
            //  }
            //  Sum(5, 10, 15);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Ali Yıldız";
            //}
            //CustomerName();

            //string CustomerCard() //Geriye değer döndüren metotlar
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";

            //    return name + " " + surname; //return ile metotun döndüreceği değeri belirtiyoruz.
            //}
            //Console.WriteLine(CustomerCard());//Metotun döndürdüğü değeri ekrana yazdırıyoruz.


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //  {
            //      string cardInfo= "ülke: " + countryName + " - başkent " + capital +" - bayrak rengi" + flagColor;
            //      return cardInfo;
            //  }

            //  string x,y,z;
            //  Console.Write("Ülke giriniz: ");
            //  x = Console.ReadLine();

            //  Console.Write("başkent giriniz: ");
            //  y = Console.ReadLine();

            //  Console.Write("bayrak rengi giriniz: ");
            //  z = Console.ReadLine();

            //  Console.WriteLine(CountryCard(x,y,z));

            //  Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı Beyaz"));

            #endregion

            #region Geriye Değer Döndüren int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result= number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(16 ,50));

            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli Öğrenci Sınavı Geçti" + " Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " Öğrenci Sınavdan Kaldı" + " Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Mert", 16, 85, 75));
            #endregion




            Console.Read();

        }
    }
}
