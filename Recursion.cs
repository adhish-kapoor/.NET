using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            String file_name, folder_path;

            Console.WriteLine("Enter the file name you want to search whether it exists or not");

            folder_path = Console.ReadLine();
            file_name = Console.ReadLine();
            bool isFound = FileExists(folder_path, file_name);
            if (isFound == true)
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("File doesn't exists");
            }

            Console.ReadKey();
        }
        public static bool FileExists(string folderPath, string fileName)
        {
            Console.WriteLine(Path.Combine(folderPath, fileName));
            if (File.Exists(Path.Combine(folderPath, fileName)))
                return true;
            bool returnedValue = false;
            DirectoryInfo di = new DirectoryInfo(folderPath);

            List<DirectoryInfo> allDirectories = di.EnumerateDirectories().ToList();
            List<DirectoryInfo> directoriesToSearch = new List<DirectoryInfo>();
            foreach (var directory in allDirectories)
            {
                if ((directory.Attributes & FileAttributes.System) == 0)
                {
                    if (FileExists(directory.FullName, fileName))
                    {
                        returnedValue = true;
                        break;
                    }
                }
            }



            return returnedValue;
        }

    }
}
