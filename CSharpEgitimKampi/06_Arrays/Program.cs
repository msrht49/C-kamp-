using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {



            #region Temel Dizi Örnekleri

            // Aynı veri tipindeki çok sayıda veriyi bir arada tutmaya yarayan yapılardır. --> Diziler
            //2-4-6-8
            //sarı,kırmızı,mavi,siyah,beyaz

            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]


            //string[] colors = new string[4];
            //colors[0] = "white";
            //colors[1] = "yellow";
            //colors[2] = "blue";
            //colors[3] = "red";

            //Console.WriteLine(colors[2]);



            //string[] cities = new string[5];

            //cities[0] = "Roma";
            //cities[1] = "Budapeşte";
            //cities[2] = "Cidde";
            //cities[3] = "Üsküp";
            //cities[4] = "Londra";

            //Console.WriteLine(cities[2]);


            //int[] numbers = new int[10]; // 10 tanenin hepsini yazmak zorunda değiliz.
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[3] = 75;
            //numbers[4] = 25;
            //numbers[8] = 356;

            //Console.WriteLine(numbers[4]);




            //string[] cities = { "Prag", "Roma", "İstanbul", "Bakü" };

            //Console.WriteLine(cities[2]);








            #endregion





            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Beyaz", "Siyah", "Turuncu" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 5, 76, 88, 29, 65, 198, 2546, 3528, 933, 1024, 6396 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {

            //        Console.WriteLine(numbers[i]);


            //    }

            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}



            //int[] myArray = { 47, 85, 95, 41, 295, 3687, 735 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);



            //Length metodu
            //string[] persons = { "ali", "ahmet", "mehmet", "veli", "cem", "fazlı","cafer" };

            //Console.WriteLine(persons.Length);


            //Sort metodu --> sıralamaya yarar,küçükten büyüğe

            //int[] numbers = { 45, 85, 73, 13, 26, 39, 58 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //Reverse dizi tersten sıralar

            //int[] numbers = { 45, 85, 73, 13, 26, 39, 58 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            #endregion



            #region Dizi Metotlar

            // Indexof metodu

            //string[] customers = { "ali", "veli", "ayşe", "çınar", "merve" };
            //int index = Array.IndexOf(customers, "çınar");

            //Console.WriteLine(index);



            //int[] numbers = { 45, 85, 68, 96, 76, 10, 25, 38 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " " + "Dizinin en küçük elemanı: " + numbers.Min());







            #endregion



            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------------");

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

            //Console.WriteLine(sum);



            //int[] numbers = { 21, 32, 43, 54, 65, 76, 87, 98, 109, 233 };

            
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}











            #endregion


           // Console.Read();






        }
    }
}
