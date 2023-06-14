using System;
using System.IO;

namespace dz20_7._06._2023
{
    
    class ProcessFile
    {
        public int ReplaceWordToFile(string filename, string oldWord, string newWord)
        {
            string fileContent = File.ReadAllText(filename);
            string newContent = fileContent.Replace(oldWord, newWord);
            File.WriteAllText(filename, newContent);

            int occurrences = 0;
            int lastIndex = -1;

            while ((lastIndex = newContent.IndexOf(newWord, lastIndex + 1)) != -1)
            {
                occurrences++;
            }

            return occurrences;
        }

        public int GetNOccurs(string filename, char c)
        {
            string fileContent = File.ReadAllText(filename);

            int occurrences = 0;
            foreach (char character in fileContent)
            {
                if (character == c)
                {
                    occurrences++;
                }
            }

            return occurrences;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProcessFile myClass = new ProcessFile();

            string filename = "myFile.txt";
            string oldWord = "old";
            string newWord = "new";
            
            if (!File.Exists(filename))
            {
                File.WriteAllText(filename, "old old old");
            }
            
            int replaceCount = myClass.ReplaceWordToFile(filename, oldWord, newWord);
            Console.WriteLine("Кількість замін: " + replaceCount);

            char character = 'o';

            int occurrences = myClass.GetNOccurs(filename, character);
            Console.WriteLine("Кількість входжень символу '{0}': {1}", character, occurrences);

            Console.ReadLine();
        }
    }
}