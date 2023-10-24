using BootstapHelper.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstapHelper.Utils
{
    public class CoreUtils
    {
        public static bool IsSupported(string language)
        {
            return JsonUtils.GetJson().ContainsKey(language) ;
        }

        public static List<MethodTemplate> GetMethods(string [] methods)
        {
            List<MethodTemplate> _methods = new List<MethodTemplate>();
            foreach(var method in methods)
            {
                _methods.Add(new MethodTemplate(method," "));
            }

            return _methods;

        }
        public static Signature GetSignature(string Language)
        {
            
            JObject SignatureJson = JObject.Parse(JsonUtils.GetSignature(Language));
            return new Signature(""+SignatureJson["ClassSignature"], ""+SignatureJson["MethodSignature"], ""+SignatureJson["InterfaceSignature"], "" + SignatureJson["FileExtension"]);

        }
    }
}
