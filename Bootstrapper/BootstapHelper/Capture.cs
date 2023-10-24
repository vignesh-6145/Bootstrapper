using BootstapHelper.Services;
using BootstapHelper.Utils;
using BootstapHelper.Models;
using Microsoft.Extensions.Logging;
using System.CommandLine;
using Newtonsoft.Json;

namespace BootstapHelper
{
    public class Capture
    {
      

        // starts capturing the user inputs from CLI and also displays the home screen
        public void start(string[] args)
        {
             
            var langOption = new Option<string>("-l");
            langOption.AddAlias("--lang");
            langOption.Arity = ArgumentArity.ExactlyOne;
            langOption.Description = "Use this option to specify which programming language you want to choose";
            langOption.IsRequired = true;

            var classOption = new Option<string>("-c");
            classOption.AddAlias("--class");
            classOption.Arity = ArgumentArity.ExactlyOne;
            classOption.Description = "This option was used to name the file";

            var isMainOption = new Option<bool>("-m");
            isMainOption.AddAlias("--main");
            isMainOption.Arity = ArgumentArity.ZeroOrOne;
            isMainOption.Description = "This specifies whether the class contains a main method or not";

            var functionsOption = new Option<string[]>("-f");
            functionsOption.AddAlias("--functions");
            functionsOption.Arity = ArgumentArity.ZeroOrMore;
            functionsOption.Description="Specify the funcions in the class";

            


            var rootCommand = new RootCommand("Welcome to Bootstrapper.exe");

            rootCommand.Add(langOption);
            rootCommand.Add(classOption);
            rootCommand.Add(isMainOption);
            rootCommand.Add(functionsOption);

            rootCommand.SetHandler((langValue, classValue, isMainValue, functionsValue) 
                                   => {
                                       //Signature Signature = JsonConvert.DeserializeObject<Signature>();
                                       //Console.WriteLine(Signature.ClassSignature);
                                       try
                                       {
                                           ClassTemplate Template = new ClassTemplate(classValue, isMainValue, functionsValue);
                                           FileGenerator _FileGenerator = new FileGenerator(CoreUtils.GetSignature(langValue));
                                           _FileGenerator.Generate(Template);
                                       }
                                       catch(Exception e)
                                       {
                                           Console.WriteLine("Gone something wrong");
                                       }

                                    }
                                    , langOption,classOption,isMainOption, functionsOption);
            rootCommand.Invoke(args);
        }

    }
}