using System;
using System.Collections.Generic;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:DEğişken türü
            //2:DEğişken adı
            //3:In
            //4:Liste,koleksiyon, dizi

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Adana", "Bursa" };
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50, 845, 2315, 5454, 542, 1, 4513, 845 };
            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 10, 20, 30, 40, 50, 845, 2315, 5454, 542, 1, 4513, 845 };
            //int total = 0;
            //foreach (var number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine("Toplam: " + total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9,10
            //};
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word= "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}





            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("****** C# Eğitim Kampı Sınav Uygulaması ******");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////sınıftakı ogerncı sayısını kullanıcıdan alma
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Sınıfınızda kac ogrencı var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------------------------");

            ////ogrencı adlarını ve notlarını tutacak diziler
            //string[] studentName = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}.öğrencinin ismini giriniz");
            //    studentName[i] = Console.ReadLine(); //ogrencı adını al

            //    double totalExamResult = 0;

            //    //her ogrencı ıcın 3 sınav notu girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentName[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;//sınav notlarını topla
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3; //ogrencı not ortalamasını hesapla

            //}


            ////ogrencılerın not ortalamalarını 
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentName[i]} isimli öğrencinin sınav not ortalaması: {studentExamAvg[i]}");

            //    //öğrencilerin ortalaması ve geçip kalma durumları

            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı ögrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı ögrenci dersten kaldı");
            //    }
            //    Console.WriteLine("-------------------------------------------");
            //}


            #endregion

            Console.Read();
        }
    }
}
