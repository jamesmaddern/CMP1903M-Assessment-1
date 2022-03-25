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
        /// <summary>
        /// Creates a report object.
        /// </summary>
        /// <param name="fileContent">The List of sentences.</param>
        /// <param name="values">A list of measurements of the Analysed content</param>
        /// <param name="longWords">A list of long words.</param>
        public Report(List<string> fileContent, List<int> values, List<string> longWords)
        {
            s = String.Format("1. Number of sentences: {0}\n2. Number of vowels: {1}\n3. Number of consonants: {2}\n4. Number of upper case letters: {3}\n5. Number of lower case letters: {4}", values[0], values[1], values[2], values[3], values[4]);
            _content = fileContent;
            _longWords = longWords;
            _content.Add(s);

        }
        
        /// <summary>
        /// Outputs file content and analysis to a file.
        /// </summary>
        public void outputFile()
        {
            string path = Directory.GetCurrentDirectory();
            string fileName = "\\textAnalysis.txt";
            File.WriteAllLines(path+fileName, _content);
            outputLongWords(path);
        }
        /// <summary>
        /// Outputs the List of Long Words to a file
        /// </summary>
        /// <param name="path">The directory to save the file to.</param>
        private void outputLongWords(string path)
        {
            File.WriteAllLines(path + "\\longWords.txt", _longWords);
        }
        /// <summary>
        /// Outputs file content and analysis to the Console.
        /// </summary>
        public void outputConsole()
        {
            foreach(string value in _content)
            {
                Console.WriteLine(value);
            }                       
        }
    }
}
