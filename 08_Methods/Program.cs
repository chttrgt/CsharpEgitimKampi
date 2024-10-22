using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parametresiz geriye değer döndürmeyen metodlar (void)

            /*
                //()
               // Customer --> liste,ekle,sil,güncelle



                //void CustomerList()
                //{
                //    Console.WriteLine("Ali Yıldız");
                //    Console.WriteLine("Ayşe Yıldız");
                //    Console.WriteLine("Hakan Öztürk");
                //    Console.WriteLine("Merve Çınar");

                //}
                //CustomerList(); // Metodu çarğırmamız gerek

            */

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();



            #endregion

            #region Parametreli geriye değer döndürmeyen metodlar (void)

            // String Parametreli....................

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");


            // Int parametreli..............................

            //void Sum(int number1, int number2, int number3)
            //{
            //    int res = number1 + number2 + number3;
            //    Console.WriteLine(res);
            //}

            //Sum(4, 5, 6);


            #endregion

            #region Geriye değer döndüren metodlar (parametresiz & parametreli)

            // Parametresiz Kullanım...................

            //string CustomerCard()
            //{
            //    return "Buse Yıldız";
            //}
            ////Console.WriteLine(CustomerCard()); // ya da

            //string name = CustomerCard();
            //Console.WriteLine(name);

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());


            // Parametreli Kullanım...................

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;

            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));


            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int res = (exam1 + exam2 + exam3) / 3;
                if (res >= 50)
                {
                    return student + " isimli öğrenci " + res + " ortalma ile sınavı geçti!";
                }
                else
                {
                    return student + " isimli öğrenci " + res + " ortalma ile başarısız oldu!";
                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 21, 85));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));

            #endregion

            Console.Read();
        }
    }
}
