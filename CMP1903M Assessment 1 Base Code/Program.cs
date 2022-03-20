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
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            List<string> fileContent = new List<string>();
            bool valid;
            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input input = new Input();
            do
            {
                Console.WriteLine(
                    "1. Do you want to enter the text via the keyboard?\n"+
                    "2. Do you want to enter the text from a file?\n"+
                    "0. Do you want to Exit?\n");
                try
                {
                    valid = true;
                    var option = Console.ReadKey().KeyChar.ToString();
                    switch (option)
                    {
                        case "1":
                            fileContent = input.manualTextInput();
                            foreach (string item in fileContent)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case "2":
                            fileContent = input.fileTextInput();
                            Console.WriteLine(fileContent[0]);
                            break;
                        case "0":
                            break;
                        default:
                            throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nError: Input either \"1\" or \"0\"");
                    valid = false;
                }
            } while (!valid);

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Analyse analyse = new Analyse();
            //Receive a list of integers back
            List<int> values = analyse.analyseText(fileContent);


            //Report the results of the analysis
            Report report = new Report(fileContent, values);
            report.outputConsole();
            report.outputFile();

            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}
