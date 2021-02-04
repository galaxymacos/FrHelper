using System;

namespace FrHelper
{
    [Serializable]
    public class EntityWord
    {
        // public EntityWord(string word, string translation)
        // {
        //     Word = word;
        //     Translation = translation;
        // }
        public string Word { get; set; }
        public string Translation { get; set; }

        public int TimeOfReview = 0;
    }
}