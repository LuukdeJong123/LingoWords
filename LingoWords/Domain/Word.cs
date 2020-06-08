using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LingoWords.Domain
{
    public class Word
    {
        public string word { get; }
        public int length { get; }
        public string language { get; }

        public Word(string _word)
        {
            word = _word;
        }
        public Word(string _word, int _length, string _language)
        {
            word = _word;
            length = _length;
            language = _language;
        }
    }
}
