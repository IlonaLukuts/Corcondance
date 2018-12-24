using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Text
    {
        private List<Paragraph> listOfParagraphs;
        public int CountOfParagraphs { get { return this.listOfParagraphs.Count; } }

        public Text()
        {
            this.listOfParagraphs = new List<Paragraph>();
        }

        public void Parsing(string line)
        {
            string[] splitStrings = line.Split('\n','\r');
            foreach (string s in splitStrings)
            {
                if (s != "")
                {
                    Paragraph paragraph = new Paragraph();
                    paragraph.Parsing(s);
                    this.listOfParagraphs.Add(paragraph);
                }
            }
        }

        public override string ToString()
        {
            string text = null;
            foreach(Paragraph paragraph in this.listOfParagraphs)
            {
                text += paragraph.ToString();
                text += '\n';
            }
            text = text.Remove(text.Length - 1);
            return text;
        }

        public List<string> SortSentences()
        {
            List<Sentence> sentences = new List<Sentence>();
            foreach(Paragraph paragraph in this.listOfParagraphs)
            {
                sentences.AddRange(paragraph.ListOfSentences);
            }
            sentences.Sort();
            List<string> stringSentences = new List<string>();
            foreach (Sentence sentence in sentences)
            {
                stringSentences.Add(sentence.ToString());
            }
            return stringSentences;
        }
    }
}
