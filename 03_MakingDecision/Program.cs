using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.Write("Lütfen şifrenizi girin:");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış!");
            //}

            //string capital, country;

            //Console.Write("Lütfen başkenti giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Lütfen ülkeyi giriniz:");
            //country = Console.ReadLine();

            //if(capital=="Ankara"& country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi!");
            //}

            //Console.Write("Bir sayı giriniz:");
            //int number;
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}


            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("1.Sınavı Girin:");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sınavı Girin:");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3.Sınavı Girin:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalamanız: " + average);

            //if (average>0 &average<=50)
            //{
            //    result = "Sonuç vasat.";
            //}
            //if(average>50&average<=70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average<=84)
            //{
            //    result = "Sonuç iyi"; 
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";

            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir bilgilerini giriniz:");
            //city = Console.ReadLine();

            //if (city == "Adana" | city == "Ankara" | city == "Bursa" | city == "Trabzon") 
            //{
            //    Console.WriteLine("Şehir mevcut.");

            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil.");
            //}

            //Console.Write("Lütfen kullanıcı adını girin:");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez!");

            //}
            //else
            //{
            //    Console.Write("Hoş Geldiniz.");
            //}
            #endregion

            #region Mod İşlemleri
            //int number = 26;

            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz:");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1.Sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen bir sayı giriniz:");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{

            //    Console.WriteLine("Girdiğiniz sayı bir çift sayıdır.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı bir tek sayıdır.");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapılar
            //char team;
            //Console.WriteLine("Lütfen takım sembolünü giriniz:");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if(team=='f'|team == 'F')
            //{

            //    Console.WriteLine("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("****** C# Eğitim Kampı Restoranı ******");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------Ana Yemekler----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("----------------Ana Yemekler----------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------Çorbalar----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("----------------Çorbalar----------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------Pizzalar----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("----------------Pizzalar----------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------İçecekler----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("----------------İçecekler----------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------Tatlılar----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("----------------Tatlılar----------------");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case

        //    Console.WriteLine("Lütfen ay girişi yapın:");
        //    int monthNumber = int.Parse(Console.ReadLine());

        //    switch (monthNumber)
        //    {

        //case 1: Console.Write("Ocak");break;
        //case 2: Console.Write("Şubat");break;
        //case 3: Console.Write("Mart");break;
        //case 4: Console.Write("Nisan");break;
        //case 5: Console.Write("Mayıs");break;
        //case 6: Console.Write("Haziran");break;
        //case 7: Console.Write("Temmuz");break;
        //case 8: Console.Write("Ağustos");break;
        //case 9: Console.Write("Eylül");break;
        //case 10: Console.Write("Ekim");break;
        //case 11: Console.Write("Kasım");break;
        //case 12: Console.Write("Aralık");break;
        
        //    default:Console.WriteLine("Hatalı veri girişi yapıldı.");break;

        //    }

            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;
            Console.Write("1. sayıyı giriniz:");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı giriniz:");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi girin:");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+': result = number1 + number2;
                    Console.WriteLine("Sonuç: " + result);break;

                case '-': result = number1 - number2;
                    Console.WriteLine("Sonuç: " + result);break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Sonuç: " + result);break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Sonuç: " + result);break;

            }

            #endregion

            Console.Read();
        }
    }
}
