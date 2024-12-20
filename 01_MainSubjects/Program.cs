using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("*****Yemek Kategorileri *****");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*****Yemek Kategorileri *****");



            #endregion

            #region StringDeğişkenler

            //string
            //değişken_türü değişken_adı;

            //string name;
            //name= "Murat";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district +"/" + city);
            //Console.WriteLine("---------------------------------------------------");


            //Console.WriteLine();
            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("---------------------------------------------------");






            #endregion

            #region Int Değişkenler

            //int
            //int number=34;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı:" + hamburgerPrice +" "+ "TL");
            Console.WriteLine("-----Kola Fiyatı:" + cokePrice +" "+ "TL");
            Console.WriteLine("-----Su Fiyatı:" + waterPrice +" "+ "TL");
            Console.WriteLine("-----Patates Kızartması Fiyatı:" + friesPrice +" "+ "TL");
            Console.WriteLine("-----Pizza Fiyatı:" + pizzaPrice +" "+ "TL");
            Console.WriteLine("-----Limonata Fiyatı:" + lemonadePrice +" "+ "TL");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Hamburger Fiyatı:" + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Fiyatı:" + totalCokePrice + " TL");
            Console.WriteLine("Su Fiyatı:" + totalWaterPrice + " TL");
            Console.WriteLine("Patates Kızartması Fiyatı:" + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Fiyatı:" + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Fiyatı:" + totalLemonadePrice + " TL");

            int totalPrice = totalWaterPrice + totalPizzaPrice + totalLemonadePrice + totalHamburgerPrice + totalFriesPrice + totalCokePrice;

            Console.WriteLine("Toplam Ödeme:" + totalPrice + " TL");

            #endregion


            Console.Read();
        }
    }
}
