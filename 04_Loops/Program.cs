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
            #region for loop

            /*
                int i;
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine(i+1 + "- C# Eğitim Kampı");
                }
            */


            //string @value;
            //int count;

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz ifadeyi yazınız: ");
            //@value = Console.ReadLine();
            //Console.Write("Lütfen kaç kere yazılmasını istediğiniz adedi giriniz: ");
            //count = int.Parse(Console.ReadLine());

            //for (int i = 0; i < count; i++)
            //{

            //    Console.WriteLine(i + 1 + "- " + @value);
            //}


            #endregion

            #region for loop using with making decisions

            //for (int i = 0; i < 100; i++)
            //{

            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int total = 0;
            //Console.WriteLine("i  total  sonuç");
            //Console.WriteLine("----------------------");

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("{0} + {1} = {2}", i, total, total + i);
            //    total += i;

            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        total += i;
            //        Console.WriteLine(i);    
            //    }

            //}

            //Console.WriteLine(total);

            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        total++;
            //        Console.WriteLine(i);
            //    }

            //}

            //Console.WriteLine(total);

            /* 
                Bir bakteri türü her saat sonunda kendini 2 ye bölerek çoğalıyor, yeni oluşan bakteriler de aynı şekilde çoğalıyorlar.
                24 saat'in sonunda toplam kaç bakteri olacağını hesaplayan programı yazınız?
             */

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saatin sonunda oluşan bakteri sayısı= " + bacterium);
            //}


            #endregion

            #region while loop

            //int i = 0;

            //while (i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;

            //}

            //int i = 1, sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;

            //}

            //Console.WriteLine(sum);


            #endregion

            #region Question-1

            // Klavyeden girilen 3 basamaklı bir sayının basamakları toplamını hesaplayan kodu yazınız?

            //int sayi, birler = 0, onlar = 0, yuzler = 0;
            //Console.Write("lütfen 3 basamaklı bir sayı giriniz: ");
            //sayi = int.Parse(Console.ReadLine());
            //do
            //{
            //    birler = sayi % 10;
            //    onlar = (sayi / 10) % 10;
            //    yuzler = (sayi / 100);
            //    Console.WriteLine("{0} - {1} - {2} = {3}", yuzler, onlar, birler, (birler + onlar + yuzler));
            //    return;
            //}
            //while (true);

            #endregion
        }
    }
}
