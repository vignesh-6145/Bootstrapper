using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstapHelper.Utils
{
    public class JsonUtils
    {
        public static JObject GetJson()
        {
           
            //Console.WriteLine("---" + Path.GetDirectoryName(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)));
            using (StreamReader r = new StreamReader(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "./Resources/Configuration.json")))
            {
                
                string contents = r.ReadToEnd();
                return JObject.Parse(contents);
            }
        }

        public static string GetSignature(string Language)
        {
            return ""+ GetJson()[Language];
        }
    }
}
