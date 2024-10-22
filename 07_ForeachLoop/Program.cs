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
            #region Foreach Loop

            /*
                Foreach döngüsü 4 parametreli bir yapıya sahiptir.
                    Foreach(1,2,3,4)
                    
                    1: Değişken Türü
                    2: Değişken Adı
                    3: In
                    4: Liste, Koleksiyon, Dizi
                 
            */

            /* string dizisi içerisindeki elemanları yazdırma... */

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            /* int dizisi içerisindeki elemanları yazdırma... */

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            /* dizi içindeki çift sayıları bulmak... */

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }

            //}

            /* dizi içerisindeki elemanların toplamını almak... */

            //int toplam = 0;
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    toplam += number;

            //}

            //Console.WriteLine(toplam);


            //List<int> numbers = new List<int>() {

            //    1,2, 3, 4, 5, 6, 7, 8, 9, 10,

            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);

            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı sınav Uygulaması *****");
            Console.WriteLine("\n");

            //Sınıftaki öğrenci sayısını kullanıcıdan alma...
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler...
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;
                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sonav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }

                Console.WriteLine();

                studentExamAvg[i] = totalExamResult / 3;
            }


            // Sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması: {studentExamAvg[i]}");
                // Öğrencilerin ortalaması ve geçip kalma durumları...

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti");
                }
                else
                {

                    Console.WriteLine($"{studentNames[i]} isimli öğrenci ders'ten kaldı.");
                }
            }



            #endregion

            Console.Read();
        }
    }
}
