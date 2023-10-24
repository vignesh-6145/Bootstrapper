using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstapHelper.Models
{
    public class MethodTemplate : Template
    {
        
        public MethodTemplate(string Name, string args, string Modifier = "private", string ReturnType = "void", bool IsStatic = false)
        {
            this.Name = Name;
            this.Modifier = Modifier;
            this.ReturnType = ReturnType;
            this.IsStatic = IsStatic;
            this.Arguments = args;
        }
        public string Arguments { get; set; }
        public string ReturnType { get; set; } = "void";

        public bool IsStatic { get; set; } = false;
        
    }
}
