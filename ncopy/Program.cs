namespace ncopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var source = @"C:\Users\ADMIN\Downloads\gitlab-recovery-codes.txt";
            var destination = @"C:\Users\ADMIN\Downloads\gitlab-recovery-codes-copy.txt";

            // Define the buffer size as needed,
            // if the file size is larger than this buffer,
            // it will read and write in chunks (> 1 times).
            var buffer = new byte[1024]; // 1KB buffer
            var instream = File.OpenRead(source);
            var outstream = File.OpenWrite(destination);
            // using var outstream = File.OpenWrite(destination);

            int n = instream.Read(buffer, 0, buffer.Length);
            while (n > 0)
            {
                Console.WriteLine($"Read {n} bytes from source.");
                outstream.Write(buffer, 0, n);
                n = instream.Read(buffer, 0, buffer.Length);
            }
            instream.Close(); // if using 'using', this is not needed as it will be automatically disposed.
            outstream.Close(); // the same applies here.
        }
    }
}
