using System;
using System.Linq;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //DEğişkenTürü[] diziAdi = new DEğişkenTürü[ElemanSayısı];

            //string[] colors = new string[4];
            //colors[0] = "Red";
            //colors[1] = "Blue";
            //colors[2] = "Green";
            //colors[3] = "Yellow";

            //Console.WriteLine(colors[0]);

            //string[] cities = new string[5];
            //cities[0] = "Ankara";
            //cities[1] = "İstanbul";
            //cities[2] = "İzmir";
            //cities[3] = "Adana";
            //cities[4] = "Bursa";
            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;
            //numbers[4] = 50;
            //numbers[8] = 460;
            //Console.WriteLine(numbers[8]);

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Adana", "Bursa" };
            //Console.WriteLine(cities[1]);

            #endregion

            #region Dizideki Tüm Elemanları Ekrana Yazdırma

            //string[] colors = { "Red", "Blue", "Green", "Yellow" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { '+', '-', '*', '/', '%' };
            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 10, 20, 30, 40, 50 };
            //int maxNumber = myArray[0]; 
            //for (int i = 0; i < myArray.Length; i++) 
            //{
            //    if (myArray[i] > maxNumber)//myArray[i] elemanı maxNumber'dan büyükse
            //    {
            //        maxNumber = myArray[i];//maxNumber'ı myArray[i] yap
            //    }
            //}
            //Console.WriteLine("En büyük sayı: " + maxNumber);

            //string[] persons = { "Ali", "Veli", "Deli", "Mehmet", "Ayşe" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region  Dizi Metotları

            //string[] customers = { "Ali", "Veli", "Deli", "Mehmet", "Ayşe" };
            //int index = Array.IndexOf(customers, "Deli");
            //Console.WriteLine("Index: " + index);

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " dizinin en kucuk elemanı: " + numbers.Min());

            #endregion

            #region kullanıcadan deger alma

            //string[] cities = new string[5];

            //for(int i=0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine("Toplam: " + sum);

            //int[] numbers = { 0, 21,42, 23, 44,55,446,457,458,9 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion

            Console.Read();

        }
    }
}
