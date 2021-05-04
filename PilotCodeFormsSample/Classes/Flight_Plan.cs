using Newtonsoft.Json;

namespace PilotCodeFormsSample.Classes
{
    public class Flight_Plan
    {
        public string flight_rules { get; set; }
        public string aircraft { get; set; }
        public string aircraft_faa { get; set; }
        public string aircraft_short { get; set; }
        [JsonProperty("departure")]
        public string Departure { get; set; }
        [JsonProperty("arrival")]
        public string Arrival { get; set; }
        [JsonProperty("alternate")]
        public string Alternate { get; set; }
        public string cruise_tas { get; set; }
        [JsonProperty("altitude")]
        public string Altitude { get; set; }
        public string deptime { get; set; }
        public string enroute_time { get; set; }
        public string fuel_time { get; set; }
        public string remarks { get; set; }
        [JsonProperty("route")]
        public string Route { get; set; }
        public int revision_id { get; set; }
    }
}