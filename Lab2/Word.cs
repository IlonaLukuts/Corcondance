using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Word
    {
        private string oneWord;
        public int Length { get { return this.oneWord.Length; } }
        public Word(string word)
        {
            this.oneWord = word;
        }

        public override string ToString()
        {
            return this.oneWord;
        }

    }
}
