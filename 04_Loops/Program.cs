using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("c# eğitim kampi");
            //}


            //for(int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for(int i=3; i <= 50; i += 3) { 
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for(int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for(int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;

            //}
            //Console.Write(totalValue);

            //int totalValue=0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }          
            //}
            //Console.WriteLine("---------");
            //Console.Write(totalValue);

            //int count=0;
            //for(int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;
            //for(int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda Bakteri Sayısı: " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 12)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int toplam=0;
            //while (i <= 10)
            //{
            //    toplam += i;
            //    i++;
            //}
            //Console.WriteLine(toplam);
            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplama

            //int toplam = 0;
            //int a, b, c;

            //Console.Write("Lütfen 3 basamaklı bir sayı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //a = number % 10;
            //b = (number % 100) / 10;
            //c = number / 100;

            //Console.WriteLine(a + "+" + b + "+" + c);
            //toplam = a + b + c;
            //Console.WriteLine(toplam);

            #endregion

            Console.Read();

        }
    }
}
