namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // expression lambda
            Func<int, int, string> sum = (int x, int y) => (x + y).ToString();
            Console.WriteLine(sum(5, 10)); // Output: 15

            // statement lambda
            var upper = (string s) => Console.WriteLine(s.ToUpper());
            upper("hello world"); // Output: HELLO WORLD

            Action<string> greet = (string name) =>
            {
                string greeting = $"Hello, {name}!";
                Console.WriteLine(greeting);
            };
            greet("Alice"); // Output: Hello, Alice!
        }
    }
}
