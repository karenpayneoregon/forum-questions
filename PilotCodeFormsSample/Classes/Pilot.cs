using System;
using Newtonsoft.Json;

namespace PilotCodeFormsSample.Classes
{
    public class Pilot
    {
        public int cid { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        public string callsign { get; set; }
        public string server { get; set; }
        public int pilot_rating { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public int altitude { get; set; }
        public int groundspeed { get; set; }
        public string transponder { get; set; }
        public int heading { get; set; }
        public float qnh_i_hg { get; set; }
        public int qnh_mb { get; set; }
        public Flight_Plan flight_plan { get; set; }
        public DateTime logon_time { get; set; }
        public DateTime last_updated { get; set; }

        public override string ToString() => Name;

    }
}