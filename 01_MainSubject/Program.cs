using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjectss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Selam");
            //Console.Write("Merhaba Dünya");
            #endregion

            #region StringDeğişkenler

            //string
            //Değişken_türü değişken_adı

            // string name;
            // name = "Yağmur Sultan";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Yağmur Sultan";
            //customerSurname = "Ekin";
            //customerPhone = "0555 893 93 62";
            //customerEmail = "deneme@gmail.com";
            //district = "Pertek";
            //city = "Tunceli";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Adres: " + district + "/" + city);

            #endregion

            #region Int Değişkenler

            int hamburgerPrice = 300;
            int cokePrice = 60;
            int lemonade = 70;
            int water = 20;

            Console.WriteLine("**** Restorant Fiyat Listesi ****");
            Console.WriteLine("Hamburger:"+hamburgerPrice+ " TL");
            Console.WriteLine("coke:" + cokePrice + " TL");
            Console.WriteLine("lemonade:" + lemonade + " TL");
            Console.WriteLine("water:" + water + " TL");

            int hamburgersayisi = 3;
            int cokesayisi=2;
            int lemonsayisi=1;
            int watersayisi=3;



            int totalprice = (hamburgerPrice * hamburgersayisi) + (cokePrice * cokesayisi) + (lemonade * lemonsayisi) + (water * watersayisi);
            Console.WriteLine("toplam tutar: " + totalprice);




            #endregion



            Console.Read();
        }
    }
}

