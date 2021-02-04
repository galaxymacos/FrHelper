using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace FrHelper
{
    public static class SaveLoadSystem
    {
        static string path = @"f:\myText.txt";

        public static void SaveToFile()
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(JsonConvert.SerializeObject(DictProperty.Database));
            }

            Console.WriteLine("Data is saved to file");
        }

        public static void LoadFromFile()
        {
            if (File.Exists(path))
            {
                using var sr = File.OpenText(path);
                string entitiesInJson = sr.ReadToEnd();
                DictProperty.Database = JsonConvert.DeserializeObject<Database>(entitiesInJson);
            }
            else
            {
                DictProperty.Database = new Database();
            }
            
        }
    }
}