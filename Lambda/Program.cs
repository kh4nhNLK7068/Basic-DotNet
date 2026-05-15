namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // === expression lambda ===
            Func<int, int, string> sum = (int x, int y) => (x + y).ToString();
            Console.WriteLine(sum(5, 10)); // Output: 15

            var upper = (string s) => Console.WriteLine(s.ToUpper());
            upper("hello world"); // Output: HELLO WORLD

            Action<int> print = x => Console.WriteLine(x);
            // expression lambda with dynamic return type
            var t = object (int a, int b) => a > b ? 0 : "A";

            // === statement lambda ===
            Func<int, int> square2 = x => { return x * 2; };

            Action<string, string> greet = (string name, string sex) =>
            {
                string greeting = $"Hello, {name} - {sex}!";
                Console.WriteLine(greeting);
            };
            greet("Alice", "female"); // Output: Hello, Alice - female!

            // return multiple value types
            Func<int, int, (int sum, int product)> calculate = (x, y) =>
            {
                int sum = x + y;
                int product = x * y;
                return (sum, product);
            };

            // call the function and deconstruct the result
            Call((x, y) => x * y, 5, 10); // Output: 50

            int[] arr = { 100, 200, 300, 400, 500, 300 };
            Call1(x => x > 300, arr); // Output: 400 500

           FindNumIndex(x => x == 300, arr); // Output: Index: 2, Value: 300
        }

        static void Call(Func<int, int, int> f, int a, int b)
        {
            Console.WriteLine(f(a,b));
        }
        
        static void Call1(Func<int, bool> f, int[] arr)
        {
            foreach (var a in arr)
            {
                if (f(a))
                {
                    Console.Write(a + " ");
                }
            }
        }

        static void FindNumIndex(Func<int, bool> f, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (f(arr[i]))
                {
                    Console.WriteLine($"\nIndex: {i}, Value: {arr[i]}");
                }
            }
        }
    }
}
