using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    /// <summary>
    /// Analysis Object
    /// </summary>
    public class Analyse
    {   
        private List<string> content;
        
        /// <summary>
        /// Creates an Analysis Object
        /// </summary>
        /// <param name="input">The list of sentences to be analysed.</param>
        public Analyse(List<string> input)
        {
            content = input;   
        }
        
        /// <summary>
        /// Calculates and returns an analysis of the text 
        /// </summary>
        /// <returns>A tuple containing a list of values, and a list of words over 7 characters.</returns>
        public Tuple<List<int>,List<string>> analyseText()
        {
            //List of integers to hold the first five measurements:
            List<int> values = new List<int>();
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }
            //Set of characters for comparison with letters in file
            var vowels = new HashSet<char> {'a','e','i','o','u'};

            //Loop through each line in the file
            foreach (string s in content)
            {
                values[0]++;    //Increase count of sentences
                for (int i = 0; i < s.Length; i++)
                {
                    //Check current character is a letter
                    if (Char.IsLetter(s[i]))
                    {                    
                        if (Char.IsUpper(s[i]))
                        {
                            values[3]++;    //Increase count of uppercase letters
                        }
                        else
                        {
                            values[4]++;    //Increase count of lowercase letters
                        }
                        //Check current character is within the vowel HashSet
                        if (vowels.Contains(Char.ToLower(s[i])))
                        {
                            values[1]++;    //Increase Count of vowels
                        }
                        else
                        {
                            values[2]++;    //Increase Count of consonants
                        }
                    }
                }
            }                  
            return Tuple.Create(values, getLongWords());
        }
        /**
                ADDITIONAL METHOD
         */
        /// <summary>
        /// Creates and returns a list of words longer than 7 characters
        /// </summary>
        /// <returns>List of words longer than 7 characters.</returns>
        private List<string> getLongWords()
        {
            List<string> longWords = new List<string>();
            //Loop through each line in the file
            foreach(string sentence in content)
            {
                //Loop through each word in the line
                foreach(string word in sentence.Split(' '))
                    if(word.Length > 7)
                    {
                        longWords.Add(word);    //Add word to list if its longer than 7 characters
                    }
            }
            return longWords;
        }
        /**
                ADDITIONAL METHOD
         */
        /// <summary>
        /// Calculates frequency of a given letter
        /// </summary>
        /// <param name="givenC">Character to be counted</param>
        /// <returns>Frequency of given letter</returns>
        public int getCharFreq(Char givenC)
        {
            int freq = 0;
            foreach(string line in content)
            {
                foreach(char c in line)
                {
                    if(Char.ToLower(c) == givenC)
                    {
                        freq++;
                    }
                }
            }
            return freq;
        }
    }
}
