using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExtendedCommands
{
    namespace Code
    {
        public static class Compile
        {
            public static string[] GetDefaultUsedAssemblies
            {
                get
                {
                    return new[] { "mscorlib.dll", "System.Core.dll" };
                }
            }
            public static string GetDefaultFrameworkVersion
            {
                get
                {
                    return "v4.0";
                }
            }
            public static CompilerResults CSharpSourceCode(string sourceCode, string frameworkVersion, string outputFile, string[] referencedAssemblies, out string output)
            {
                return CSharpSourceCode(sourceCode, frameworkVersion, outputFile, referencedAssemblies, null, out output);
            }
            public static CompilerResults CSharpSourceCode(string sourceCode, string frameworkVersion, string outputFile, string[] referencedAssemblies, string compilerOptions, out string output)
            {
                CSharpCodeProvider csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", frameworkVersion } });
                var outputVariable = "";
                CompilerParameters parameters = new CompilerParameters(referencedAssemblies, outputFile, true)
                {
                    GenerateExecutable = true
                };
                if (!string.IsNullOrEmpty(compilerOptions))
                    parameters.CompilerOptions = compilerOptions;
                CompilerResults results = csc.CompileAssemblyFromSource(parameters, sourceCode);
                if (results.Errors.HasErrors)
                    results.Errors.Cast<CompilerError>().ToList().ForEach(error => outputVariable += error.ErrorText + "\r\n");
                else
                    outputVariable = "----Build succeded----";
                output = outputVariable;
                return results;
            }
            public static CompilerResults VBSourceCode(string sourceCode, string frameworkVersion, string outputFile, string[] referencedAssemblies, out string output)
            {
                Microsoft.VisualBasic.VBCodeProvider vbc = new Microsoft.VisualBasic.VBCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", frameworkVersion } });
                var outputVariable = "";
                CompilerParameters parameters = new CompilerParameters(referencedAssemblies, outputFile, true)
                {
                    GenerateExecutable = true
                };
                CompilerResults results = vbc.CompileAssemblyFromSource(parameters, sourceCode);
                if (results.Errors.HasErrors)
                    results.Errors.Cast<CompilerError>().ToList().ForEach(error => outputVariable += error.ErrorText + "\r\n");
                else
                    outputVariable = "----Build succeded----";
                output = outputVariable;
                return results;
            }
            public static CompilerResults CSharpSourceFiles(string[] fileNames, string frameworkVersion, string outputFile, string[] referencedAssemblies, out string output)
            {
                CSharpCodeProvider csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", frameworkVersion } });
                var outputVariable = "";
                CompilerParameters parameters = new CompilerParameters(referencedAssemblies, outputFile, true)
                {
                    GenerateExecutable = true
                };
                CompilerResults results = csc.CompileAssemblyFromFile(parameters, fileNames);
                if (results.Errors.HasErrors)
                    results.Errors.Cast<CompilerError>().ToList().ForEach(error => outputVariable += error.ErrorText + "\r\n");
                else
                    outputVariable = "----Build succeded----";
                output = outputVariable;
                return results;
            }
            public static CompilerResults VBSourceFiles(string[] fileNames, string frameworkVersion, string outputFile, string[] referencedAssemblies, out string output)
            {
                CSharpCodeProvider vbc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", frameworkVersion } });
                var outputVariable = "";
                CompilerParameters parameters = new CompilerParameters(referencedAssemblies, outputFile, true)
                {
                    GenerateExecutable = true
                };
                CompilerResults results = vbc.CompileAssemblyFromFile(parameters, fileNames);
                if (results.Errors.HasErrors)
                    results.Errors.Cast<CompilerError>().ToList().ForEach(error => outputVariable += error.ErrorText + "\r\n");
                else
                    outputVariable = "----Build succeded----";
                output = outputVariable;
                return results;
            }
        }
    }
}
