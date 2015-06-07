using System;

/*
 * Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. If the user enters an invalid number, let the user to enter again.
 */
namespace _02EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            int counter = 1;
            int start = 1;
            string input = Console.ReadLine();
            while (counter<=10)
	        {
                try
                {
                    int n = int.Parse(input);
                    ReadNumber(start,n);
                    counter++;
                    start = n;
                }
                catch (FormatException fe)
                {
                    Console.Error.WriteLine("{0}", fe.Message);

                }
                catch (ArgumentOutOfRangeException outRange)
                {
                    Console.Error.WriteLine("The input number has to be in range [{0}..100]\n {1}",start, outRange.ParamName);
                }
                finally
                {
                    Console.WriteLine("Enter new number in  range [{0}..100]:",start);
                    input = Console.ReadLine();
                }
            }
        }

        private static void ReadNumber(int start, int n)
        {
            if (n<=start || n>=100)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
