namespace _5.Folder_Size___Lab
{
    using System.Linq;
    using System.IO;

    public class FolderSize
    {
        public static void Main()
        {
            var totalLength = Directory.GetFiles(@"../../TestFolder")
                .Select(f => new FileInfo(f))
                .Sum(f => f.Length / 1024.0 / 1024.0)
                .ToString();

            File.WriteAllText(@"../../Output.txt", totalLength);
        }
    }
}
