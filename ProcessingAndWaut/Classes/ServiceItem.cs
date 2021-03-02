using System.ServiceProcess;
using System.Text.Json.Serialization;

namespace ProcessingAndWait.Classes
{
    public class ServiceItem
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Status { get; set; }
        public string table { get; set; }
        public ServiceStartMode ServiceStartMode { get; set; }
        public override string ToString() => Name;
        public string[] ItemArray() => new[] { Name, DisplayName, Status };
    }
}