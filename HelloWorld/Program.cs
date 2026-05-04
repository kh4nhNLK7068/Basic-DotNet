using System.Text;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = $"Hello, World! \n\r\t with {DateTime.Now} \n";
            string s2 = "Hello, World 2!";

            StringBuilder sb1 = new StringBuilder();
            sb1.Append(s1);
            sb1.Append(s2);

            Console.WriteLine(sb1.ToString());

            var x = "";
        }
    }
}
