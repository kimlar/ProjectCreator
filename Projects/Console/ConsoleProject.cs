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
        // Output
        OutputForm outputForm = null;

        // Root
        public string RootName;
        public string RootDir;

        // Project
        public string SolutionName;
        public string ProjectName;

        // GUIDs
        public string Solution_GUID;
        public string Project_GUID;

        public void Generate(ref OutputForm outputForm)
        {
            this.outputForm = outputForm;

            //
            RootName = MainForm.RootDir_ProjectCodeName;
            RootDir = MainForm.RootDir_ProjectLocation;
            SolutionName = MainForm.Project_SolutionName;
            ProjectName = MainForm.Project_ProjectName;

            // Create project files
            this.CreateDirectories();
            this.CreateSolutionFile();
            this.CreateProjectFile();
            this.CreateProjectFiltersFile();
            this.CreateProjectUserFile();
            this.CreateMainCppFile();
            this.CreatePrecompiledHeaders();

            // Deploy all files
            this.DeployAllFiles();
        }

        public void Print(string text)
        {
            outputForm.txtOutput.AppendText(text);
        }
    }
}
