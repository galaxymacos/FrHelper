using System;
using System.Collections.Generic;

namespace FrHelper
{
    public class VocabularySaver: UserInputReactor
    {
        public VocabularySaver()
        {
            DictProperty.UserInputEvent += React;
        }
        
        /// <summary>
        /// React to user input to save a vocabulary
        /// </summary>
        /// <param name="userInput"></param>
        public override void React(string[] userInput)
        {
            Console.WriteLine("Vocabulary saver");
            string action = userInput[0];
            if (action.Equals("save"))
            {
                DictProperty.Database.Words.Add(new EntityWord{Word = userInput[1], Translation = userInput[2]});
                Console.WriteLine("The word "+userInput[1]+" has been saved");
            }
            
        }
    }
}