using System;

namespace ExceptionExampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();

        }//end of main method

        static void Method1 ()
        {
            Method2();
        }

        static void Method2()
        {
            try
            {
                Method3();
            } catch (Exception ex)
            {
                Console.WriteLine("The exception is caught here...");
            }
        }
        static void Method3()
        {
            var n = 1;
            var d = 0;
            var x = n / d;
        }

    }//end of class
}
