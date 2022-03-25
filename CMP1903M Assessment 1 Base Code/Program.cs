//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        //additional comments needed (acn)
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            List<string> fileContent;
            bool valid;
            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input input = new Input();
            do
            {
                //acn
                Console.WriteLine(
                    "1. Do you want to enter the text via the keyboard?\n"+
                    "2. Do you want to enter the text from a file?\n"+
                    "0. Do you want to Exit?\n");
                try
                {
                    //acn
                    valid = true;
                    var option = Console.ReadKey().KeyChar.ToString();
                    switch (option)
                    {
                        //acn
                        case "1":
                            fileContent = input.manualTextInput();
                            foreach (string item in fileContent)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case "2":
                            fileContent = input.fileTextInput("file");
                            break;
                        case "0":
                            break;
                        default:
                            throw new Exception();
                    }
                }
                //acn
                catch (Exception)
                {
                    Console.WriteLine("\nError: Input either \"1\" or \"0\"");
                    valid = false;
                }
            } while (!valid); //acn

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}
//overall you need to add more comments to overall code
//to expalin functionaility, in addition youll need to 
//add more feutures to analyse like the ones explained
//in the brief and maybe letter frequency for example
//lastly your code doesnt say where report is outputted 
//when you choose to output as a txt file this could be
//added also to improve the overall project
// reviewed by Dominic Harris