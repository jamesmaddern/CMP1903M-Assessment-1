using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Test
    {
        private List<int> _testVals = new List<int>();
        private string[] testNames ={"Sentences","Vowels,","Consonants","Upper Case","Lower Case"};
    public Test()
        {
            _testVals.Add(6);
            _testVals.Add(189);
            _testVals.Add(317);
            _testVals.Add(9);
            _testVals.Add(497);            
        }
        public void test()
        {
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\..\","test.txt"));
            
            List<string> fileContent = new Input().fileTextInput(newPath);
            (var realValues, var longWords) = new Analyse(fileContent).analyseText();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i+1}. {testNames[i]}: Test Value: {_testVals[i]}, Real Value {realValues[i]}");
            }
        }
    }
}
