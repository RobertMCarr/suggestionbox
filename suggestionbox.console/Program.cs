using System;
using System.Reflection;
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
            Console.WriteLine("");
        }

    }
}

