using System;
using System.IO;
using System.Diagnostics;

namespace GraphFilter
{
    /// <summary> 
    /// Used to show simple C# and Python interprocess communication 
    /// Author      : Ozcan ILIKHAN 
    /// Created     : 02/26/2015 
    /// Last Update : 04/30/2015 
    /// </summary> 
    static class CallPython
    {
        static void Main(string[] args)
        {
            Microsoft.Scripting.Hosting.ScriptEngine pythonEngine = IronPython.Hosting.Python.CreateEngine();
            Microsoft.Scripting.Hosting.ScriptSource pythonScript = pythonEngine.CreateScriptSourceFromString(
                "helloWorldString = 'Hello World!'\n" +
                "print helloWorldString\n" +
                "print externalString"
                );

            Microsoft.Scripting.Hosting.ScriptScope scope = pythonEngine.CreateScope();
            scope.SetVariable("externalString", "How do you do?");

            pythonScript.Execute(scope);

            System.Console.Out.WriteLine();
            System.Console.Out.WriteLine("List of variables in the scope:");
            foreach (string name in scope.GetVariableNames())
            {
                System.Console.Out.Write(name + " ");
            }
            System.Console.Out.WriteLine();

            System.Console.Out.WriteLine();
            System.Console.Out.WriteLine("Variable values:");
            System.Console.Out.WriteLine("helloWorldString: " + scope.GetVariable("helloWorldString"));
            System.Console.Out.WriteLine("externalString: " + scope.GetVariable("externalString"));

        }
    }
}