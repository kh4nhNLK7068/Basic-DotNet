namespace ndir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var path = "C:\\Users\\ADMIN\\Downloads";

            /// summary
            /// This method returns an array of strings,
            /// where each string is the path of a subdirectory within the specified directory (in this case, "C:\\Users\\ADMIN\\Downloads").
            /// The GetDirectories method is part of the System.IO namespace and is used to retrieve the names of subdirectories in a specified directory.
            /// 
            /// Do not get other information. Then using DirectoryInfo class to get the directories.
            //var directories = Directory.GetDirectories(path);


            /// summary
            /// return type: DirectoryInfo[]
            var dir = new DirectoryInfo(path);
            var directories = dir.GetDirectories();

            // dir command fake output
            foreach (var d in directories)
            {
                Console.WriteLine($"{d.LastWriteTime:MM/dd/yyyy} {d.LastWriteTime.ToString("HH:mm")}     <DIR>    {d.Name}");
            }

            /// summary
            /// return type: FileInfo[]
            /// The GetFiles method of the DirectoryInfo class returns an array of FileInfo objects, 
            /// where each FileInfo object represents a file in the specified directory. 
            /// Each FileInfo object contains information about the file, such as its name, size, and last write time.
            // dir fake output
            var files = dir.GetFiles();
            foreach (var f in files)
            {
                Console.WriteLine($"{f.LastWriteTime:MM/dd/yyyy} {f.LastWriteTime.ToString("HH:mm")}     {f.Length:#,###}    {f.Name}");
            }
            */
            displayDirectoryStructureInTreeFormat("C:\\LK's Workspace\\CMC\\learn");
        }

        static void displayDirectoryStructureInTreeFormat(string path, string indent = "")
        {
            var dir = new DirectoryInfo(path);
            var directories = dir.GetDirectories();
            var files = dir.GetFiles();
            foreach (var d in directories)
            {
                Console.WriteLine($"{indent}├── {d.Name}");
                displayDirectoryStructureInTreeFormat(d.FullName, indent + "│   ");
            }
            foreach (var f in files)
            {
                Console.WriteLine($"{indent}├── {f.Name}");
            }
        }
    }
}
