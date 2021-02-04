using System;
using System.Collections.Generic;
using System.Text;

namespace FrHelper
{
    [Serializable]
    public class EntitySentence
    {
        public byte[] TransInBytes;
        public EntitySentence(string originalSentence, string translation, List<string> keywords)
        {
            OriginalSentence = originalSentence;
            Translation = translation;
            Keywords = keywords;
        }
        public string OriginalSentence { get; set; }

        public string Translation
        {
            get => Encoding.UTF8.GetString(TransInBytes);
            private init => TransInBytes = Encoding.UTF8.GetBytes(value);
        }

        public List<string> Keywords { get; set; }
    }
}