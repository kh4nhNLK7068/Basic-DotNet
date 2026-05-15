namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // expression lambda
            Func<int, int, string> sum = (int x, int y) => (x + y).ToString();
            Console.WriteLine(sum(5, 10)); // Output: 15

            var upper = (string s) => Console.WriteLine(s.ToUpper());
            upper("hello world"); // Output: HELLO WORLD

            Action<int> print = x => Console.WriteLine(x);

            // statement lambda
            Func<int, int> square2 = x => { return x * 2; };

            Action<string, string> greet = (string name, string sex) =>
            {
                string greeting = $"Hello, {name} - {sex}!";
                Console.WriteLine(greeting);
            };
            greet("Alice", "female"); // Output: Hello, Alice - female!
        }
    }
}
