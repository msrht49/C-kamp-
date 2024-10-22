using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Void Metotlar

            // () parantez ile biterler
            // İkiye ayrılır
            // 1-Geriye değer döndürmeyen metotlar (Void)
            // Belli işlemleri tekrardan kurtarmaya da yarar. 

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");

            //    Console.WriteLine("Ayşe Yıldız");

            //    Console.WriteLine("Hakan Öztürk");

            //    Console.WriteLine("Merve Çınar");

            //}

            //CustomerList();



            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}

            //Sum();












            #endregion




            #region Geriye değer döndürmeyen string parametreli metotlar


            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşe", "Kaya");


            #endregion



            #region Geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(7, 8, 9);


            #endregion


            #region Geriye değer döndüren metotlar

            // void ile tanımlanmaz

            //bu örnekte değer dönüyor ama ekrana yazmıyor.
            //string CustomerName()
            //{
            //    return "Bahri Fahri";
            //}

            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "ali";
            //    string surname = "veli";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());


            #endregion


            #region Geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke : " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            ////kullanıcıdan veri alamadan da yapabiliriz.
            //Console.WriteLine(CountryCard("İtalya", "Roma", "Kırmızı-Beyaz-Yeşil"));

            #endregion


            #region Geriye değer döndüren int parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,55));
            //Console.WriteLine(Sum(13,27));
            //Console.WriteLine(Sum(26,44));
            //Console.WriteLine(Sum(19,81));


            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student,int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return "Öğrenci sınavı geçti";
            //    }
            //    else
            //    {
            //        return "Öğrenci başarısız oldu";
            //    }


            //}

            //Console.WriteLine(ExamResult("Ali", 23, 45, 50));
            //Console.WriteLine(ExamResult("Veli", 42, 75, 80));




            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student  + " isimli öğrenci başarısız oldu "+ "Ortalama: " + result ;
            //    }


            //}

            //Console.WriteLine(ExamResult("Ali", 23, 45, 50));
            //Console.WriteLine(ExamResult("Veli", 42, 75, 80));
            #endregion


            Console.Read();

        }
    }
}
