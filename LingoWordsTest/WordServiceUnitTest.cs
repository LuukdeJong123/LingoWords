using Microsoft.VisualStudio.TestTools.UnitTesting;
using LingoWords.Domain;
using LingoWords.Services;
using LingoWords.Controllers;
using LingoWords.Repositories;
using Moq;
using System.Collections;
using System.Collections.Generic;

namespace LingoWordsTest
{
    [TestClass]
    public class WordServiceUnitTest
    {
        private Mock mockRepository = new Mock<WordsRepository>();

        [TestMethod]
        public void TestCheckAllWordsMethod()
        {
            var mockService = new Mock<WordService>();

            mockService.Setup(x => x.checkAllWords());

        }
        [TestMethod]
        public void TestCheckWordMethod()
        {
            
            //Assert.AreEqual("taart",wordService.checkWord("taart"));

            //var iets = mockService.Setup(x => x.checkWord("taart")).Returns("taart");
        }


    }
}
