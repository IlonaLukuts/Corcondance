using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Tests
{
    [TestClass()]
    public class SentenceTests
    {
        [TestMethod()]
        public void ParsingTest()
        {
            string stringSentence = "Hello, World; How are you?";
            Sentence sentence = new Sentence();
            sentence.Parsing(stringSentence);
            string expected = "Hello, World; How are you?";
            string actual = sentence.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CompareToTest()
        {
            string stringSentence1 = "Hello, World!";
            string stringSentence2 = "How are you?";
            Sentence sentence1 = new Sentence();
            sentence1.Parsing(stringSentence1);
            Sentence sentence2 = new Sentence();
            sentence2.Parsing(stringSentence2);
            int expected = -1;
            int actual = sentence1.CompareTo(sentence2);
            Assert.AreEqual(expected, actual);
        }
    }
}