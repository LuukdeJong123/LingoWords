using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LingoWords.Repositories
{
    public interface WordsRepository
    {
        List<string> ReadAllWords();

    }
}
