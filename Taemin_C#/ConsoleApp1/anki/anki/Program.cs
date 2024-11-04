namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
       Random random = new Random();
        int[] lottoNumbers = new int[6];

        int lottoIndex = 0;

        while (lottoIndex < 6)
        {
            int lottoNumber = random.Next(1, 46);
            int checkIndex = 0;
            bool isDuplicate = false;

            while (checkIndex < lottoIndex)
            {
                if (lottoNumber == lottoNumbers[checkIndex])
                {
                    isDuplicate = true;
                    break;
                }

                checkIndex++;
            }

            if (isDuplicate == false)
            {
                lottoNumbers[lottoIndex] = lottoNumber;
                lottoIndex++;
            }
        }

        
        
        lottoIndex = 0;

        while (lottoIndex < lottoNumbers.Length)
        {
            int count = 1;

            while (count < lottoNumbers.Length)
            {
                if (lottoNumbers[count] < lottoNumbers[count - 1])
                {
                    int temp = lottoNumbers[count - 1];
                    lottoNumbers[count - 1] = lottoNumbers[count];
                    lottoNumbers[count] = temp;

                }

                count++;
            }
            lottoIndex++;
        }

            
        

        Console.WriteLine($"Generated lotto Numbers : {string.Join(", ", lottoNumbers)}");
    }
}