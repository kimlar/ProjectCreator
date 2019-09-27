﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCreator.Projects.Console
{
    public partial class ConsoleProject
    {
        // Generate project filter file (.vcxproj.filters)
        public void CreateProjectFiltersFile()
        {
            Print("Creating the project filters file: ");

            using (StreamWriter sw = new StreamWriter(RootDir + @"\Source\Project\" + ProjectName + ".vcxproj.filters"))
            {
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sw.WriteLine("<Project ToolsVersion=\"4.0\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
                sw.WriteLine("  <ItemGroup>");
                sw.WriteLine("    <Filter Include=\"Main\">");
                sw.WriteLine("      <UniqueIdentifier>{" + Guid.NewGuid().ToString().ToUpper() + "}</UniqueIdentifier>");
                sw.WriteLine("    </Filter>");
                sw.WriteLine("  </ItemGroup>");
                sw.WriteLine("  <ItemGroup>");
                sw.WriteLine("    <ClCompile Include=\"..\\Main.cpp\">");
                sw.WriteLine("      <Filter>Main</Filter>");
                sw.WriteLine("    </ClCompile>");
                sw.WriteLine("    <ClCompile Include=\"..\\pch.cpp\">");
                sw.WriteLine("      <Filter>Main</Filter>");
                sw.WriteLine("    </ClCompile>");
                sw.WriteLine("  </ItemGroup>");
                sw.WriteLine("  <ItemGroup>");
                sw.WriteLine("    <ClInclude Include=\"..\\pch.h\">");
                sw.WriteLine("      <Filter>Main</Filter>");
                sw.WriteLine("    </ClInclude>");
                sw.WriteLine("  </ItemGroup>");
                sw.WriteLine("</Project>");
            }

            Print("Done" + Environment.NewLine);
        }
    }
}
