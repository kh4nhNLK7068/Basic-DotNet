namespace FindNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindNum();
        }

        static void FindNum()
        {
            int[] arr = new int[10];

            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next() % 1000;
            }

            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine("\n Enter a number to find: ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case int n when arr.Contains(n):
                    // Get index of the number in the array
                    int index = Array.IndexOf(arr, n);
                    Console.WriteLine("Number found in the array at index: " + index);
                    break;
                default:
                    Console.WriteLine("Number not found in the array.");
                    break;
            }

            //Bubble Sort the array
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }

            return;
        }
    }
}
