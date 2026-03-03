using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //customerList();



            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");


            //void customerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //customerCard("Mehmet", "Yıldız");
            //customerCard("Ayşegül", "Kaya");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);










            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string StudentCard()
            //{
            //    string name="Ali";
            //    string surname="Kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " -Başkent: " + capital + " -Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));


            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " -Başkent: " + capital + " -Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz:");
            //x = Console.ReadLine();
            //Console.Write("Ülkenin başkentini yazınız: ");
            //y = Console.ReadLine();
            //Console.Write("Ülkenin bayrak renklerini giriniz: ");
            //z= Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result=number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(50, 600));
            //Console.WriteLine(Sum(450, 980));
            //Console.WriteLine(Sum(045, 098));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string studentName,int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;

                if (result >= 50)
                {
                    return studentName + " isimli öğrenci dersi geçti " + "Ortalama: " + result;
                }
                else
                {
                    return studentName + " isimli öğrenci dersten kaldı " + "Ortalama: " + result;
                }
            }
            Console.WriteLine(ExamResult("Ali", 50, 40, 10));
            Console.WriteLine(ExamResult("Ayşe", 50, 80, 100));







            #endregion

            Console.Read();

        }
    }
}
