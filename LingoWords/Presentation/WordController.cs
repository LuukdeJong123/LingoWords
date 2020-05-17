using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LingoWords.Domain;
using LingoWords.Repositories;
using LingoWords.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LingoWords.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordController : ControllerBase
    {
        WordService wordService;
        public WordController(WordService _wordService)
        {
            wordService = _wordService;
        }

        [HttpGet]
        public IList<Word> Get()
        {
            return wordService.checkAllWords();
        }
    }
}
