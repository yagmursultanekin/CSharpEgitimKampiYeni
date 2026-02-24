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

            #region Değişkenler

            //string
            //Değişken_türü değişken_adı

            // string name;
            // name = "Yağmur Sultan";
            //Console.Write(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Yağmur Sultan";
            customerSurname = "Ekin";
            customerPhone = "0555 893 93 62";
            customerEmail = "deneme@gmail.com";
            district = "Pertek";
            city = "Tunceli";

            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);







            #endregion

            Console.Read();
        }
    }
}
