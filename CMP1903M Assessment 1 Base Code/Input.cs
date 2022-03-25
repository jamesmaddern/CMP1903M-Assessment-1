using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    /// <summary>
    /// Initialises a new Input Class
    /// </summary>
    public class Input
    {        
        string text = " ";
        List<string> textList = new List<string>();
        /// <summary>
        /// Requests manual text entry from the user.
        /// </summary>
        /// <returns>A list of strings, with each string being one user entered sentence</returns>
        public List<string> manualTextInput()
        {
            do
            {
                Console.WriteLine("Enter a sentence (End Sentence with * to finish");
                text = Console.ReadLine();
                if(text == "")
                {
                    Console.WriteLine("Sentence cannot be empty.");
                }
                else
                {
                    this.textList.Add(text); 
                }
            } while (!text.EndsWith("*")) ;
                
            string lastSentence = textList[textList.Count - 1];
            textList[textList.Count-1] = lastSentence.Remove(lastSentence.Length - 1);
            return textList;
        }
        /// <summary>
        /// Gets text input from a .txt file
        /// </summary>
        /// <returns>A list of strings, with each string being a sentence from the file</returns>
        public List<string> fileTextInput()
        {
            
            try
            {
                Console.WriteLine("Enter the file path: ");
                string path = Console.ReadLine();
                //string path = Directory.GetCurrentDirectory();
                string file = File.ReadAllText(path);
                string[] fileSplit = file.Split('.');
                foreach (string line in fileSplit)
                {
                    textList.Add(line);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }  
            
            return textList;
        }

    }
}
