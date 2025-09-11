namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(10,24,50);
            Console.WriteLine(t1.ToString());
        }
        static void Problem2()
        {
            int NumOfStud = int.Parse(Console.ReadLine());
            int NumOfTracks = int.Parse(Console.ReadLine());
            int[,] arr = new int[NumOfTracks,NumOfStud];
            for (int i = 0; i < NumOfTracks; i++)
            {
                Console.WriteLine($"Enter Number Of Tracks{i+1}");
                for (int j = 0; j < NumOfStud; j++)
                {
                    Console.WriteLine($"Enter Number Of Students{i + 1}");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < NumOfTracks; i++)
            {
                for (int j = 0; j < NumOfStud; j++)
                {
                    Console.Write($"{arr[i,j]} , ");
                }
                Console.WriteLine();
            }
        }
        static void NamesOfStudent()
        {
            Console.WriteLine("Enter Size Of Array");
            int size = int.Parse(Console.ReadLine());
            string[] arr = new string[size];
            for (int i = 0; i < size; i++)
            {
                string x = Console.ReadLine();
                arr[i] = x;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
