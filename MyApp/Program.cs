using Microsoft.VisualBasic;
using NumberGuessGame;
using PseudoTextGenerator;
using System.Text;






//zavd1


namespace _even_numbers
{
    class Numbers
    {
        private int _myNumber;
        public int myNumber
        {
            get
            {
                return _myNumber;
            }
            set
            {
                if (value % 2 == 0)
                {
                    _myNumber = value;
                }
                else
                {
                    Console.WriteLine("Number is not even");
                }
            }
        }

        public void ShowNum()
        {
            Console.WriteLine($"Even number: {myNumber}");
        }

        public Numbers(int evenNumber)
        {
            myNumber = evenNumber;
        }
    }
}











namespace _odd_numbers
{
    public class Numbers
    {
        private int _myNumber;
        public int myNumber
        {
            get
            {
                return _myNumber;
            }
            set
            {
                if (value % 2 != 0)
                {
                    _myNumber = value;
                }
                else
                {
                    Console.WriteLine("Number is not odd");
                }
            }
        }

        public Numbers(int oddNumber)
        {
            myNumber = oddNumber;
        }

        public void ShowNum()
        {
            Console.WriteLine($"Odd number: {myNumber}");
        }
    }
}










namespace _fibonacci_numbers
{
    public class Numbers
    {
        private int _myNumber;

        public int myNumber
        {
            get { return _myNumber; }
            set
            {
                if (IsFibonacci(value))
                {
                    _myNumber = value;
                }
                else
                {
                    Console.WriteLine("Number is not a Fibonacci number");
                }
            }
        }

        public Numbers(int fibonacciNumber)
        {
            myNumber = fibonacciNumber;
        }

        public void ShowNum()
        {
            Console.WriteLine($"Fibonacci number: {myNumber}");
        }

        private bool IsFibonacci(int n)
        {
            return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
        }

        private bool IsPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return s * s == x;
        }
    }
}













//zavd2


namespace _triangle
{
    class Figure
    {
        public string MySymbol { get; set; }

        public Figure(string symbol)
        {
            MySymbol = symbol;
        }

        public void PrintFigure()
        {
            Console.WriteLine($"{MySymbol}");
            Console.WriteLine($"{MySymbol}\t{MySymbol}");
            Console.WriteLine($"{MySymbol}\t\t{MySymbol}");
            Console.WriteLine($"{MySymbol}\t\t\t{MySymbol}");
            Console.WriteLine($"{MySymbol}\t{MySymbol}\t{MySymbol}");
        }
    }
}











namespace _rectangle
{
    class Figure
    {
        public string MySymbol { get; set; }

        public Figure(string symbol)
        {
            MySymbol = symbol;
        }

        public void PrintFigure()
        {
            Console.WriteLine($"{MySymbol}{MySymbol}{MySymbol}{MySymbol}{MySymbol}{MySymbol}{MySymbol}{MySymbol}");
            Console.WriteLine($"{MySymbol}{MySymbol}{MySymbol}{MySymbol}{MySymbol}{MySymbol}{MySymbol}{MySymbol}");
            Console.WriteLine($"{MySymbol}{MySymbol}{MySymbol}{MySymbol}{MySymbol}{MySymbol}{MySymbol}{MySymbol}");
        }
    }
}

namespace _square
{
    class Figure
    {
        public string MySymbol { get; set; }

        public Figure(string symbol)
        {
            MySymbol = symbol;
        }

        public void PrintFigure()
        {
            Console.WriteLine($"{MySymbol}{MySymbol}{MySymbol}{MySymbol}");
            Console.WriteLine($"{MySymbol}{MySymbol}{MySymbol}{MySymbol}");
            Console.WriteLine($"{MySymbol}{MySymbol}{MySymbol}{MySymbol}");
        }
    }
}
















//zavd3


namespace NumberGuessGame
{
    public class Game
    {
        private int min;
        private int max;

        public Game(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public void Run()
        {
            Console.WriteLine("Think of a number within a certain range");
            Console.WriteLine("Enter the minimum number: ");
            Console.WriteLine("Enter the maximum number: ");
            Console.WriteLine("Think of a number in your mind, and computer will try to guess it");
            int attempts = 0;
            bool guessed = false;

            while (!guessed && min <= max)
            {
                int guess = (min + max) / 2;
                attempts++;
                Console.WriteLine($"Attempt #{attempts}: Is your number {guess}?");

                Console.WriteLine("Respond with: '=' - correct, '<' - too high, '>' - too low");
                string response = Console.ReadLine();

                if (response == "=")
                {
                    Console.WriteLine($"The computer guessed your number {guess} in {attempts} attempts");
                    guessed = true;
                }
                else if (response == "<")
                {
                    max = guess - 1;
                }
                else if (response == ">")
                {
                    min = guess + 1;
                }
                else
                {
                    Console.WriteLine("Invalid response");
                }
            }

            if (!guessed)
            {
                Console.WriteLine("Something went wrong or you changed your number");
            }

            Console.WriteLine();
        }
    }
}











//zavd4


namespace PseudoTextGenerator
{
    public class Generator
    {
        private int vowelCount;
        private int consonantCount;
        private int maxLength;


        private static readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        private static readonly char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

        public Generator(int vowelCount, int consonantCount, int maxLength)
        {
            this.vowelCount = vowelCount;
            this.consonantCount = consonantCount;
            this.maxLength = maxLength;
        }

        public void Generate()
        {
            string word = GenerateWord(vowelCount, consonantCount, maxLength);
            Console.WriteLine($"Generated word: {word}");
        }

        private static string GenerateWord(int vowelsNum, int consonantsNum, int maxLen)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < vowelsNum && sb.Length < maxLen; i++)
                sb.Append(vowels[rnd.Next(vowels.Length)]);

            for (int i = 0; i < consonantsNum && sb.Length < maxLen; i++)
                sb.Append(consonants[rnd.Next(consonants.Length)]);

            char[] chars = sb.ToString().ToCharArray();
            for (int i = chars.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                (chars[i], chars[j]) = (chars[j], chars[i]);
            }

            return new string(chars);
        }
    }
}
















namespace csharp_namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zavd 1


            _even_numbers.Numbers num = new _even_numbers.Numbers(4);
            num.ShowNum();

            _odd_numbers.Numbers num2 = new _odd_numbers.Numbers(7);
            num2.ShowNum();

            _fibonacci_numbers.Numbers num3 = new _fibonacci_numbers.Numbers(144);
            num3.ShowNum();











            //zavd2



            _triangle.Figure triangle = new _triangle.Figure("#");
            triangle.PrintFigure();

            Console.WriteLine();

            _rectangle.Figure rectangle = new _rectangle.Figure("*");
            rectangle.PrintFigure();

            Console.WriteLine();

            _square.Figure square = new _square.Figure("*");
            square.PrintFigure();











            //zavd 3


            Console.WriteLine("Enter the minimum number: ");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the maximum number: ");
            int max = int.Parse(Console.ReadLine());

            Game guessGame = new Game(min, max);
            guessGame.Run();






            //zavd 4


            Console.WriteLine("Enter number of vowels: ");
            int vowels = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of consonants: ");
            int consonants = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter max word length: ");
            int maxLength = int.Parse(Console.ReadLine());

            Generator generator = new Generator(vowels, consonants, maxLength);
            generator.Generate();
        }
    }
}
