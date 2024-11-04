// float 실수형 기본 타입
// 1) float : 2^32 (4 byte)
// 2) double : 2^64 (8 byte)
// 3) decimal 2^128 (16 byte)

namespace ConsoleApp1;

class Program       // collapse 가능 (접기)
{
    static void Main(string[] args)
    {
        float f = 5.2f;
        double d = 10.5;
        decimal money = 200.099m;

        Console.WriteLine(money);
        Console.WriteLine(d);
        Console.WriteLine(f);

        // Q1
        ushort age = 25;
        Console.WriteLine(age);
        float height = 175.5f;

        //Q2 : 아래 코드에서 오류 찾아 수정
        int num = 300;
        float result = num + 100.5f;
    }
}