using BootstapHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstapHelper.Services
{
    public interface IMethodGenerator
    {
        string Generate(MethodTemplate MethodTemplate);
    }
}
