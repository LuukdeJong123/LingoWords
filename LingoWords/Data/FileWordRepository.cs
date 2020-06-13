using LingoWords.Domain;
using LingoWords.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
                string[] fileText = File.ReadAllLines(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+ "/basisworden-gekeurd.txt");
                foreach (string text in fileText)
                {
                    Word word = new Word(text);
                    wordsList.Add(word);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex);
            }
            return wordsList;
        }
    }
}
