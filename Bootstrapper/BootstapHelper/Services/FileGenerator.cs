using BootstapHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstapHelper.Services
{
    public class FileGenerator : IGenerator
    {
        Signature signature;
        public FileGenerator(Signature Signature)
        {
            signature = Signature;
        }
        public void Generate(ClassTemplate ClassTemplate)
        {
            string content = GenerateClass(ClassTemplate);
            using(StreamWriter classFile = new StreamWriter($"{Environment.CurrentDirectory}/{ClassTemplate.Name}.{signature.FileExtension}"))
            {
                
                classFile.WriteLine(content);
            }

        }
        public string GenerateClass(ClassTemplate classTemplate)
        {
            Console.WriteLine($"Please wait Working on Class {classTemplate.Name}....");
            string content = signature.ClassSignature;
            
            content = content.Replace("<Modifier>", classTemplate.Modifier);
            content = content.Replace("<ClassName>", classTemplate.Name);
            content += "{\n";
            if (classTemplate.IsMain)
                classTemplate.methods.Add(new MethodTemplate("main","String []args"));
            foreach (var method in classTemplate.methods)
                content += GenerateMethod(method);
            

            content += "\n}";
            Console.WriteLine($"Done working on {classTemplate.Name}\n\n\nPlease find the file at {Environment.CurrentDirectory}/{classTemplate.Name}.{signature.FileExtension}");
            return content;
        }

        public string GenerateMethod(MethodTemplate MethodTemplate)
        {
            Console.WriteLine($"Please wait Working on Method {MethodTemplate.Name}...");

            string content = "\n\t"+signature.MethodSignature;
            content = content.Replace("<Modifier>",MethodTemplate.Modifier);
            content = content.Replace("<Static>",MethodTemplate.IsStatic?"static":"");
            content = content.Replace("<ReturnType>",MethodTemplate.ReturnType);
            content = content.Replace("<MethodName>",MethodTemplate.Name);
            content = content.Replace("<Arguments>", MethodTemplate.Arguments);
            content += " {\n\t\n\t\t//Code goes here\n\n\t}\n";

            Console.WriteLine($"Method {MethodTemplate.Name} was included in the Class");
            return content;
        }
    }
}
