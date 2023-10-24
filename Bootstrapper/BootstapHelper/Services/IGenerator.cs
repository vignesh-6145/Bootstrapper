using BootstapHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstapHelper.Services
{
    public interface IGenerator
    {
        string GenerateClass(ClassTemplate ClassTemplate);
        string GenerateMethod(MethodTemplate MethodTemplate);
    }
}
