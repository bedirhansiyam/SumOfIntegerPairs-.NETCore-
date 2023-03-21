namespace SumOfIntegerPairs;
class Program
{
    static void Main(string[] args)
    {
        bool isInt = true;
        List<int> numbers = new List<int>();

        Console.Write("Please enter space-separated integer pairs : ");

        do
        {
            string[] strNumbers = Console.ReadLine().Split(' ');

            if(strNumbers.Count() % 2 != 0)
            {
                Console.WriteLine("");
                Console.Write("Please only enter numbers in pairs and integers : ");
                isInt = false;
            }
            else
            {
                for (int i = 0; i < strNumbers.Count(); i++)
                {
                    isInt = int.TryParse(strNumbers[i], out int number);
                    if(isInt == false)
                    {
                        Console.WriteLine("");
                        Console.Write("Please only enter numbers in pairs and integers : ");
                        numbers.Clear();
                        break;
                    }
                    else
                        numbers.Add(number);
                }
            }
        } while (isInt == false);

        Console.WriteLine("");
        Console.Write("Result : ");

        for (int i = 0; i < numbers.Count; i +=2)
        {
            if(numbers[i] == numbers[i+1])
            {
                Console.Write(Math.Pow((numbers[i] * numbers[i+1]),2) + " ");
            }
            else
            {
                Console.Write((numbers[i] + numbers[i+1]) + " ");
            }
        }
    }
}
