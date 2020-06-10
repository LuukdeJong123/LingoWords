using Microsoft.VisualStudio.TestTools.UnitTesting;
using LingoWords.Domain;
using Moq;
using System.Collections;
using System.Collections.Generic;

namespace LingoWordsTest.DomainTests
{
    [TestClass]
    public class WordUnitTest
    {
        [TestMethod]
        public void TestWordTrue()
        {
            Word word = new Word("fiets", 5, Language.Nederlands.ToString());
            Assert.AreEqual("fiets", word.word);
            Assert.AreEqual(5, word.length);
            Assert.AreEqual("Nederlands", word.language);
        }

        [TestMethod]
        public void TestWordFalse()
        {
            Word word = new Word("fiets", 5, Language.Nederlands.ToString());
            Assert.AreNotEqual("fsets", word.word);
            Assert.AreNotEqual(4, word.length);
            Assert.AreNotEqual("Engels", word.language);
        }
        [TestMethod]
        public void TestWordConstructorTrue()
        {
            Word word = new Word("fiets");
            Assert.AreEqual("fiets", word.word);
        }
        [TestMethod]
        public void TestWordConstructorFalse()
        {
            Word word = new Word("fiets");
            Assert.AreNotEqual("fsets", word.word);
        }

    }
}
