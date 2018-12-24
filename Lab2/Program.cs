using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "input.txt";
            string line;
            using (StreamReader fileStream = new StreamReader(file))
            {
                line = fileStream.ReadToEnd();
            }

            Text text = new Text();
            text.Parsing(line);
            Console.WriteLine(text.ToString()+'\n');
            Console.WriteLine("Sorted sentences: ");
            List<string> sentences = text.SortSentences();
            foreach (string s in sentences)
                Console.WriteLine(s);
        }
    }
}
