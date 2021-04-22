using Newtonsoft.Json;

namespace SimpleJsonExample1
{
    public class ListItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("item")]
        public string Item { get; set; }
        public bool CheckboxValue { get; set; }
    }
}
