using LingoWords.Domain;
using LingoWords.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LingoWords.Repositories
{
    public interface WordsRepository
    {
        IList<Word> ReadAllWords();
    }
}
