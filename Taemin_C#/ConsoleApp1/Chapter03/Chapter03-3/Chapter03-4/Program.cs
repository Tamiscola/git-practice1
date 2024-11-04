namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        byte b = 250;
        short s = b;
        Console.WriteLine(s);  // output : 250

        ushort u = 65;
        char c = (char)u;
        Console.WriteLine(c);     // output : A

        short s1 = 25000;
        byte b1 = (byte)s1; // generates random number

        ushort u1 = 65;     // 0 ~ 65000
        char c1 = (char)u1;  // 정수형 -> 문자형일 경우 명시적 형변환만 허용
        Console.WriteLine(c1);

        
    }
}