using System;
using System.Reflection;
using SuggestionBox.Core;
using SuggestionBox.Core.Utilities;

namespace SuggestionBox.SuggestionBox_CLI;
public class Program
{
    static void Main(string[] args)
    {
        Assembly thisAssem = typeof(Program).Assembly;
        AssemblyName thisAssemblyName = thisAssem.GetName();
        if(thisAssemblyName.Version != null)
        {
            Version version = thisAssemblyName.Version;
            Console.WriteLine("Suggestion Box Console app version {0}", version);
            Console.WriteLine("==========================================");

            Console.WriteLine("Initialising Box Factory");
            BoxFactory bf = new BoxFactory();
            Console.WriteLine("Creating Test Box");
            Box box = bf.Create("Test Box", "A box for testing the system");
            Console.WriteLine("Initialising Suggestion Factory");
            SuggestionFactory sf = new SuggestionFactory();
            Console.WriteLine("Creating Test Suggestion");
           // Suggestion suggestion = sf.Create("Get Better at coding", "imprivements needed", new User(new Guid(), "Robert"), box);
            Console.WriteLine("Setup successful.");
        }

    }
}

