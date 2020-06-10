using Microsoft.VisualStudio.TestTools.UnitTesting;
using LingoWords.Domain;
using LingoWords.Services;
using LingoWords.Controllers;
using LingoWords.Repositories;
using Moq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LingoWordsTest.ApplicationTests
{
    [TestClass]
    public class WordServiceUnitTest
    {
        private Mock wordRepository;
        private DutchWordsService wordsService;
        [TestInitialize]
        public void Setup()
        {
            wordRepository = new Mock<WordsRepository>();
            wordsService = new DutchWordsService(wordRepository.As<WordsRepository>().Object);
        }

        [TestMethod]
        public void TestCheckWordTrue()
        {
            Assert.AreEqual("taart", wordsService.checkWord("taart"));
        }
        [TestMethod]
        public void TestCheckWordFalse()
        {
            Assert.AreEqual("", wordsService.checkWord("123123"));
        }

        [TestMethod]
        public void TestCheckAllWordsTrue()
        {
            IList<Word> expectedList = new List<Word> {
                new Word("fiets",5,Language.Nederlands.ToString())
            };
            wordRepository.As<WordsRepository>().Setup(x => x.ReadAllWords()).Returns(expectedList);
            Assert.AreEqual(expectedList[0].word, wordsService.checkAllWords()[0].word);

        }
        [TestMethod]
        public void TestCheckAllWordsFalse()
        {
            IList<Word> expectedList = new List<Word> {
                new Word("fiets",5,Language.Nederlands.ToString())
            };
            IList<Word> wrongexpectedList = new List<Word> {
                new Word("taart",5,Language.Nederlands.ToString())
            };
            wordRepository.As<WordsRepository>().Setup(x => x.ReadAllWords()).Returns(expectedList);
            Assert.AreNotEqual(wrongexpectedList[0].word, wordsService.checkAllWords()[0].word);
        }



    }
}
