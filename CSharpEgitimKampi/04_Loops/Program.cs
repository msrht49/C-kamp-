using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {


            #region For Döngüsü

            //for(x;y;z) 3 adet parametresi vardır
            // x:başlangıç değerini tutar
            // y:bitiş değerini tutar
            // z:artış-azalış değerini tutar


            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            /*
            
            for (int i = 1; i <= 20 ; i++)
            {
                Console.WriteLine(i);
            }

            */


            /*

            for (int i = 3; i <= 50; i += 3)
            {
                Console.WriteLine(i);
            }

            */


            /*

            Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            int finishValue = int.Parse(Console.ReadLine());

            for (int i = 1; i <= finishValue; i++)
            {
                Console.WriteLine("C# kazanım");
            }

            */








            #endregion



            #region For Döngüsü ile Karar Yapıları


            /*

            for (int i = 1; i <= 100; i++)
            {
                if(i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            */

            /*

            int totalValue = 0;

            for (int i = 1; i <= 10; i++)
            {
                totalValue += i;
            }

            Console.WriteLine(totalValue);

            */


            /*

            int totalValue = 0;

            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    totalValue += i;
                    Console.WriteLine(i);
                }

            }



            Console.WriteLine("---------");
            Console.WriteLine(totalValue);

            */

            /*
             
            int count = 0;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 7 == 0)
                {
                    count++;
                }

            }

            Console.WriteLine(count);

            */

            /*

            // 2ye bölünerek çoğalan bakteri örneği. 24 saat sonra ne kadar bakteri olur?

           
            int bacterium = 1;

            for (int i = 1; i <= 24 ; i++)
            {
                bacterium *= 2;
                Console.WriteLine(i + ".saat sonunda: " + bacterium);

            }

            */







            #endregion



            #region while döngüsü

            // while(şart)
            // {
            //    işlemler
            // {


            /*

            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine("Merhaba Döngüler");
                i++;
            }

            */


            /*
            int i = 1;
            while (i <= 10)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            */

            /*
            int i = 1;
            int sum = 0;
            while(i <= 10)
            {
                sum += i;
                i++;
            }

            Console.WriteLine(sum);

            */











            #endregion




            #region Örnek sınav sorusu

            /*

            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            // 1453

            Console.Write("Sayıyı giriniz: ");
            int number = int.Parse(Console.ReadLine());

            int ones, tens, hundreds, thousands;
            int sum = 0;

            ones = number % 10;
            tens = (number % 100) / 10;  // it is 5.3 but because of int it will be 5
            hundreds = (number % 1000) / 100;
            thousands = (number % 10000) / 1000;


            Console.WriteLine(ones + " - " + tens + " - " + hundreds + " - " + thousands);

            sum = ones + tens + hundreds + thousands;

            Console.WriteLine(sum);

            */

            #endregion








            Console.Read();


        }
    }
}
