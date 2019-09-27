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
        public string DepDir; // Source directory for the deploy files

        // Copy all project files to the project.
        public void DeployAllFiles()
        {
            //
            DepDir = @"Projects\Console_Project\";

            Print("Deploying files:" + Environment.NewLine);

            DeployFile(@"Docs\Project_Setup_Specifications.txt");

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
