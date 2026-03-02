using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Foreach Döngüsü

            // Foreach(1;2;3;4)

            //string[] cities = { "Tunceli", "İzmir", "Manisa", "Ankara" };

            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = {1,2,3,4,5,6,7};

            //foreach(int sayi in numbers)
            //{
            //    Console.WriteLine(sayi);
            //}


            //int[] numbers = { 35, 42, 1000, 500, 3, 2, 0 };

            //foreach(int sayi in numbers)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //}


            //int[] numbers = { 35, 42, 1000, 500, 3, 2, 0 };

            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,5,8
            //};

            //foreach(int number in numbers) 
            //{ 
            //Console.WriteLine(number);
            //}


            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
           
           //sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("---------------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var? : ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");

           //öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentsNames=new string[studentCount];
            double[] studentsExamAvg=new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin adını giriniz: ");
                studentsNames[i] = Console.ReadLine();

                double totalExamResult = 0;

          //her öğrenci için 3 sınav notu girişi

                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentsNames[i]} isimli öğrencinin {j+1}. sınav notunu giriniz:  ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz
                }
                Console.WriteLine();

                studentsExamAvg[i] = totalExamResult / 3;

            }

            //sınav ortalamaları

            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentsNames[i]} isimli öğrencinin ortalaması: {studentsExamAvg[i]}");

                //öğrencilerin ortalaması ve geçip kalma durumları

                if (studentsExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentsNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentsNames[i]} adlı öğrenci dersten kaldı");
                }

                Console.WriteLine("------------------------------");
            }








            #endregion

            Console.Read();
        }
    }
}
