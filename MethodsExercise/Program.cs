using System.Net.NetworkInformation;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int added = Add(2, 2);
            Console.WriteLine(added);

            int subtracted = Subtract(10, 5);
            Console.WriteLine(subtracted);

            int mult = Multiply(2, 5);
            Console.WriteLine(mult);

            int div = Divide(4, 2);
            Console.WriteLine(div);

            MadLib();
        }

        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("What is a name for a dog?");
            string dogName = Console.ReadLine();
            Console.WriteLine("What color is your dog?");
            string dogColor = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}. He was {age} years old.");
            Console.WriteLine($"He had a {dogColor} dog named {dogName}");
            Console.WriteLine($"{userName} loved {dogName}. But he hated being {age}.");


            Console.WriteLine("Gime a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");
        }
        public static int Sum(params int[] list)
        {
            int sum = 0;

            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;

        }
       
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return (num1 - num2);
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {  
            return (num1 / num2);
        }
    }
}
