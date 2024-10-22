using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables
            /* 
            double number;
            number = 4.85;
            Console.WriteLine(number);
        */
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;


            //Console.WriteLine("----- Apple Unit Price: " + applePrice + " ₺ ---> (" + appleGram + " gr)");
            //Console.WriteLine("----- Orange Unit Price: " + orangePrice + " ₺ ---> (" + orangeGram + " gr)");
            //Console.WriteLine("----- Strawberry Unit Price: " + strawberryPrice + " ₺ ---> (" + strawberryGram + " gr)");
            //Console.WriteLine("----- Potato Unit Price: " + potatoPrice + " ₺ ---> (" + potatoGram + " gr)");
            //Console.WriteLine("----- Tomato Unit Price: " + tomatoPrice + " ₺ ---> (" + tomatoGram + " gr)");


            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Product: Apple\t\t | " + "Unit Price:\t " + applePrice + "\t ₺" + " | " + "Quantity:\t " + appleGram + "\t kg" + " | " + "Total Price:\t " + appleTotalPrice + "\t₺");
            //Console.WriteLine("Product: Orange\t\t | " + "Unit Price:\t " + orangePrice + "\t ₺" + " | " + "Quantity:\t " + orangeGram + "\t kg" + " | " + "Total Price:\t " + orangeTotalPrice + "\t₺");
            //Console.WriteLine("Product: Strawberry\t | " + "Unit Price:\t " + strawberryPrice + "\t ₺" + " | " + "Quantity:\t " + strawberryGram + "\t kg" + " | " + "Total Price:\t " + strawberryTotalPrice + "\t\t₺");
            //Console.WriteLine("Product: Potato\t\t | " + "Unit Price:\t " + potatoPrice + "\t ₺" + " | " + "Quantity:\t " + potatoGram + "\t kg" + " | " + "Total Price:\t " + potatoTotalPrice + "\t₺");
            //Console.WriteLine("Product: Tomato\t\t | " + "Unit Price:\t " + tomatoPrice + "\t ₺" + " | " + "Quantity:\t " + tomatoGram + "\t kg" + " | " + "Total Price:\t " + tomatoTotalPrice + "\t₺");
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Total Amount of Shopping Cart: " + shoppingTotalPrice + " ₺");

            #endregion

            #region Char Variables

            /* // Sezar Şifreleme'yi araştır?
             char symbol;
             //symbol = "a"; Error! Cannot implicitly convert type 'string' to 'char'
             symbol = 'a';
             Console.WriteLine(symbol);*/


            #endregion

            #region Keyboard (Data Entry) - string

            /* Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi");
             Console.WriteLine();

             string passengerID, passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge;

             Console.Write("Yolcu ID: ");
             passengerID = Console.ReadLine();

             Console.Write("Yolcu Adı: ");
             passengerName = Console.ReadLine();

             Console.Write("Yolcu Soyadı: ");
             passengerSurname = Console.ReadLine();

             Console.Write("Şehir Bilgisi: ");
             passengerCity = Console.ReadLine();

             Console.Write("İlçe Bilgisi: ");
             passengerDistrict = Console.ReadLine();

             Console.Write("Yolcu Yaş: ");
             passengerAge = Console.ReadLine();

             Console.WriteLine();
             Console.WriteLine("-------------------------------------");
             Console.WriteLine("Yolcu: " + passengerID + "\n" + passengerName + " " + passengerSurname + "\n" + passengerDistrict + " / " + passengerCity + "\n" + passengerAge);*/



            #endregion

            #region Keyboard (Data Entry) - int

            /*int shoePrice, computerPrice, chairPrice, tvPrice;

            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());


            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());


            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());


            Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoePrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

            Console.WriteLine();
            Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);*/

            #endregion

            #region Keyboard (Data Entry) - double

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " +result);

            #endregion

            #region Keyboard (Data Entry) - char

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz:");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğinşiz Cinsiyet: " + gender);

            #endregion
        }
    }
}
