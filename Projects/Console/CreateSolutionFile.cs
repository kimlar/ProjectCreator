using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCreator.Projects.Console
{
    public partial class ConsoleProject
    {
        // Generate solution file (.sln)
        public void CreateSolutionFile()
        {
            Print("Creating the solution file: ");

            // Get new GUIDs for this project.
            Solution_GUID = Guid.NewGuid().ToString().ToUpper();
            Project_GUID = Guid.NewGuid().ToString().ToUpper();

            // Create the solution file (*.sln).
            using (StreamWriter sw = new StreamWriter(RootDir + @"\Source\Project\" + SolutionName + ".sln"))
            {
                sw.WriteLine("");
                sw.WriteLine("Microsoft Visual Studio Solution File, Format Version 12.00");
                sw.WriteLine("# Visual Studio 14");
                sw.WriteLine("VisualStudioVersion = 14.0.24720.0");
                sw.WriteLine("MinimumVisualStudioVersion = 10.0.40219.1");
                sw.WriteLine("Project(\"{" + Solution_GUID + "}\") = \"" + ProjectName + "\", \"" + ProjectName + ".vcxproj\", \"{" + Project_GUID + "}\"");
                sw.WriteLine("EndProject");
                sw.WriteLine("Global");
                sw.WriteLine("\t" + "GlobalSection(SolutionConfigurationPlatforms) = preSolution");
                sw.WriteLine("\t\t" + "Debug|x64 = Debug|x64");
                sw.WriteLine("\t\t" + "Release|x64 = Release|x64");
                sw.WriteLine("\t" + "EndGlobalSection");
                sw.WriteLine("\t" + "GlobalSection(ProjectConfigurationPlatforms) = postSolution");
                sw.WriteLine("\t\t" + "{" + Project_GUID + "}.Debug|x64.ActiveCfg = Debug|x64");
                sw.WriteLine("\t\t" + "{" + Project_GUID + "}.Debug|x64.Build.0 = Debug|x64");
                sw.WriteLine("\t\t" + "{" + Project_GUID + "}.Release|x64.ActiveCfg = Release|x64");
                sw.WriteLine("\t\t" + "{" + Project_GUID + "}.Release|x64.Build.0 = Release|x64");
                sw.WriteLine("\t" + "EndGlobalSection");
                sw.WriteLine("\t" + "GlobalSection(SolutionProperties) = preSolution");
                sw.WriteLine("\t\t" + "HideSolutionNode = FALSE");
                sw.WriteLine("\t" + "EndGlobalSection");
                sw.WriteLine("EndGlobal");
            }

            Print("Done" + Environment.NewLine);
        }
    }
}
