using LingoWords.Domain;
using LingoWords.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LingoWords.Services
{
    public class DutchWordsService : WordService
    {
        WordsRepository fileRepository;
        
        public DutchWordsService(WordsRepository _fileRepository)
        {
            fileRepository = _fileRepository;
        }

        public IList<Word> checkAllWords()
        {
            Language language = Language.Nederlands;
            IList<Word> wordsList = new List<Word>();
            foreach (Word text in fileRepository.ReadAllWords())
            {
                string checkedWord = checkWord(text.word);
                if (checkedWord != "")
                {
                    Word word = new Word(checkedWord, checkedWord.Length, language.ToString());
                    wordsList.Add(word);
                }
            }
            return wordsList;
        }

        public string checkWord(string text)
        {
            Match m = Regex.Match(text, @"^[a-z]{5,7}$");
            return m.Value;
        }
    }
}
