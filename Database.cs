using System;
using System.Collections.Generic;

namespace FrHelper
{
    [Serializable]
    public class Database
    {
        public Database()
        {
            Sentences = new List<EntitySentence>();
            Words = new List<EntityWord>();
        }
        public List<EntitySentence> Sentences;
        public List<EntityWord> Words;
    }
}