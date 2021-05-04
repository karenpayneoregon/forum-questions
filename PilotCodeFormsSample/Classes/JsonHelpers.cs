using System;
using System.IO;
using Newtonsoft.Json;

namespace PilotCodeFormsSample.Classes
{
    public class JsonHelpers
    {
        public static TModel ReadJsonFromFile<TModel>(string fileName)
        {
            var model = default(TModel);

            if (!File.Exists(fileName)) return model;
            
            var json = File.ReadAllText(fileName);
            model = JsonConvert.DeserializeObject<TModel>(json);

            return model;

        }

        public static TModel ReadJsonFromWeb<TModel>()
        {
            throw new NotImplementedException();
        }
    }
}
