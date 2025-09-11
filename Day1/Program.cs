namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();
            Problem6();
        }
        static void Problem6()
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine("==============");
            }
        }
        static void Problem5()
        {
            int x = int.Parse(Console.ReadLine());
            if (x >= 85) Console.WriteLine("Excellent");
            else if (x >= 70) Console.WriteLine("VeryGood");
            else if (x >= 60) Console.WriteLine("Good");
            else if (x >= 50) Console.WriteLine("Acceptable");
            else Console.WriteLine("Failed");
        }
        static void Problem4()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int Sum = x + y;
            int Sub = x - y;
            int Mul = x * y;
            Console.WriteLine($"Sum = {Sum}");
            Console.WriteLine($"Subtraction = {Sub}");
            Console.WriteLine($"Multiplication = {Mul}");
        }
        static void Problem3()
        {
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} Is Even");
            }
            else
            {
                Console.WriteLine($"{x} Is Odd");
            }
        }
        static void Problem2()
        {
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine((char)ch);
        }
        static void Problem1()
        {
            // prob.1
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine((int)ch);
        }
    }
}
