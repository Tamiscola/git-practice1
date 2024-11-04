namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // 자료형 변수명 = value (값)
        int n;                  // just declaring variable n
        long sum;

        int a = 50000000;       // assigning value into variable a
        long b = 100;

        int n1 = 50;
        int n2;
        n2 = 100;

        n = 5;
        sum = 50;

        sum = n1 + n2; // 50 + 100 = 100    overwriting variable sum
        sum = 14;       // deleting n1 + n2 , overwriting again

        Console.WriteLine(sum);     // output : 14

        // int, long등 기본 타입에 대한 C#의 별칭(class)
        // ex) int -> System.Int32
        //     uint -> System.Uint32

        System.Int32 c1 = 30;
        System.Int32 c2;
        c2 = 100;

        System.Int32 sum2 = c1 + c2;
        Console.WriteLine(sum2);
    }
}