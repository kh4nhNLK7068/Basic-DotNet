namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci(2);
        }

        static void SwapNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Fibonacci(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }
            int a = 0, b = 1, c;
            Console.Write("Fibonacci Series: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}
