using System;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //For(x;y;z)
            //x: Başlangıç değeri
            //y: Bitiş değeri
            //z: Artış-azalış miktarı

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 3; i <= 50; i+= 3) //3er 3er arttırarak 50'ye kadar yazdırır.
            //{
            //    Console.WriteLine(i);
            //},

            //Console.Write("lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yasasın Cumhuriyet");
            //}
            #endregion

            #region For Dögüsü ile karar yapıları

            //for (int i = 1; i <= 100; i++) //1'den 100'e kadar olan sayıları yazdırır.
            //{
            //    if (i % 5 == 0) //5'e bölünen sayıları yazdırır.
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i; 
            //}
            //Console.WriteLine("Toplam Değer: " + totalValue);

            //int totalValue = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Toplam Değer: " + totalValue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0) 
            //    {
            //        count++; //7'ye bölünen sayıların adedini bulur.
            //    }
            //}
            //Console.WriteLine(count); //7'ye bölünen sayıların adedini yazdırır.

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda: " + bacterium);
            //}

            #endregion

            #region While Döngüsü 

            //Koşul sağlandığı sürece çalışır.

            //While(şart)
            //{
            //işlemler
            //}

            //int i = 1;
            //while (i<10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1; //Başlangıç değeri
            //int sum = 0; //Toplam değeri
            //while (i<=10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("Toplam Değer: " + sum);

            #endregion

            #region Örnek Sınav Sorusu

            // klavyeden girilen 3 basamaklı sayının basakları toplamını hesaplayan kodu yazınız.

            //Console.Write("3 Basamaklı Bir Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10; //Birler basamağı
            //tens = (number % 100) / 10;
            //hundreds = number / 100;

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine("Basamakları Toplamı: " + sum);

            #endregion



            Console.Read();
        }
    }
}

