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
    public class ParagraphTests
    {
        [TestMethod()]
        public void ParsingTest()
        {
            string stringParagraph = "Hello, World! How are you? Bye.";
            Paragraph paragraph = new Paragraph();
            paragraph.Parsing(stringParagraph);
            string expected = "Hello, World! How are you? Bye.";
            string actual = paragraph.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}