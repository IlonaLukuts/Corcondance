using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Paragraph
    {
        public List<Sentence> ListOfSentences { private set; get; }
        public int CountOfSentences { get { return this.ListOfSentences.Count; } }

        public Paragraph()
        {
            this.ListOfSentences = new List<Sentence>();
        }

        public void Parsing(string line)
        {
            string stringSentence = null;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != '.' && line[i] != '!' && line[i] != '?')
                    stringSentence += line[i];
                else
                {
                    stringSentence += line[i];
                    if (i + 1 != line.Length)
                    {
                        if (line[i + 1] == ' ')
                        {
                            Sentence sentence = new Sentence();
                            sentence.Parsing(stringSentence);
                            this.ListOfSentences.Add(sentence);
                            stringSentence = null;
                            i++;
                        }
                    }
                    else
                    {
                        Sentence sentence = new Sentence();
                        sentence.Parsing(stringSentence);
                        this.ListOfSentences.Add(sentence);
                        stringSentence = null;
                    }
                }
            }
        }

        public override string ToString()
        {
            string paragraph = null;
            foreach(Sentence sentence in this.ListOfSentences)
            {
                paragraph += sentence.ToString();
                paragraph += ' ';
            }
            paragraph = paragraph.Remove(paragraph.Length - 1);
            return paragraph;
        }
    }
}
