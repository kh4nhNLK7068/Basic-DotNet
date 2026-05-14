using System.Text;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //f();
            //f1();

            //Collection pratice
            List<string> names = new List<string>();

            ReadString(names);
            Print(names);
            Sort(names);
            Print(names);
        }

        private static void Sort(List<string> names)
        {
            names.Sort();
        }

        private static void Print(List<string> names)
        {
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("");
        }

        private static void ReadString(List<string> names)
        {
            // use command: /bin/Debug/net8.0/HelloWorld.exe < input.txt
            string? s;
            do
            {
                s = Console.ReadLine();
                if (!string.IsNullOrEmpty(s))
                {
                    names.Add(s);
                }
            }
            while (!string.IsNullOrEmpty(s));

            /*
            string inputPath = @"input.txt";
            var lines = File.OpenRead(inputPath);
            using (var reader = new StreamReader(lines, Encoding.UTF8))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        names.Add(line);
                    }
                }
            }
            */
        }

        static void f()
        {
            //int[,] _2DArr =
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};
            //Console.WriteLine(_2DArr[1, 1]);

            int[,,] _3DArr =
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                {
                    { 10, 11, 12 },
                    { 13, 14, 15 },
                    { 16, 17, 18 }
                },
                {
                    { 19, 20, 21 },
                    { 22, 23, 24 },
                    { 25, 26, 27 }
                }
            };
            Console.WriteLine(_3DArr[1, 1, 1]);
        }

        static void f1()
        {
            int[][] mn = new int[3][];
            mn[0] = new int[] { 1, 2, 3 };

            Console.WriteLine(mn[0][1]); // Valid
            Console.WriteLine(mn[1][2]); // Invalid, mn[1] is null and will throw a NullReferenceException
        }
    }
}
