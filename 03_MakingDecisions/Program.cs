using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If - Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password = Console.ReadLine();
            //if (password == "12345")
            //{
            //    Console.WriteLine("Şifre doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış!");
            //}

            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler doğrulandı!");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi!");
            //}


            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}


            //double exam1, exam2, exam3, avg;
            //string result = "";

            //Console.Write("Sınav-1: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Sınav-2: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Sınav-3: ");
            //exam3 = double.Parse(Console.ReadLine());

            //avg = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalması: " + avg);

            //if (avg > 0 & avg <= 50)
            //{
            //    result = "Sonuç vasat!";
            //}
            //if (avg > 50 & avg <= 70)
            //{
            //    result = "Sonuç orta!";
            //}
            //if (avg > 70 & avg <= 84)
            //{
            //    result = "Sonuç iyi!";
            //}
            //if (avg > 84)
            //{
            //    result = "Sonuç pekiyi!";
            //}

            //Console.WriteLine(result);

            //string city;

            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");

            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil!");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{

            //    Console.WriteLine("Bu kullanıcı kabul edilemez!");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz!");
            //}


            #endregion

            #region  Mod İşlemleri

            //int number;
            //number = 26;
            //int res = number % 5;
            //Console.WriteLine(res);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int res = number1 % number2;

            //Console.WriteLine("1.sayının 2.sayıya bölümünden kalan: " + res);

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı çift sayıdır!");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı tek sayıdır!");
            //}
            #endregion

            #region Using If-Else eith char variables

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'G' | team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if (team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //} 
            #endregion

            #region Örnek Proje Uygulaması (Menu)

            /*
            
            Console.WriteLine("****** C# Eğitim kampıo Restorant ******");
            Console.WriteLine();
            Console.WriteLine("---------------- ~MENU~ ----------------");
            Console.WriteLine("\t1- Ana Yemekler");
            Console.WriteLine("\t2- Çorbalar");
            Console.WriteLine("\t3- Pizzalar");
            Console.WriteLine("\t4- İçecekler");
            Console.WriteLine("\t5- Tatlılar");
            Console.WriteLine("----------------------------------------");

            string menuItem;
            Console.Write("Yukarıdaki menu'den bir seçim yapabilirsiniz (Çıkış:h/H): ");

            menuItem = Console.ReadLine().Substring(0, 1);

            if (menuItem == "H" | menuItem == "h") return;
            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("--- ~Ana Yemekler~ ---");
                Console.WriteLine("1-Köri Soslu Tavuk");
                Console.WriteLine("2-Kızartma Tabağı");
                Console.WriteLine("3-Fasulye Pilav");
                Console.WriteLine("4-Fırında Somon");
                Console.WriteLine("5-Patlıcan Musakka");
                Console.WriteLine("----------------------");
            }
            else if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("----- ~Çorbalar~ -----");
                Console.WriteLine("1-Mercimek Çorbası");
                Console.WriteLine("2-Ezogelin Çorbası");
                Console.WriteLine("3-Tavuksuyu Çorbası");
                Console.WriteLine("4-İşkembe");
                Console.WriteLine("5-Kelle-Paça");
                Console.WriteLine("----------------------");
            }
            else if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("----- ~Pizzalar~ -----");
                Console.WriteLine("1-Akdeniz Pizza");
                Console.WriteLine("2-Margaritha");
                Console.WriteLine("3-Tavuklu Pizza");
                Console.WriteLine("4-Sucuklu Pizza");
                Console.WriteLine("5-Karışık Pizza");
                Console.WriteLine("----------------------");
            }
            else if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("--- ~İçecekler~ ---");
                Console.WriteLine("1-Limonata");
                Console.WriteLine("2-Ayran");
                Console.WriteLine("3-Gazoz");
                Console.WriteLine("4-Soda");
                Console.WriteLine("5-Su");
                Console.WriteLine("-------------------");
            }
            else if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("--- ~Tatlılar~ ---");
                Console.WriteLine("1-Tiriliçe");
                Console.WriteLine("2-Kazandibi");
                Console.WriteLine("3-Sütlaç");
                Console.WriteLine("4-Antep Baklava");
                Console.WriteLine("5-Soğuk Baklava");
                Console.WriteLine("------------------");
            }
            else
            {
                Console.WriteLine("Sadece menude olan yemeklerden seçim yapabilirsiniz!");
            }
            
             */



            #endregion

            #region Switch-Case

            //Console.Write("Lütfen Ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default:
            //        Console.Write("Lütfen 1-12 arası bir değer giriniz!");
            //        break;
            //}


            #endregion

            #region Switch-Case (Hesap Makinesi)

            //int num1, num2, res;
            //char symbol;

            //Console.Write("1. sayıyı giriniz: ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz: ");
            //num2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz (+,-,x,/,%): ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        res = num1 + num2;
            //        Console.Write(res);
            //        break;

            //    case '-':
            //        res = num1 - num2;
            //        Console.Write(res);
            //        break;
            //    case 'x':
            //        res = num1 * num2;
            //        Console.Write(res);
            //        break;

            //    case '/':
            //        res = num1 / num2;
            //        Console.Write(res);
            //        break;

            //    case '%':
            //        res = num1 % num2;
            //        Console.Write(res);
            //        break;

            //    default:
            //        Console.Write("Yanlış bir operator seçtiniz!");
            //        break;
            //}

            #endregion
        }
    }
}
