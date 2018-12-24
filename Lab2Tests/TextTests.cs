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
    public class TextTests
    {
        [TestMethod()]
        public void ParsingTest()
        {
            string stringText = "Hello, World!\r\nHow are you? Bye.";
            Text text = new Text();
            text.Parsing(stringText);
            string expected = "Hello, World!\nHow are you? Bye.";
            string actual = text.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SortSentencesTest()
        {
            string stringText = "Hello, World!\r\nHow are you? Bye.";
            Text text = new Text();
            text.Parsing(stringText);
            List<string> expected = new List<string>();
            expected.Add("Bye.");
            expected.Add("Hello, World!");
            expected.Add("How are you?");
            List<string> actual = text.SortSentences();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}