using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string? text = " ";
        List<string> textList = new List<string>();
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public List<string> manualTextInput()
        {
            do
            {
                //acn
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
            } while (!text.EndsWith("*")) ; //acn
                return textList;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public List<string> fileTextInput(string fileName)
        {
            //acn
            return textList;
        }

    }
}
