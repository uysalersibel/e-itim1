using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişkenler
            ////double number;

            ////number = 4.85;
            ////Console.WriteLine(number);
            //Console.WriteLine("++++ Fiyat Listesi ++++");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice= 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim fiyatı: " + applePrice + "TL");
            //Console.WriteLine("---- Portakal Birim fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("---- Çilek Birim fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("---- Patates Birim fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine("---- Domates Birim fiyatı: " + tomatoPrice + "TL");

            //double appleGram , orangeGram , strawGram , potatoGram , tomatoGram ;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram  = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawTotalPrice = strawberryPrice * strawGram;
            //double patoTotalPrice = potatoGram * potatoPrice;
            //double tomotTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma -  " + "-Birim fiyat: " 
            //    + applePrice + "- Gramaj: " + appleGram+ "-toplam tutar: " +appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: portakal -  " + "-Birim fiyat: "
            // + orangePrice + "- Gramaj: " + orangeGram + "-toplam tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek-  " + "-Birim fiyat: "
            //             + strawberryPrice + "- Gramaj: " + strawGram + "-toplam tutar: " + strawTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates -  " + "-Birim fiyat: "
            //             + potatoPrice + "- Gramaj: " + potatoGram + "-toplam tutar: " + patoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates -  " + "-Birim fiyat: "
            //             + tomatoPrice + "- Gramaj: " + tomatoGram + "-toplam tutar: " + tomotTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + patoTotalPrice + tomotTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alıveriş toplam tutar: "+ shoppingTotalPrice + "TL");



            #endregion

            #region Char Değişkenler
            //ABCDEFGH sezar şifresi 3 harf sonra değişmesi
            //DEF ... 

            //TOPLANTI SAAT 20:00'DE
            //" CHARLAR ' BUNLA TANIMLANIYOR.

            //char symbol;
            //symbol = 'a';


            //Console.WriteLine(symbol);




            #endregion

            #region Klavyeden Veri girişleri string değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity,
            //    passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Tc kimlik no: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Yolcu tc kimlik numarası : " + passengerIdentityNumber + " Yolcu adı soyadı: " + passengerName + " " + passengerSurname + " "
            //    + passengerDistrict + "/" + passengerCity + " " + passengerAge);











            #endregion

            #region Klavyeden tam sayı girişleri ve Dönüşümler

            ////ABC12D bilet mantığı

            //int shoePrice, computerPrice, chairPrice, tvPrice;

            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;


            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");

            //shoeCount = int.Parse(Console.ReadLine()); // parse metodu ile inti 32 bit aralığında döndürür.

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");

            //chairCount = int.Parse(Console.ReadLine()); // parse metodu ile inti 32 bit aralığında döndürür.

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount*shoePrice + computerCount*computerPrice + 
            //    chairCount*chairPrice + tvCount*tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice + "TL");



            #endregion

            #region Klavyeden Ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1= double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) /3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);





            #endregion


            Console.Read();


        }
    }
}
