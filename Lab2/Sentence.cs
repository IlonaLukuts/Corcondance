using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Sentence : IComparable<Sentence>
    {
        private List<Word> listOfWords;
        private Dictionary<Word, Punctuation> listOfSigns;
        private List<Punctuation> listOfEndSigns;
        public int CountOfWords { get { return this.listOfWords.Count; } }

        public Sentence()
        {
            this.listOfWords = new List<Word>();
            this.listOfSigns = new Dictionary<Word, Punctuation>();
            this.listOfEndSigns = new List<Punctuation>();
        }

        public void Parsing (string line)
        {
            string[] splitWords = line.Split(' ');
            foreach(string s in splitWords)
            {
                int i = s.Length - 1;
                for (;i>-1;i--)
                {
                    if ((s[i] >= 'A' && s[i] <= 'Z') ||
                        (s[i] >= 'a' && s[i] <= 'z') ||
                        (s[i] >= 'А' && s[i] <= 'Я') ||
                        (s[i] >= 'а' && s[i] <= 'я') ||
                        (s[i] >= '0' && s[i] <= '9'))
                        break;
                }
                if (i == s.Length - 1)
                {
                    Word word = new Word(s);
                    this.listOfWords.Add(word);
                }
                else
                {
                    i++;
                    string onlyWord = s.Remove(i);
                    Word word = new Word(onlyWord);
                    this.listOfWords.Add(word);
                    for (;i< s.Length;i++)
                    {
                        Punctuation sign = new Punctuation(s[i]);
                        if (!sign.EndSign)
                            this.listOfSigns.Add(word, sign);
                        else this.listOfEndSigns.Add(sign);
                    }
                }
            }
        }

        public int CompareTo(Sentence other)
        {
            if (this.CountOfWords > other.CountOfWords)
                return 1;
            else
                if (this.CountOfWords < other.CountOfWords)
                return -1;
            return 0;
        }

        public override string ToString()
        {
            string sentence = null;
            foreach (Word w in this.listOfWords)
            {
                sentence += w.ToString();
                if (this.listOfSigns.ContainsKey(w))
                    sentence += this.listOfSigns[w].ToString();
                sentence += ' ';
            }
            sentence = sentence.Remove(sentence.Length-1);
            foreach(Punctuation p in this.listOfEndSigns)
            {
                sentence += p.ToString();
            }
            return sentence;
        }
    }
}
