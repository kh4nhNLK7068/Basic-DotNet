namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    int result = 10 / n;

                    Console.WriteLine($"Result: {result}");

                    // throw new Exception("This is a custom exception.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message} \n" + ex.ToString()); // Line 12
                    // throw new Exception("This is a custom exception.");
                    throw ex;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("This block will always execute.");
                }
            }
            catch (Exception ex)
            {
                //If only throw; is used in Line 12, the stack trace will be preserved, and it will show the original location of the exception.
                //If throw ex; is used, the stack trace will be reset to the current location (Line 12 to Line 22), which can make it harder to debug.
                Console.WriteLine($"Caught in outer catch: {ex}"); // Line 22 (with throw ex;)
            }

        }
    }
}
