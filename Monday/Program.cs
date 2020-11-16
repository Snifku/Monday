using System;
using System.IO;

namespace Monday
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";
            GetDirectories(rootPath);
        }

        public static void GetDirectories(string Path)
        {
            string[] allDirectories = Directory.GetDirectories(Path, "*", SearchOption.AllDirectories);
            string filePath = @"C:\Users\opilane\Monday\directoriesData.txt";

            File.WriteAllLines(filePath, allDirectories);
        }
            public static void GetFiles(string path)
        {
            string[] allFiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            string filepath = @"C:\Users\opilane\Monday\filesData.txt";
            File.WriteAllLines(filepath, allFiles);
        }
        
    }
}
