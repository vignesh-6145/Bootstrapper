using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstapHelper.Models
{
    public class Signature
    {
        public Signature(string ClassSignature, string MethodSignature, string InterfaceSignature,string FileExtension="txt")
        {
            this.ClassSignature = ClassSignature;
            this.MethodSignature = MethodSignature;
            this.InterfaceSignature = InterfaceSignature;
            this.FileExtension = FileExtension;
        }
        public string ClassSignature { get; set; }
        public string MethodSignature { get; set; }
        public string InterfaceSignature { get; set; }
        public string FileExtension { get; set; }

        
    }
}
