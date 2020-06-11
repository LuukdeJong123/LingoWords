using LingoWords.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LingoWordsTest.DataTests
{
    [TestClass]
    public class FileWordRepositoryTests
    {
        private FileWordRepository wordRepository = new FileWordRepository();

        [TestMethod]
        public void TestReadAllWordsTrue()
        {
            Assert.IsTrue(wordRepository.ReadAllWords().Count > 1);
        }
        [TestMethod]
        public void TestReadAllWordsFalse()
        {
            Assert.IsFalse(wordRepository.ReadAllWords().Count == 0);
        }
    }
}
