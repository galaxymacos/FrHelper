using System;
using System.Linq;

namespace FrHelper
{
    public class SentenceSaver : UserInputReactor
    {
        public override void React(string[] userInput)
        {
            if (userInput.Equals("Save") || userInput.Equals("save"))
            {
                if (userInput.Length == 4)
                {
                    var sentenceInFrench = userInput[1];
                    var sentenceInChinese = userInput[2];
                    var keywordString = userInput[3];
                    var keywords = keywordString.Split(',');
                    EntitySentence entity = new EntitySentence(sentenceInFrench, sentenceInChinese, keywords.ToList());
                    DictProperty.Database.Sentences.Add(entity);
                    Console.WriteLine($"The sentence \"{sentenceInFrench}\" has been saved");
                }
            }
        }
    }
}