using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Punctuation
    {
        private char sign;
        public bool EndSign { private set; get; }

        public Punctuation(char sign)
        {
            this.sign = sign;
            SetEndSign();
        }

        private void SetEndSign()
        {
            switch(this.sign)
            {
                case '.': this.EndSign = true;break;
                case '?': this.EndSign = true; break;
                case '!': this.EndSign = true; break;
                default: this.EndSign = false;break;
            }
        }

        public override string ToString()
        {
            return this.sign.ToString();
        }
    }
}
