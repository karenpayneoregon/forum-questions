using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;

namespace ObjectToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var i1 = new Item
            {
                Name = "test1",
                Value = "result1"
            };

            var i2 = new Item
            {
                Name = "test2",
                Value = "result2"
            };

            ReturnData returnData = new ReturnData();

            var items = new List<Item> {i1, i2};


            returnData.Type = "type1";
            returnData.Items = items;

            var json = JsonConvert.SerializeObject(returnData, Formatting.Indented);

            Debug.WriteLine(json);
            
        }
    }
    class ReturnData
    {
        [JsonProperty]
        internal string Type { get; set; }
        [JsonProperty]
        internal List<Item> Items { get; set; }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}

