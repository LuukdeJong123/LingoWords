using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LingoWords.Domain
{
    public class Word
    {
        public string word { get; }
        public int lenght { get; }
        public string language { get; }

        public Word(string _word)
        {
            word = _word;
        }
        public Word(string _word, int _lenght, string _language)
        {
            word = _word;
            lenght = _lenght;
            language = _language;
        }
    }
}
