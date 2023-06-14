using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace examen_14._06._2023
{
    interface IWord
    {
        string GetWord();
        uint GetWordCount { get; }
    }
    
    class WordFrequence : IWord
    {
        private string word;
        private uint count;
    
        public WordFrequence(string word)
        {
            this.word = word;
            this.count = 0;
        }
    
        public string GetWord()
        {
            return RemovePunctuation(word);
        }
    
        public uint GetWordCount => count;
    
        public override string ToString()
        {
            return $"{GetWord()}: {GetWordCount}";
        }
    
        public static WordFrequence operator ++(WordFrequence word)
        {
            word.count++;
            return word;
        }
        
        private string RemovePunctuation(string input)
        {
            return new string(input.Where(c => !char.IsPunctuation(c)).ToArray());
        }
    }

    class DictionaryFrequence
    {
        private readonly Dictionary<string, int> aw;
    
        public DictionaryFrequence()
        {
            aw = new Dictionary<string, int>();
        }
    
        public void ReadFromFile(string filename)
        {
            string text = File.ReadAllText(filename);
            string[] words = text.Split(GetDelimiterChars(), StringSplitOptions.RemoveEmptyEntries);
    
            foreach (string word in words)
            {
                string cleanedWord = RemovePunctuation(word);
                AddWordToDictionary(cleanedWord);
            }
        }
    
        private void AddWordToDictionary(string word)
        {
            if (aw.ContainsKey(word))
            {
                aw[word]++;
            }
            else
            {
                aw[word] = 1;
            }
        }
    
        public void SaveResultsToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"Загальна кількість слів у файлі: {aw.Values.Sum()}");
    
                foreach (KeyValuePair<string, int> entry in aw)
                {
                    writer.WriteLine($"{entry.Key} : {entry.Value}");
                }
            }
        }
    
        public void Print()
        {
            foreach (KeyValuePair<string, int> entry in aw)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }
        }
    
        public WordFrequence[] ToWordFrequence()
        {
            WordFrequence[] wordFrequencies = new WordFrequence[aw.Count];
            int index = 0;
    
            foreach (KeyValuePair<string, int> entry in aw)
            {
                wordFrequencies[index] = new WordFrequence(entry.Key);
                for (int i = 0; i < entry.Value; i++)
                {
                    wordFrequencies[index]++;
                }
                index++;
            }
    
            return wordFrequencies;
        }
        
    
        private string RemovePunctuation(string input)
        {
            return new string(input.Where(c => !char.IsPunctuation(c)).ToArray());
        }
        
        private char[] GetDelimiterChars()
        {
            char[] delimiters = { (char)DelimiterChars.Space, (char)DelimiterChars.Dot, (char)DelimiterChars.Semicolon, (char)DelimiterChars.NewLine, (char)DelimiterChars.Tire };
            return delimiters;
        }
        
        enum DelimiterChars
        {
            Space = ' ',     
            Dot = '.',       
            Semicolon = ';', 
            NewLine = '\n',
            Tire = '-'
        }
    }

    internal abstract class Program
    {
        static void Main()
        {
            
            string text = "Lorem ipsum dolor sit amet, quis nostrum exercitationem ullam corporis suscipit laboriosam, qui dolorem ipsum, quia dolor sit, amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt, ut labore et dolore magnam aliquam quaerat voluptatem?\n" +
                          "Lorem ipsum dolor sit amet, quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem...";

            if (!File.Exists("input.txt"))
            {
                File.Create("input.txt").Close();
            }
            
            using (StreamWriter writer = new StreamWriter("input.txt"))
            {
                writer.Write(text);
            }

            DictionaryFrequence dictFreq = new DictionaryFrequence();
            
            dictFreq.ReadFromFile("input.txt");
            
            Console.WriteLine("Word Frequencies:");
            dictFreq.Print();
            
            dictFreq.SaveResultsToFile("output.txt");
            
            WordFrequence[] wordFreqArray = dictFreq.ToWordFrequence();

            Console.WriteLine("Word Frequencies as WordFrequence objects:");
            foreach (WordFrequence wordFreq in wordFreqArray)
            {
                Console.WriteLine(wordFreq);
            }

            Console.ReadLine();
        }
    }
}