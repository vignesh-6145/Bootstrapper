using BootstapHelper.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstapHelper.Models
{
    public class ClassTemplate : Template
    {

        public bool IsMain { get; set; }
        public  List<MethodTemplate> methods;
        public ClassTemplate()
        {
            this.Modifier = "public";
        }
        public ClassTemplate(string Name, bool IsMain,string [] methods)
        {
            this.Name = Name;
            this.Modifier = "public";
            this.IsMain = IsMain;
            this.methods = CoreUtils.GetMethods(methods);
        }
    }
}
