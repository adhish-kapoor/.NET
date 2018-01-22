using System;
using System.IO;
namespace Readingfromfile
{
    class ReadFromFile
    {
        static void Main(string[] args)
        {
            try
            {
                // Read the file as one string.
                string text = File.ReadAllText(@"D:\myfolder\folder2\folder2.1\adhish.txt");

                // Display the file contents to the console. Variable text is a string.
                Console.WriteLine("Contents of WriteText.txt = {0}", text);
            }
            catch (FileNotFoundException fileNotFoundExp)
            {
                Console.WriteLine("File not found");
            }
            catch (FileLoadException fileLoadExp)
            {
                Console.WriteLine(fileLoadExp);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}
