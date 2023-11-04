namespace lab3
{
    internal class Program
    {
        static bool IsPalindrome(string word)
        {
            for(int i = 0; i < word.Length - 1; i++)
            {
                if (word[(word.Length - 1) - i] != word[i])
                {
                    return false;
                }
            }
            return true;
        }
        static void DisplayList(List<int> arr)
        {
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static List<int> ToPrimeFactors(int number)
        {
            List<int> result = new List<int>();
            int temp = number;
            int i = 2;
            while(temp != 1)
            {
                if(temp % i == 0)
                {
                    result.Add(i);
                    temp = temp / i;
                    continue;
                }
                i++;
            }
            return result;
        }
        static void Calculator()
        {
            bool exit = false;
            while(exit != true)
            {
                Console.WriteLine("1 - Dodawanie");
                Console.WriteLine("2 - Odejmowanie");
                Console.WriteLine("Q - wyjdz");
                Console.Write("Co chcesz zrobic?: ");
                string? operation = Console.ReadLine();
                if(operation == "Q")
                {
                    exit = true;
                    break;
                }
                Console.Write("Podaj 1 liczbe: ");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.Write("Podaj 2 liczbe: ");
                int num2 = Int32.Parse(Console.ReadLine());
                switch (operation)
                {
                    case "1":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "2":
                        Console.WriteLine(num1 - num2);
                        break;
                }
            }
        }
        static double Convert(string number, int system)
        {
            double result = 0;
            char[] chars = { 'A', 'B', 'C', 'D', 'E', 'F' };
            for(int i = 0; i < number.Length; i++)
            {
                int num1 = 0;
                if (chars.Contains(number[i]))
                {
                    switch (number[i])
                    {
                        case 'A':
                            num1 = 10;
                            break;
                        case 'B':
                            num1 = 11;
                            break;
                        case 'C':
                            num1 = 12;
                            break;
                        case 'D':
                            num1 = 13;
                            break;
                        case 'E':
                            num1 = 14;
                            break;
                        case 'F':
                            num1 = 15;
                            break;
                    }
                    result += num1 * Math.Pow(system, number.Length - i - 1);
                    continue;
                }
                num1 = Int32.Parse(number[i].ToString());
                result += num1 * Math.Pow(system, number.Length - i - 1);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Convert("AF3", 16));
        }
    }
}