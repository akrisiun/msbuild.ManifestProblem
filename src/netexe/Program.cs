using System;

namespace forms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            new core.Class1().Out();
        }
    }
}

/*
WTF #1:
1>C:\Program Files(x86)\Microsoft Visual Studio\Preview\Community\MSBuild\Microsoft\NuGet\15.0\Microsoft.NuGet.targets(186,5): 
    error : Your project is not referencing the ".NETFramework,Version=v4.7" framework.Add a reference to ".NETFramework,Version=v4.7" in the "frameworks" section of your project.json, and then re-run NuGet restore.
========== Build: 0 succeeded, 1 failed, 0 up-to-date, 0 skipped ==========

#WTF2
Severity	Code	Description	Project	File	Line	Suppression State
Error		
The version of Microsoft.NET.Sdk used by this project is insufficient to support references to libraries targeting .NET Standard 1.5 or higher. 
Please install version 2.0 or higher of the .NET Core SDK.	forms	C:\Program Files (x86)\Microsoft Visual Studio\Preview\Community\MSBuild\Microsoft\Microsoft.NET.Build.Extensions\Microsoft.NET.Build.Extensions.NETFramework.targets	65	

*/
