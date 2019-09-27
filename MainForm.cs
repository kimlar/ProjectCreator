using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
// TODO:
//
// All complete.

namespace ProjectCreator
{
    public partial class MainForm : Form
    {
        // Settings
        public static ReadSettings settings;

        // Root directory
        public static string RootDir_ProjectCodeName;
        public static string RootDir_ProjectLocation;

        // Project
        public static string Project_SolutionName;
        public static string Project_ProjectName;

        // Project types
        public enum ProjectTypes { Console, Library, SDL2 };
        public static ProjectTypes ProjectTypes_SelectedProject;
        public static bool AddSDL2_net;
        public static bool AddSDL2_ttf;

        public MainForm()
        {
            InitializeComponent();

            // Do default settings form Settings.txt
            settings = new ReadSettings();
            txtRootDir_ProjectLocation.Text = settings.GetDefaultProjectDir();
            switch(settings.GetDefaultProjectType())
            {
                case 0:
                    optTypes_ConsoleProject.Checked = true;
                    break;
                case 1:
                    optTypes_LibraryProject.Checked = true;
                    break;
                case 2:
                    optTypes_SDL2Project.Checked = true;
                    break;
            }
        }

        private void txtRootDir_ProjectCodeName_TextChanged(object sender, EventArgs e)
        {
            txtRootDir_ProjectCodeName.Text = txtRootDir_ProjectCodeName.Text.Replace(' ', '_');
            RootDir_ProjectCodeName = txtRootDir_ProjectCodeName.Text;

            string t = txtRootDir_ProjectLocation.Text.Substring(0, txtRootDir_ProjectLocation.Text.LastIndexOf('\\') + 1);
            txtRootDir_ProjectLocation.Text = t + RootDir_ProjectCodeName;

            txtProject_SolutionName.Text = RootDir_ProjectCodeName;

            txtProject_ProjectName.Text = RootDir_ProjectCodeName;
        }

        private void txtRootDir_ProjectLocation_TextChanged(object sender, EventArgs e)
        {
            RootDir_ProjectLocation = txtRootDir_ProjectLocation.Text;
        }

        private void btnRootDir_ProjectLocation_Click(object sender, EventArgs e)
        {
            //
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            // Set the help text description for the FolderBrowserDialog.
            folderDialog.Description = "Select the directory that you want to use as the root";

            // Do not allow the user to create new files via the FolderBrowserDialog.
            folderDialog.ShowNewFolderButton = true;

            // Default to "My Computer" folder.
            folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            // Show the FolderBrowserDialog.
            DialogResult result = folderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtRootDir_ProjectLocation.Text = folderDialog.SelectedPath + @"\";
            }
        }

        private void optTypes_ConsoleProject_CheckedChanged(object sender, EventArgs e)
        {
            //
        }

        private void optTypes_LibraryProject_CheckedChanged(object sender, EventArgs e)
        {
            //
        }

        private void optTypes_SDL2Project_CheckedChanged(object sender, EventArgs e)
        {
            //
            if(optTypes_SDL2Project.Checked)
            {
                chkAddNet.Enabled = true;
                chkAddTtf.Enabled = true;
            }
            else
            {
                chkAddNet.Checked = false;
                chkAddTtf.Checked = false;
                chkAddNet.Enabled = false;
                chkAddTtf.Enabled = false;
            }
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            // Check user inputs
            if(txtRootDir_ProjectCodeName.Text.Equals(""))
            {
                MessageBox.Show("Project Code Name was empty", "Error");
                return;
            }
            if (txtRootDir_ProjectLocation.Text.Equals(""))
            {
                MessageBox.Show("Project Location was empty", "Error");
                return;
            }
            if (txtProject_SolutionName.Text.Equals(""))
            {
                MessageBox.Show("Solution Name was empty", "Error");
                return;
            }
            if (txtProject_ProjectName.Text.Equals(""))
            {
                MessageBox.Show("Project Name was empty", "Error");
                return;
            }

            // Set project type
            if (optTypes_ConsoleProject.Checked)
                ProjectTypes_SelectedProject = ProjectTypes.Console;
            if (optTypes_LibraryProject.Checked)
                ProjectTypes_SelectedProject = ProjectTypes.Library;
            if (optTypes_SDL2Project.Checked)
            {
                ProjectTypes_SelectedProject = ProjectTypes.SDL2;
                AddSDL2_net = chkAddNet.Checked;
                AddSDL2_ttf = chkAddTtf.Checked;
            }

            // Generate the project
            OutputForm output = new OutputForm(settings.GetDefaultShowProjectLocation());
            output.Show();
        }

        private void txtProject_ProjectName_TextChanged(object sender, EventArgs e)
        {
            txtProject_ProjectName.Text = txtProject_ProjectName.Text.Replace(' ', '_');
            Project_ProjectName = txtProject_ProjectName.Text;
        }

        private void txtProject_SolutionName_TextChanged(object sender, EventArgs e)
        {
            txtProject_SolutionName.Text = txtProject_SolutionName.Text.Replace(' ', '_');
            Project_SolutionName = txtProject_SolutionName.Text;
        }
    }
}
