namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            if (args.Length > 0)
            {
                Console.WriteLine("Arguments:");
                foreach (var arg in args)
                {
                    Console.WriteLine(arg);
                }
            }

            var s = Console.ReadLine();
            if (int.TryParse(s, out var result))
            {
                Console.WriteLine($"You entered the number: {result}");
            }
            else
            {
                Console.WriteLine("That's not a valid number.");

            }

            //Create Solve quadratic equations 
            Console.WriteLine("Enter coefficients a, b, c for the equation ax^2 + bx + c = 0:");
            var input = Console.ReadLine();
            var coefficients = input.Split(' ').Select(double.Parse).ToArray();
            var a = coefficients[0];
            var b = coefficients[1];
            var c = coefficients[2];
            var discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                var root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                var root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Two real roots: {root1} and {root2}");
            }
            else if (discriminant == 0)
            {
                var root = -b / (2 * a);
                Console.WriteLine($"One real root: {root}");
            }
            else
            {
                Console.WriteLine("No real roots.");
            }
        }
    }
}
