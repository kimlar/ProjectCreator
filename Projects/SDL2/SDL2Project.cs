using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCreator.Projects.SDL2
{
    public partial class SDL2Project
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

        // Extra stuff
        public bool AddSDL2_net;
        public bool AddSDL2_ttf;

        public void Generate(ref OutputForm outputForm)
        {
            this.outputForm = outputForm;

            //
            RootName = MainForm.RootDir_ProjectCodeName;
            RootDir = MainForm.RootDir_ProjectLocation;
            SolutionName = MainForm.Project_SolutionName;
            ProjectName = MainForm.Project_ProjectName;

            // Extra stuff
            AddSDL2_net = MainForm.AddSDL2_net;
            AddSDL2_ttf = MainForm.AddSDL2_ttf;

            // Create project files
            this.CreateDirectories();
            this.CreateSolutionFile();
            this.CreateProjectFile();
            this.CreateProjectFiltersFile();
            this.CreateProjectUserFile();
            this.CreateMainCppFile();
            this.CreatePrecompiledHeaders();
            this.CreateDpiAwareManifest();

            // Deploy all files
            this.DeployAllFiles();
        }

        public void Print(string text)
        {
            outputForm.txtOutput.AppendText(text);
        }
    }
}
