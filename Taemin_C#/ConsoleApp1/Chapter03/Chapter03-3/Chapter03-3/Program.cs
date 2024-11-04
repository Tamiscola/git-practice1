namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        char ch = 'A';
        string str1 = "A";
        string str2 = "school";

        Console.WriteLine(str1);
        Console.WriteLine(str2);
        Console.WriteLine(ch);

        // tab
        char ch1 = '\t';

        char ch2 = 'T';
        // New Line
        char ch3 = '\n';

        char ch4 = 'o';

        Console.Write(ch1);
        Console.Write(ch2);
        Console.Write(ch3);
        Console.Write(ch4);

        Console.WriteLine();// 한 줄 띄우기

        char ch5 = '\u00AE';    // ®
        Console.WriteLine(ch5);

        string ch6 = "▶";
        Console.WriteLine(ch6);

        string ch7 = "\\";  // \
        Console.WriteLine(ch7);

        string ch8 = "\"Hello world\"";     //  "Hello world"
        Console.WriteLine(ch8);

        string ch9 = @"\tHello world\t";    //  \tHello world\t
        Console.WriteLine(ch9);

        string str10 = "Hello";
        Console.WriteLine(str10 + " " + "World");   // concatenation : Hello World

        string str11 = "Hello" + " " + "World";
        Console.WriteLine(str11);

        bool b1= true;
        Console.WriteLine($"b1의 값은 {b1} 이다.");
    }
}