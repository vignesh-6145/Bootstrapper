using System.CommandLine;
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

            var packagesOption = new Option<string[]>("-p");
            packagesOption.AddAlias("--packages");
            packagesOption.Arity = ArgumentArity.ZeroOrMore;
            packagesOption.Description="Specify the packages you require to import";

            


            var rootCommand = new RootCommand("Welcome to Bootstrapper.exe");

            rootCommand.Add(langOption);
            rootCommand.Add(classOption);
            rootCommand.Add(isMainOption);
            rootCommand.Add(packagesOption);

            rootCommand.SetHandler((langValue, classValue, isMainValue, packagesValue) 
                                   => { 
                                        Console.WriteLine($"langValue : {langValue}");
                                        Console.WriteLine($"classValue : {classValue}");
                                        Console.WriteLine($"isMainValue : {isMainValue}");
                                       Console.WriteLine($"packagesValue : {packagesValue.Count()}");
                                    }
                                    , langOption,classOption,isMainOption,packagesOption);
            rootCommand.Invoke(args);
        }

    }
}