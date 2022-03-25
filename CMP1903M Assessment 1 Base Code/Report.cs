using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        private string s;
        private List<string> _content;
        private List<string> _longWords;
        public Report(List<string> fileContent, List<int> values, List<string> longWords)
        {
            s = String.Format("1. Number of sentences: {0}\n2. Number of vowels: {1}\n3. Number of consonants: {2}\n4. Number of upper case letters: {3}\n5. Number of lower case letters: {4}", values[0], values[1], values[2], values[3], values[4]);
            _content = fileContent;
            _longWords = longWords;
            _content.Add(s);

        }
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void outputFile()
        {
            string path = Directory.GetCurrentDirectory();
            string fileName = "\\textAnalysis.txt";
            File.WriteAllLines(path+fileName, _content);
            outputLongWords(path);
        }

        private void outputLongWords(string path)
        {
            File.WriteAllLines(path + "\\longWords.txt", _longWords);
        }

        public void outputConsole()
        {
            foreach(string value in _content)
            {
                Console.WriteLine(value);
            }                       
        }
    }
}
