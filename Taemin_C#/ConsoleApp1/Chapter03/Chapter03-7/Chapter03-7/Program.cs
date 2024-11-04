namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // Control Statement
        bool result = 10 > 20;
        Console.WriteLine(result);

        int value1 = 6;
        int n1 = value1 % 3;
        bool result3 = n1 != 6;
        Console.WriteLine(result3);

        int value2 = 10;
        int n3 = value2 % 3;
        int n4 = value2 % 5;

        bool orResult1 = (n3 == 0) && (n4 == 0);
        Console.WriteLine(orResult1);

        //
        int n11 = 6;
        int n12 = 10;
        bool result11 = n11 % 3 == 0 || n12 % 3 == 0;
        Console.WriteLine(result11);

        // 다음 조건을 만족하는 논리 연산을 사용하여 맞으면 'true' 출력, 틀리면 'false'
        // 조건 : 변수 age가 70 이상, hasLicense가 True 일 경우 운전 가능 틀리면 운전 불가
        int age = 40;
        bool hasLicense = true;

        bool answer1 = age >= 70 && hasLicense;
        Console.WriteLine(answer1);

       


        //2: 아래변수 isWeekend와 isHoliday 중 하나라도 true 일 경우 true를 출력 아니면 false를 출력
        bool isWeekend = false;
        bool isHoliday = true;

        bool answer2 = isWeekend || isHoliday;
        Console.WriteLine(answer2);

        //3: 아래 변수를 사용하여 두 조건을 모두 만족할 때 true 아니면 false
        // temperature 20이상 30이하
        //
        int temperature = 25;
        bool isRainy = false;

        bool answer3 = (temperature >= 20 && temperature <= 30) && isRainy;
        Console.WriteLine(answer3);

    }
}