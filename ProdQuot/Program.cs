using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQuot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rnd = new Random();
                decimal x, y, prod, quot, rndquot;

                /* 2 random numbers are generated. These 2 numbers are first multiplied and then the first number is 
                 * divided by the second number and rounded to 2 decimal places */

                for (int counter = 0; counter < 10; counter++)
                {
                    x = rnd.Next(0, 11);
                    y = rnd.Next(0, 11);
                    prod = x * y;
                    quot = x / y;
                    rndquot = Math.Round(quot, 2);
                    Console.WriteLine("The product of x * y is " + prod);
                    Console.WriteLine("The quotient of x / y is " + rndquot.ToString("0.00"));
                    Console.WriteLine();
                }
            }

            catch (DivideByZeroException divZEx)
            {
                Console.WriteLine("Divide By Zero Exception Caught!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception Thrown " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

