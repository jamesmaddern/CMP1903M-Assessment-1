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
            
            List<string> fileContent = new();
            bool valid;
            int letterFreq;
            string option = "";
            char c;
           
            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input input = new Input();
            do
            {
                Console.Write(
                    "1. Do you want to enter the text via the keyboard?\n"+
                    "2. Do you want to enter the text from a file?\n"+
                    "0. Do you want to Exit?\nChoice: ");
                string[] inputList = {"1","2","0"};
                try
                {
                    valid = true;
                    option = Console.ReadKey().KeyChar.ToString();
                    
                    Console.WriteLine();
                    switch (option)
                    {
                        case "1":
                            fileContent = input.manualTextInput();
                            break;
                        case "2":
                            fileContent = input.fileTextInput();                            
                            break;
                        case "0":
                            Environment.Exit(0);
                            break;
                        default:
                            string s = "Error: Invalid Input\nValid Inputs Include: ";
                            foreach (string i in inputList)
                            {
                                s += i + "\n";
                            }
                            throw new InvalidInputException(generateErrorMessage(inputList));
                    }
                }
                catch (InvalidInputException e)
                {
                    
                    Console.WriteLine(e.Message);
                    valid = false;
                }
            } while (!valid);

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Analyse analyse = new Analyse(fileContent);
            //Receive a list of integers back
            (var value, var longWords) = analyse.analyseText();
            Report report = null;
            do
            {
                string[] inputList = { "y", "n" };
                try
                {
                    valid = true;
                    Console.WriteLine("Generate letter frequency analysis? (y/n)");
                    option = Console.ReadKey().KeyChar.ToString();
                    Console.WriteLine();
                    switch (option)
                    {
                        case "y":
                            Console.WriteLine("Enter a letter to be counted");
                            c = Console.ReadKey().KeyChar;
                            letterFreq = analyse.getCharFreq(c);
                            report = new Report(fileContent, value, longWords, c, letterFreq);
                            break;
                        case "n":
                            //Report the results of the analysis
                            report = new Report(fileContent, value, longWords);
                            break;
                        default:
                            
                            throw new InvalidInputException(generateErrorMessage(inputList));

                    }
                }
                catch (InvalidInputException e)
                {
                    Console.WriteLine(e.Message);
                    valid = false;
                }
            } while (!valid);


            
            report.outputConsole();
            report.outputFile();

            //TO ADD: Get the frequency of individual letters?

           
        }
        static string generateErrorMessage(string[] inputList)
        {
            string s = "Error: Invalid Input\nValid Inputs Include:\n";
            foreach (string i in inputList)
            {
                s += i + "\n";
            }
            return s;
        }
        
        
    
    }
}
