using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCreator.Projects.Library
{
    public partial class LibraryProject
    {
        // Generate project user file (.vcxproj.user)
        public void CreateProjectUserFile()
        {
            Print("Creating the project user file: ");

            using (StreamWriter sw = new StreamWriter(RootDir + @"\Source\Project\" + ProjectName + ".vcxproj.user"))
            {
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sw.WriteLine("<Project ToolsVersion=\"14.0\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
                sw.WriteLine("  <PropertyGroup Condition=\"'$(Configuration)|$(Platform)'=='Debug|x64'\">");
                sw.WriteLine("    <LocalDebuggerWorkingDirectory>$(OutDir)</LocalDebuggerWorkingDirectory>");
                sw.WriteLine("    <DebuggerFlavor>WindowsLocalDebugger</DebuggerFlavor>");
                sw.WriteLine("  </PropertyGroup>");
                sw.WriteLine("  <PropertyGroup Condition=\"'$(Configuration)|$(Platform)'=='Release|x64'\">");
                sw.WriteLine("    <LocalDebuggerWorkingDirectory>$(OutDir)</LocalDebuggerWorkingDirectory>");
                sw.WriteLine("    <DebuggerFlavor>WindowsLocalDebugger</DebuggerFlavor>");
                sw.WriteLine("  </PropertyGroup>");
                sw.WriteLine("</Project>");
            }

            Print("Done" + Environment.NewLine);
        }
    }
}
