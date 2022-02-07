using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5Z2
{
    public static class JsonHelper<T> where T : new ()
    {
        public static void SerializeToJson(T employees, string path)
        {
            var jsonSerializer = new JsonSerializer();

            using (var streamWriter = new StreamWriter(path))
            {
                jsonSerializer.Serialize(streamWriter, employees);
            }
        }

        public static T DeserializeFromJson(string path)
        {
            if (!File.Exists(path))
                return new T();

            var jsonSerializer = new JsonSerializer();

            using (var streamReader = new StreamReader(path))
            {
                return (T)jsonSerializer.Deserialize(streamReader, typeof(T));
            }
        }
    }
}
