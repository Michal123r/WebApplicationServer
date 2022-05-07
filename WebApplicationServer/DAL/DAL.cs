using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebApplicationServer.DAL
{
    public class DAL
    {
        internal static List<string[]> GetData()
        {
            List<string[]> allSteps = new List<string[]>();
           
            string filePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory)) + @"\DATA\steps.json";
            string json = File.ReadAllText(filePath);
            var steps = JsonConvert.DeserializeObject<List<string[]>>(json);
            foreach (var item in steps)
            {
                allSteps.Add(item);
            }
            return allSteps;
        }
    }
}
