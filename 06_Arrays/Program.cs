using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Ohrid";
            //cities[1] = "Üsküp";
            //cities[2] = "Paris";
            //cities[3] = "Lyon";
            //cities[4] = "Milano";

            //Console.WriteLine(cities[0]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[7]);

            //string[] cities = { "Prag","Roma","Atina","Ankara","Bursa" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "kırmızı", "beyaz", "sarı", "lacivert", "pembe", "yeşil", "turuncu" };

            //for(int i=0;i<colors.Length;i++)
            //{
            //    Console.WriteLine(colors[i]);

            //}

            //int[] numbers = { 32, 45, 75, 80, 90, 100, 110 };
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            //int[] myArray = { 21, 20, 25, 30, 35, 110, 48, 150, 85, 100 };

            //int maxNumber = myArray[0];

            //for(int i = 0; i < myArray.Length; i++) { 
            //if (myArray[i] > maxNumber)
            //{
            //    maxNumber = myArray[i];
            //}
            //}
            //Console.Write("En büyük değer: " + maxNumber);


            //int[] numbers = { 45, 82, 52, 41, 86 };
            //Array.Sort(numbers);
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 45, 82, 52, 41, 86 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotlar

            //string[] customers = { "Ali", "Yağmur", "Sultan", "Ekin", "Bahri" };
            //int index = Array.IndexOf(customers, "Ali");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 35, 100, 250, 101 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 35, 5, 10, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.Write(sum);



            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748,39,220 };

            //Console.WriteLine("Çift Sayılar: ");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Tek Sayılar: ");
            //Console.WriteLine();

            //for(int i = 0; i < numbers.Length; i++)
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
