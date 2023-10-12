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
            langOption.Description = "Use this option to specify which programming language you want to choose";
            


            var rootCommand = new RootCommand("Welcome to Bootstrapper.exe");
            rootCommand.Add(langOption);
            rootCommand.SetHandler((string langValue) => { Console.WriteLine($"langValue : {langValue}"); }, langOption);
            rootCommand.Invoke(args);
        }

    }
}