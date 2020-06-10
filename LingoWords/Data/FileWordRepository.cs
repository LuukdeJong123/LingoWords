using LingoWords.Domain;
using LingoWords.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LingoWords.Repositories
{
    public class FileWordRepository : WordsRepository
    {
        public IList<Word> ReadAllWords()
        {
            IList<Word> wordsList = new List<Word>();
            try
            {
                string[] fileText = File.ReadAllLines(@"C:\Users\Luuk\source\repos\LingoWords\LingoWords\basiswoorden-gekeurd.txt");
                foreach (string text in fileText)
                {
                    Word word = new Word(text);
                    wordsList.Add(word);
                }
                
            }
            catch(IOException ex)
            {
                //Exit the code
                Console.WriteLine(ex);
                Environment.Exit(0);
            }
            return wordsList;
        }
    }
}
