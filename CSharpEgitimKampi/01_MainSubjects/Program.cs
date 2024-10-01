using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using ifadeler kullanacağımız kodlara ait kütüphaneleri tutuyor.

namespace _01_MainSubjects
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları


            // Console.Write("Merhaba Dünya");//imleç yanında durur.
            // Console.WriteLine("Selam");// imleç bir aşağı iner.

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion





            #region String Değişkenler


            //değişken_türü değişken_adı;  şeklinde yazılır

            // string

            /* string name;
             name = "Serhat";
             Console.Write(name);
            */

            /*
            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Ali";
            customerSurname = "Çınar";
            customerPhone = " 0500 123 45 64";
            customerEmail = "denem@gmail.com";
            district = " Üsküdar";
            city = "İstanbul";

            Console.WriteLine("***** Rezerevasyon Kartı *****");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim : " + customerPhone);
            Console.WriteLine("Email adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("----------------------------------------");


            Console.WriteLine();


            customerName = "Veli";
            customerSurname = "Kaya";
            customerPhone = "0312 753 14 68";
            customerEmail = "test@hotmail.com";
            district = "Sapanca";
            city = "Sakarya";

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("----------------------------------------");

            */
            #endregion






            #region Int Değişkenler

            //int
            // int number = 25;
            //Console.WriteLine(number);

            /*
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("---Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("---Kola: " + cokePrice + " TL");
            Console.WriteLine("---Su: " + waterPrice + " TL");
            Console.WriteLine("---Kızartma: " + friesPrice + " TL");
            Console.WriteLine("---Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("---Limonata: " + lemonadePrice + " TL");


            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;



            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 2;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 3;


            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice);
            Console.WriteLine("Kola Tutarı: " + totalCokePrice);
            Console.WriteLine("Su Tutarı: " + totalWaterPrice);
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice);
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice);
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice);



            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice);

            */


            #endregion











            Console.Read();
        }
    }
}

