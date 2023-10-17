using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstapHelper.Models
{
    public class ClassTemplate
    {
        private string ClassName { get; set; }
        private bool IsMain { get; set; }
        private List<MethodTemplate> methods;
    }
}
