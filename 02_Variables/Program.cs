using System;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number =4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice = 14.85;
            //double orangePrice = 20.95;
            //double strawberryPrice = 45;
            //double potatoPrice = 9.74;
            //double tomatoPrice = 6.88;

            //Console.WriteLine("--- Elma Kilogram Fiyatı: " + applePrice +" TL");
            //Console.WriteLine("--- Portakal Kilogram Fiyatı: " + orangePrice +" TL");
            //Console.WriteLine("--- Çilek Kilogram Fiyatı: " + strawberryPrice +" TL");
            //Console.WriteLine("--- Patates Kilogram Fiyatı: " + potatoPrice +" TL");
            //Console.WriteLine("--- Domates Kilogram Fiyatı: " + tomatoPrice +" TL");

            //double appleGram = 1.245;
            //double orangeGram = 2.650;
            //double strawberryGram = 0.750;
            //double potatoGram = 3.658;
            //double tomatoGram = 1.841;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;
            //double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Elma / " +" Birim Fiyatı: "+applePrice+ " TL"+" / "+" Alınan Miktar: " +appleGram+" Kg "+" / "+ "Ödenecek Tutar: "+appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal / " +" Birim Fiyatı: "+orangePrice+ " TL"+" / "+" Alınan Miktar: " +orangeGram+" Kg "+" / "+ "Ödenecek Tutar: "+orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Çilek / " +" Birim Fiyatı: "+strawberryPrice+ " TL"+" / "+" Alınan Miktar: " +appleGram+" Kg "+" / "+ "Ödenecek Tutar: "+strawberryTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Patates / " +" Birim Fiyatı: "+potatoPrice+ " TL"+" / "+" Alınan Miktar: " +appleGram+" Kg "+" / "+ "Ödenecek Tutar: "+potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Domates / " +" Birim Fiyatı: "+tomatoPrice+ " TL"+" / "+" Alınan Miktar: " +appleGram+" Kg "+" / "+ "Ödenecek Tutar: "+tomatoTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödenecek Tutar: "+totalPrice + " TL");


            #endregion

            #region Char Değişkenler

            //char symbol = 'M';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu İlçe: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu İl: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu T.C. Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu T.C. Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, compusterPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //compusterPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız ayakkabı adedini giriniz:");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar adedini giriniz:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye adedini giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon adedini giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice =shoesCount * shoesPrice + computerCount * compusterPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice +"TL" );


            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result=(exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " +result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());   

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion



            Console.Read();

        }
    }
}
