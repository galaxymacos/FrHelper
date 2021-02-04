using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FrHelper
{
    static class Program
    {

        static void Main(string[] args)
        {
            // // Initialization
            SaveLoadSystem.LoadFromFile();
            VocabularySaver vocabularySaver = new VocabularySaver();
            
            string userInput;
            do
            {
                userInput = Console.ReadLine();
                if (userInput == null || !userInput.Contains(' '))
                {
                    Console.WriteLine("Unknown action");
                    continue;
                }
            
                string[] userInputArr = userInput.Split(' ', 10);
                DictProperty.UserInputEvent.Invoke(userInputArr);
                
                
            } while (userInput != "exit");
            
            
            // Save data
            SaveLoadSystem.SaveToFile();
        }
    }
}