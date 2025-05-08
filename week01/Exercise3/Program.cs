using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List <int> num = new List<int>();
        int input;
        
        do
        {
            Console.Write("Please enter a number (0 to stop). ");
        input = int.Parse(Console.ReadLine());
        
        if (input != 0)
            {
                num.Add(input);
            }
        }
        while (input != 0);

        if (num.Count > 0)
            {
                int sum = num.Sum();
                int average = (int)num.Average();
                int max = num.Max();

                Console.WriteLine($"Numbers entered: {string.Join(",", num)}");
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Average {average}");
                Console.WriteLine($"Max {max}");
            }

    }
}