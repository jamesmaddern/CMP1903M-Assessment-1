using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(List<string> input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            var vowels = new HashSet<char> {'a','e','i','o','u'};
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }

            foreach (string s in input)
            {
                values[0]++;
                for (int i = 0; i < s.Length; i++)
                {
                    if (Char.IsLetter(s[i]))
                    {                    
                        if (Char.IsUpper(s[i]))
                        {
                            values[3]++;
                        }
                        else
                        {
                            values[4]++;
                        }
                        if (vowels.Contains(Char.ToLower(s[i])))
                        {
                            values[1]++;
                        }
                        else
                        {
                            values[2]++;
                        }
                    }
                }
            }
            return values;
        }
    }
}
