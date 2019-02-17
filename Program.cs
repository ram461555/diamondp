// C# code to print the pattern 
using System;
public class PatternD
{
    public static void pattern(int n)
    {

        for (int i = n; i <= n * 2; i++)
            Console.Write(" ");
            Console.WriteLine(1 + "");

        for (int i = 2; i <= (n * 2) - 1; i++)
        {

            if (i < n)
            {
                for (int j = 1; j <= (n - i) * 2; j++)
                    Console.Write(" ");
            }
            else
            {
                for (int j = 1; j <= (i % n) * 2; j++)
                    Console.Write(" ");
            }

            if (i < n)
            {
                for (int j = 1; j <= i % n; j++)
                    Console.Write(j + " ");
                for (int j = (i % n) - 1; j > 0; j--)
                    Console.Write(j + " ");

            }

            else if (i > n)
            {
                for (int j = 1; j <= n - (i - n); j++)
                    Console.Write(j + " ");

                for (int j = (n - (i - n)) - 1; j > 0; j--)
                    Console.Write(j + " ");

            }
            else
            {
                for (int j = 1; j <= n; j++)
                    Console.Write(j + " ");
                for (int j = n - 1; j > 0; j--)
                    Console.Write(j + " ");

            }
            Console.WriteLine();
        }

        for (int i = 1; i <= n * 2; i++)
            Console.Write(" ");

        Console.Write("Press any key to close the console app...");
        Console.ReadKey();
    }

    public static void Main()
    {
        int n;
        Console.Write("Input number of rows:");
        n = Convert.ToInt32(Console.ReadLine());
        pattern(n);
  
    }
}

