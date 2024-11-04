namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int[] productPrices = new int[4];
        string[] productNames = new string[4];

        productPrices[0] = 5000;
        productPrices[1] = 5500;
        productPrices[2] = 6000;
        productPrices[3] = 10000;

        Console.WriteLine(productPrices[1]);

        int[] products = new int[5] { 1, 2, 3, 4, 5 };
        int[] products2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        int[] products3 = { 1, 2, 3};

        

        string text = "Hello World";
        char ch1 = text[0];
        char ch10 = text[10];
        

        Console.WriteLine(ch1);
        Console.WriteLine(ch10);
        

        int[] students = new int[60];
        Console.WriteLine(students[0]);   //  output : 0
        float[] sosu = new float[60];
        Console.WriteLine(sosu[0]);    // output : 0

        // multi-dimensional array

        int[,] arr2 = new int[3, 10];
        int[,,] arr3 = new int[4, 3, 10];

        // jagged array (가변 배열)

        int[][] arr5 = new int[3][]; // 3 rows with varying columns
        arr5[0] = new int[10];   // 10 columns
        arr5[1] = new int[8];    // 8 columns
        arr5[2] = new int[9];     // 9 columns

        // arr6의 평균값을 출력하는 코드(소수점까지 표시)
        int[] arr6 = { 1, 2, 3, 4, 5, 6 };
        float result = arr6.Sum() / arr6.Length;
        float result2 = (arr6[0] + arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5]) / 6f;
        double result3 = (arr6[0] + arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5]) / 6d;
        double result4 = (arr6[0] + arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5]) / 6.0;
        double result5 = (double)(arr6[0] + arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5]) / 6;


        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
        Console.WriteLine(result5);




    }
}