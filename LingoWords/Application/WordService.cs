using LingoWords.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LingoWords.Services
{
    public interface WordService
    {
        IList<Word> checkAllWords();

    }
}
