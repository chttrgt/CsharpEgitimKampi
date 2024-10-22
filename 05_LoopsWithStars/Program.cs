using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Always think simple!

            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 0; i < 10; i++)
            //{
            //   Console.WriteLine("*");

            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");

            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma ve her satırda 10 tane yıldız

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine("* ");

            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("* * * * * * * * * *");
            //}


            #endregion

            #region Dik Üçgen

            //for (int i = 0; i < 10; i++)
            //{

            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("x ");
            //    }
            //    Console.WriteLine("x");


            //}


            #endregion

            #region Ters Dik Üçgen - 1

            //for (int i = 0; i <10; i++)
            //{

            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (j < 10 - (i + 1))
            //        {
            //            Console.Write("  ");
            //        }
            //        else
            //        {
            //            Console.Write("x ");
            //        }

            //    }

            //    Console.WriteLine();

            //}

            #endregion

            #region Ters Dik Üçgen - 2

            //for (int i = 10; i >= 0; i--)
            //{

            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("x ");
            //    }
            //    Console.WriteLine();

            //}


            #endregion

            #region Baklava - 1

            //for (int i = 0; i < 10; i++)
            //{

            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (j < 10 - (i + 1))
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write("x ");
            //        }

            //    }

            //    Console.WriteLine();

            //}

            //for (int i =8; i >=0; i--)
            //{

            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (j < 10 - (i + 1))
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write("x ");
            //        }

            //    }

            //    Console.WriteLine();

            //}

            #endregion

            #region Baklava - 2


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5 - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 0; j < 2 * i - 1; j++)
            //    {
            //        Console.Write("x");
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 5 - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 0; j < 2 * i - 1; j++)
            //    {
            //        Console.Write("x");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5 - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 0; j < 2 * i - 1; j++)
            //    {
            //        Console.Write("x");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit


            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 5 - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 0; j < 2 * i - 1; j++)
            //    {
            //        Console.Write("x");
            //    }

            //    Console.WriteLine();
            //}

            #endregion
        }
    }
}
