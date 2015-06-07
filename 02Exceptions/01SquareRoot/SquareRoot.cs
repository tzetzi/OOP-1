using System;
class SquareRoot
{
    static void Main()
    {
        string str = Console.ReadLine();
        try
        {
            int num = int.Parse(str);
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine("You entered a valid Int32 number {0}.", str);
            double result = Math.Sqrt(num);
            Console.WriteLine("Square root:"+result);

        }
        catch (FormatException fe)
        {

            Console.Error.WriteLine("Invalid format of integer number!\n" + fe);
        }
        catch(ArgumentOutOfRangeException)
        {
            Console.Error.WriteLine("Integer number cannot take negative value {0}!");
        }
        catch (OverflowException)
        {
            Console.Error.WriteLine("The number is too big for Int32!");

        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}