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
            #region basic array examples

            /*
                Aynı veri tipindeki çok sayıda veriyi bir arada tutmak için kullanılan yapılardır.

                2.4.6.8 --> çift sayılar
                sarı, kırmızı, mavi, turuncu, beyaz --> renkler
                adana, ankara, istanbul, bursa --> şehirler
                
                syntax --> değişkenTürü [] diziAdi = new değişkenTürü[elemanSayisi]

            */

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            // Console.WriteLine(cities[5]); Bu durumda dizi sınırlarının dışına çıktığı için run-time'da hata döner


            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            /*
             
                  Console.WriteLine(numbers[5]); // Bu durumda 10 elemanlı bir dizinin 5. indeksine değer ataması yapmadığımızda
                                                 // default olarak int türünde olduğu için 0 atanır.
            */

            /* 

                 string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
                 Console.WriteLine(cities[2]); // Atina

                 string[] cities1 = new string[5] { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
                 Console.WriteLine(cities1[4]); // Bursa

            */

            #endregion

            #region List all elements in array

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);

            //}
            #endregion

            #region  Find Max Number 
            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int max = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > max)
            //    {
            //        max = myArray[i];
            //    }

            //}

            //Console.WriteLine(max); 
            #endregion

            #region Array Methods

            // Length ---> İlgili dizinin uzunluğunu (kaç elemanlı olduğunu) döndürür.

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //-----------------------------------------------------------------------------------

            // Array.Sort ---> İlgili dizi içerisindeki elemanları küçükten büyüğe sıralar ( A -> Z )

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (i != numbers.Length - 1)
            //        Console.Write(numbers[i] + ", ");
            //    else
            //        Console.Write(numbers[i]);
            //}

            //-----------------------------------------------------------------------------------

            // Array.Reverse ---> İlgili dizi içerisindeki elemanları sondan başa doğru (tersine) yazar.

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };

            //Console.WriteLine("Reverse Fonsiyonundan önce: ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (i != numbers.Length - 1)
            //        Console.Write(numbers[i] + ", ");
            //    else
            //        Console.Write(numbers[i]);
            //}

            //Console.WriteLine("\n"); // iki satır boşluk bırakması için...

            //Array.Reverse(numbers);

            //Console.WriteLine("Reverse Fonsiyonundan sonra: ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (i != numbers.Length - 1)
            //        Console.Write(numbers[i] + ", ");
            //    else
            //        Console.Write(numbers[i]);
            //}

            //-----------------------------------------------------------------------------------

            // Sort & Reverse ile dizi içerisindeki elemanları büyükten küçüğe doğru ( Z -> A ) listeleyebiliriz.


            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers); // önce küçükten büyüğe ( A -> Z ) sıraladık.
            //Array.Reverse(numbers); // sonra tersine çevirip yazdırdık.

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (i != numbers.Length - 1)
            //        Console.Write(numbers[i] + ", ");
            //    else
            //        Console.Write(numbers[i]);
            //}

            //-----------------------------------------------------------------------------------

            // Array.IndexOf

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //for (int i = 0; i < customers.Length; i++)
            //{
            //    if (index == i)
            //    {
            //        Console.BackgroundColor = ConsoleColor.Green;
            //        Console.ForegroundColor = ConsoleColor.Black;
            //        Console.WriteLine(i + ". index'teki kişi = " + customers[i]);
            //        Console.BackgroundColor = ConsoleColor.Black;
            //        Console.ForegroundColor = ConsoleColor.White;
            //    }
            //    else
            //        Console.WriteLine(i + ". index'teki kişi = " + customers[i]);

            //}

            //-----------------------------------------------------------------------------------
            // Max,Min

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max());
            //Console.WriteLine("Dizinin En Küçük Elemanı: " + numbers.Min());

            #endregion

            #region Getting value from user

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{

            //    Console.Write("Lütfen bir şehir ismi giriniz: ");
            //    cities[i] = Console.ReadLine();
            //    if (i == cities.Length - 1)
            //    {
            //        Console.Write("Girdiğiniz şehirleri görmek için bir tuşa basın.");
            //        Console.ReadKey();
            //        Console.WriteLine("\n");
            //        for (int j = 0; j < cities.Length; j++)
            //        {
            //            Console.WriteLine(cities[j]);
            //        }

            //    }
            //}


            #endregion

            #region sum of all element's value in the array

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int toplam = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //    toplam += numbers[i];

            //Console.WriteLine($"Toplam = {toplam}");



            #endregion

            #region Example - 1 (List odd and even numbers in the array)

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            int evenCount = 0, oddCount = 0;

            Console.WriteLine("Even Numbers");
            Console.WriteLine("-------------------");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                    if (i != numbers.Length - 1)
                        Console.Write(numbers[i] + ", ");
                    else
                        Console.Write(numbers[i]);
                }
            }
            Console.Write($"\t({evenCount})");

            Console.WriteLine("\n");

            Console.WriteLine("Odd Numbers");
            Console.WriteLine("-------------------");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    oddCount++;
                    if (i != numbers.Length - 2)
                        Console.Write(numbers[i] + ", ");
                    else
                        Console.Write(numbers[i]);
                }
            }

            Console.Write($"\t({oddCount})");

            #endregion

            Console.Read();
        }
    }
}
