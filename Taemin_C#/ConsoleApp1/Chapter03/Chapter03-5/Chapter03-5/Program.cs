namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        // null 키워드 사용하기
        string? text = null;  // ? : null 사용하겠다는 표시, 메모리 효율적 사용 가능
        int? a1 = 1;
        a1 = null;

        Console.WriteLine($"a1: {a1}");

        bool result = false;
        int n = 0;
        string t = "asd";
        Console.WriteLine($"{result} {n} {t}");

        int x1 = 3 / 2;
        Console.WriteLine(x1);

        double x2 = 3 / 2;
        Console.WriteLine(x2);

        double x3 = 3 / 2.0;
        Console.WriteLine(x3);

        double x4 = 3 / (double)2;
        Console.WriteLine(x4);

    }
}