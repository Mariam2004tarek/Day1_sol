namespace Day7
{
    #region prob1
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    public class AnonymousObjectExample
    {
        public static Product CreateProduct()
        {
            return new Product("Laptop", 1200.50);
        }

        public static void print()
        {
            Product myProduct = CreateProduct();

            Console.WriteLine($"NAme = {myProduct.Name}, Price= {myProduct.Price}");
        }
    }
    #endregion

    #region prob2
    public static class StringEx
    {
        public static int WordCount(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            return str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static void print()
        {
            string sentence1 = "Hello, world!";
            string sentence2 = "This is a sentence with five words.";
            string sentence3 = " One, two, three. ";
            string sentence4 = "";
            string sentence5 = null;

            Console.WriteLine($"'{sentence1}' has {sentence1.WordCount()} words.");
            Console.WriteLine($"'{sentence2}' has {sentence2.WordCount()} words.");
            Console.WriteLine($"'{sentence3}' has {sentence3.WordCount()} words.");
            Console.WriteLine($"'{sentence4}' has {sentence4.WordCount()} words.");
            Console.WriteLine($"'{sentence5}' has {sentence5.WordCount()} words.");
        }
    }
    #endregion

    #region prob3
    public static class IntegerEx
    {
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }
        public static void print()
        {
            int number1 = 4;
            int number2 = 7;
            int number3 = 0;
            int number4 = -10;
            Console.WriteLine($"Is {number1} even? {number1.IsEven()}");
            Console.WriteLine($"Is {number2} even? {number2.IsEven()}");
            Console.WriteLine($"Is {number3} even? {number3.IsEven()}");
            Console.WriteLine($"Is {number4} even? {number4.IsEven()}");
        }
    }
    #endregion

    #region prob4
    public static class DateTimeEx
    {
        public static int CalculateAge(this DateTime birthdate)
        {
            var today = DateTime.Today;

            var age = today.Year - birthdate.Year;
            if (birthdate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    
        public static void print()
        {
            var birthdate1 = new DateTime(1995, 9, 21); 
            var birthdate2 = new DateTime(1990, 12, 15); 
            var birthdate3 = new DateTime(2005, 9, 23); 

            Console.WriteLine($"Birthdate: {birthdate1.ToShortDateString()}, Age: {birthdate1.CalculateAge()}");
            Console.WriteLine($"Birthdate: {birthdate2.ToShortDateString()}, Age: {birthdate2.CalculateAge()}");
            Console.WriteLine($"Birthdate: {birthdate3.ToShortDateString()}, Age: {birthdate3.CalculateAge()}");
        }
    }
    #endregion

    #region prob5
    public static class StringReverse
    {
        public static string Reverse(this string str)
        {
            if (str == null)
            {
                return null;
            }

            char[] charArray = str.ToCharArray();

            Array.Reverse(charArray);
            return new string(charArray);
        }
    

        public static void print()
        {
            string text1 = "hello";
            string text2 = "world";
            string text3 = "C# is fun";
            string text4 = "";
            string text5 = null;
            Console.WriteLine($"Original: '{text1}' -> Reversed: '{text1.Reverse()}'");
            Console.WriteLine($"Original: '{text2}' -> Reversed: '{text2.Reverse()}'");
            Console.WriteLine($"Original: '{text3}' -> Reversed: '{text3.Reverse()}'");
            Console.WriteLine($"Original: '{text4}' -> Reversed: '{text4.Reverse()}'");
            Console.WriteLine($"Original: '{text5}' -> Reversed: '{text5.Reverse()}'");
        }
    }
    #endregion

    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }



}
