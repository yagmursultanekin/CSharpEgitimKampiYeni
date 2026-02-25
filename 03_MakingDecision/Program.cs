using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifrenizi giriniz: ");
            //string password;
            //password=Console.ReadLine();

            //if(password=="abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}



            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="Ankara" & country=="Türkiye")
            //{
            //    Console.WriteLine("Bilgiler Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}


            //int number;
            //Console.WriteLine("lütfen bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.Write("sayı yanlış");
            //}


            ////int exam1, exam2, exam3, average;
            ////string result="Hata!";

            //Console.Write("1.sınav notunuz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sınav notunuz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3.sınav notunuz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalamanız: " + average);

            //if(average>=0 & average <= 49)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if(average>=50 & average <= 69)
            //{
            //    result = "Sonuç Orta";
            //}
            //if(average>=70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if(average>=85)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen bir şehir giriniz: ");
            //city = Console.ReadLine();

            //if(city=="Tunceli" | city=="Ankara" | city=="İzmir" | city == "Kayseri")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}

            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil"); 
            //}


            //string username;
            //Console.Write("Lütfen Kullanıcı Adınızı Giriniz: ");
            //username = Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("hoş geldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1.sayının 2.sayıya bölümüden kalan: " + result);



            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("sayı tektir");
            //}

            #endregion


            #region Char Değişkenler ile Karar Yapıları

            //Console.Write("Lütfen Takım Sembolü Giriniz: ");
            //char sembol = char.Parse(Console.ReadLine());

            //if(sembol=='f' || sembol=='F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if(sembol=='b' || sembol=='B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            //if(sembol=='g' || sembol=='G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            #endregion


            #region Örnek Proje Uygulaması

            //Console.WriteLine("**** C# Eğitim Kampı Restoran ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istedğiniz kategoriyi seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("1-Güveç");
            //    Console.WriteLine("2-Fasulye Pilav");
            //    Console.WriteLine("3-Köri Soslu Tavuk");
            //    Console.WriteLine("4-Köri Soslu Penne");
            //    Console.WriteLine("5-Menemen");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Tavuk Çorbası");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine("1-Margarita");
            //    Console.WriteLine("2-Spesiyel Pizza");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine("1-Portakal Suyu");
            //    Console.WriteLine("2-Limonata");
            //    Console.WriteLine("3-Kola");
            //    Console.WriteLine("4-Su");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine("1-Profiterol");
            //    Console.WriteLine("2-Sufle");
            //    Console.WriteLine("3-Trileçe");
            //    Console.WriteLine("4-Magnolia");
            //}








            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //    int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak");break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3:Console.Write("Mart"); break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5:Console.Write("Mayıs"); break;
            //    case 6:Console.Write("Haziran"); break;
            //    case 7:Console.Write("Temmuz"); break;
            //    case 8:Console.Write("Ağustos"); break;
            //    case 9:Console.Write("Eylül"); break;
            //    case 10:Console.Write("Ekim"); break;
            //    case 11:Console.Write("Kasım"); break;
            //    case 12:Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi");break;
            //}


            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("lütfen birinci sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen işlem yapmak istediğiniz sembolü giriniz: ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+': result = number1 + number2;
            //        Console.WriteLine("Toplam: "+result);
            //        break;

            //    case '-': result = number1 - number2;
            //        Console.WriteLine("Fark: "+result);
            //        break;

            //    case '*': result = number1 * number2;
            //        Console.WriteLine("Çarpım: "+result);
            //        break;

            //    case '/': result = number1 / number2;
            //        Console.WriteLine("Bölüm: "+result);
            //        break;


            //}

            #endregion

            Console.Read();

        }
    }
}
