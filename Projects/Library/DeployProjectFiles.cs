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
        public string DepDir; // Source directory for the deploy files

        // Copy all project files to the project.
        public void DeployAllFiles()
        {
            //
            DepDir = @"Projects\Library_Project\";

            Print("Deploying files:" + Environment.NewLine);

            DeployFile(@"Docs\Project_Setup_Specifications.txt");
            DeployFile(@"Lib\Do not forget to export the headers.txt");
            DeployFile(@"Source\ExampleClass.h");
            DeployFile(@"Source\ExampleClass.cpp");
            DeployFile(@"Source\ExampleFunctions.h");
            DeployFile(@"Source\ExampleFunctions.cpp");
            DeployFile(@"Source\ExampleFunctionsPureC.h");
            DeployFile(@"Source\ExampleFunctionsPureC.cpp");

            Print("Deploying done" + Environment.NewLine);
        }

        private void DeployFile(string depFile)
        {
            Print("\t" + depFile);

            File.Copy(DepDir + depFile, RootDir + @"\" + depFile);

            Print("\t" + "Done" + Environment.NewLine);
        }
    }
}
