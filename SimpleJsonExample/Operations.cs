using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SimpleJsonExample1
{
    public class Operations
    {
        public static string FileName = 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.json");

        public static List<ListItem> Items => new List<ListItem>()
        {
            new ListItem() {Id = 1, Item = "value 1", CheckboxValue = true},
            new ListItem() {Id = 1, Item = "value 2", CheckboxValue = false}
        };

        public static void SaveMockup()
        {
            using (var file = File.CreateText(FileName))
            {
                var serializer = new JsonSerializer
                {
                    Formatting = Formatting.Indented
                };

                serializer.Serialize(file, Items);
            }
        }

        public static List<ListItem> Read()
        {
            using (var reader = new StreamReader(FileName))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<ListItem>>(json);
            }
        }

        public static void Save(List<ListItem> listItems)
        {
            using (var file = File.CreateText(FileName))
            {
                var serializer = new JsonSerializer
                {
                    Formatting = Formatting.Indented
                };

                serializer.Serialize(file, listItems);
            }
        }
    }
}
