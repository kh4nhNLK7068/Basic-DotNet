namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                int result = 10 / n;

                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message} \n" + ex.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("This block will always execute.");
            }
        }
    }
}
