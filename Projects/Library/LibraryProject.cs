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
        // Output
        OutputForm outputForm = null;

        // Root
        public string RootName;
        public string RootDir;
        public string TestDir;

        // Project
        public string SolutionName;
        public string ProjectName;
        public string TestName;

        // GUIDs
        public string Solution_GUID;
        public string Project_GUID;
        public string Test_GUID;

        public void Generate(ref OutputForm outputForm)
        {
            this.outputForm = outputForm;

            //
            RootName = MainForm.RootDir_ProjectCodeName;
            RootDir = MainForm.RootDir_ProjectLocation;
            TestDir = RootDir + @"\Source\Tester\" + MainForm.Project_ProjectName + "Test";
            SolutionName = MainForm.Project_SolutionName;
            ProjectName = MainForm.Project_ProjectName;
            TestName = ProjectName + "Test";

            // Create project files
            this.CreateDirectories();
            this.CreateSolutionFile();
            this.CreateProjectFile();
            this.CreateProjectFiltersFile();
            this.CreateProjectUserFile();
            this.CreateLibrarySourceFiles();
            this.CreatePrecompiledHeaders();

            // Create test project files
            this.CreateTestProjectFile();
            this.CreateTestProjectFilterFile();
            this.CreateTestProjectUserFile();
            this.CreateTestMainCppFile();
            this.CreateTestPrecompiledHeaders();

            // Deploy all files
            this.DeployAllFiles();
        }

        public void Print(string text)
        {
            outputForm.txtOutput.AppendText(text);
        }
    }
}
