namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        /*int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i <= n; i += 1) 
        {
            sum += i;
        }
        Console.WriteLine(sum);


        // Q2

        for (int i = 1; i <= 9; i += 1)
        {
            Console.WriteLine($"5 x {i} = {5 * i}");
        }

        // Q3

        int[] numbers = { 3, 5, 7, 9, 11, 13 };
        sum = 0;

        for (int i = 0; i < numbers.Length; i += 1) { sum += numbers[i];}
        Console.WriteLine(sum);

        // Q4

        string text1 = "안녕하세요";
        Console.WriteLine(text1);

        for (int i = 0; i < text1.Length; i += 1)
        {
            Console.WriteLine(text1[i]);
        }

        // Q5

        for (int i = text1.Length - 1; i >= 0; i -= 1) { Console.Write(text1[i]); }
        */

        // Q6

        for (int i = 1; i <= 50; i += 1) 
        {
            if (i % 3 == 0)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }

                Console.WriteLine("Fizz");
                continue;
            }
            else if (i % 5 == 0) 
                    {
            Console.WriteLine("Buzz");
                continue;
        }

            Console.WriteLine(i);
        }

    }
}