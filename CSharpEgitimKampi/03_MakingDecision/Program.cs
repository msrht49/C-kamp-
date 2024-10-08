using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {

            #region If ELse

            /*
            Console.Write("Lütfen şifreyi giriniz: ");
            string password;
            password = Console.ReadLine();
            
            if (password == "abcd")
            {
                Console.WriteLine("Şifre Doğru");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }
            */

            /*
            string capital, country;
            Console.Write("Başkenti Giriniz: ");
            capital = Console.ReadLine();

            Console.Write("Ülkeyi Giriniz: ");
            country = Console.ReadLine();

            if(capital == "ankara" & country == "türkiye")
            {
                Console.Write("veriler doğrulandı");
            }
            else
            {
                Console.Write("hatalı bilgi");
            }
            */

            /*
            int number;
            Console.Write("Sayıyı Giriniz: ");
            number = int.Parse(Console.ReadLine());
            if(number == 7)
            {
                Console.WriteLine("Sayı doğru: ");
            }
            else
            {
                Console.WriteLine("Sayı hatalı:");
            }
            */

            /*
            int exam1, exam2, exam3, average;
            string result = "Hata";  // burada string "hata" atadık çünkü aksi durumda şartlar dışında bir durum yaşanır diye error verdi

            Console.Write("Sınav1: ");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("Sınav2: ");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("Sınav3: ");
            exam3 = int.Parse(Console.ReadLine());


            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınavların Ortalaması: " + average);

            if (average > 0 & average <= 50)
            {
                result = "Sonuç Vasat";
            }
            if (average > 50 & average <= 70)
            {
                result = "Sonuç Orta";
            }
            if (average > 70 & average <= 84)
            {
                result = "Sonuç İyi";
            }
            if (average > 84)
            {
                result = "Sonuç Çok İyi";
            }

            Console.WriteLine(result);

            */


            /*
            string city;
            Console.Write("Lütfen şehir adını yazınız: ");
            city = Console.ReadLine();

            if(city=="adana"| city == "ankara" | city == "bursa" | city == "istanbul")
            {
                Console.WriteLine("Şehir mevcut");
            }
            else
            {
                Console.WriteLine("Şehir mevcut değil");
            }
            */


            /*
            Console.Write("Please enter username:");
            string username = Console.ReadLine();
            if (username != "admin")
            {
                Console.Write("This username can not be accepted!");
            }
            else
            {
                Console.Write("Welcome");
            }
            */

            // Console.Read();
            #endregion


            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            /*
             *
            Console.Write("Please enter number1: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter number2: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 % number2;

            Console.Write("The remainder of the division of the 1st number by the 2nd number ");

            Console.Read();

            */

            /*
            Console.Write("Please enter the number ");
            int number = int.Parse(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine("The number is even ");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            */

            #endregion



            #region Char DEğişkenler ile Karar Yapıları

            /*
             
            char team;
            Console.Write("Please enter team symbol: ");
            team = char.Parse(Console.ReadLine());

            if (team == 'g' | team == 'G')
            {
                Console.WriteLine("Galatasaray");
            }
            if (team == 'f' | team == 'F')
            {
                Console.WriteLine("Fenerbahçe");
            }
            if (team == 'b' | team == 'B')
            {
                Console.WriteLine("Beşiktaş");
            }

            

            Console.Read();
            */

            #endregion




            #region Örnek Proje Uygulaması



            /*

            Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

            string menuItem;

            Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("-----------Ana Yemekler----------");
                Console.WriteLine();
                Console.WriteLine("1-Patates Yahnisi");
                Console.WriteLine("2-Soğanlı Yumurtalı Kıyma");
                Console.WriteLine("3-Tavuk Sote");
                Console.WriteLine("4-Patlıcan Kebabı");
                Console.WriteLine("5-Muş Köftesi");
                Console.WriteLine("-----------Ana Yemekler----------");

            }

            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("-----------Çorbalar----------");
                Console.WriteLine();
                Console.WriteLine("1-Mercimek Çorbası");
                Console.WriteLine("2-Tarhana Çorbası");
                Console.WriteLine("3-Domates Çorbası");
                Console.WriteLine("-----------Çorbalar----------");

            }

            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("-----------Pizzalar----------");
                Console.WriteLine();
                Console.WriteLine("1-Margarita");
                Console.WriteLine("2-Sucuklu");
                Console.WriteLine("3-Çıtır Tavuklu");
                
                Console.WriteLine("-----------Pizzalar----------");

            }

            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("-----------İçecekler----------");
                Console.WriteLine();
                Console.WriteLine("1-Su");
                Console.WriteLine("2-Gazoz");
                Console.WriteLine("3-Limonata");
                Console.WriteLine("4-Şerbet");
                Console.WriteLine("5-Şalgam");
                Console.WriteLine("-----------İçecekler----------");

            }

            if (menuItem =="5")
            {
                Console.WriteLine();
                Console.WriteLine("-----------Tatlılar----------");
                Console.WriteLine();
                Console.WriteLine("1-Sütlaç");
                Console.WriteLine("2-Soğuk Baklava");
                Console.WriteLine("3-Trileçe");
                Console.WriteLine("4-Kadayıf");        
                Console.WriteLine("-----------Tatlılar----------");

            }


            Console.Read();

            */




            #endregion



            #region Switch Case

            /*
             
            Console.Write("Please enter the month:");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:Console.Write("January");break;
                case 2:Console.Write("February"); break;
                case 3: Console.Write("March"); break;
                case 4: Console.Write("April"); break;
                case 5: Console.Write("May"); break;
                case 6: Console.Write("June"); break;
                case 7: Console.Write("July"); break;
                case 8: Console.Write("August"); break;
                case 9: Console.Write("September"); break;
                case 10: Console.Write("October"); break;
                case 11: Console.Write("November"); break;
                case 12: Console.Write("December"); break;

                default:Console.Write("Wrong data!");break;

            }
            
          
            Console.Read();

            */


            #endregion




            #region Switch Case Hesap Makinesi


            //int number1, number2, result;
            //char symbol;

            //Console.Write("Enter number1: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter number2: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the math operation you want to do: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sum: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Substraction: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Multiplication: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Division: " + result);
            //        break;
            //}

            //Console.Read();

            #endregion












        }
    }
}
