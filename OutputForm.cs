using ProjectCreator.Projects.Console;
using ProjectCreator.Projects.Library;
using ProjectCreator.Projects.SDL2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCreator
{
    public partial class OutputForm : Form
    {
        // Static form. Null if no form created yet.
        private static OutputForm outputForm = null;

        // WORKAROUND: To make the text box scroll to the end/bottom.
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(System.IntPtr hWnd, int wMsg, System.IntPtr wParam, System.IntPtr lParam);
        private const int WM_VSCROLL = 0x115;
        private const int SB_BOTTOM = 7;


        public OutputForm(bool showProjectLocation)
        {
            InitializeComponent();
            outputForm = this;

            // Settings
            chkShowProject.Checked = showProjectLocation;
        }

        private void OutputForm_Load(object sender, EventArgs e)
        {
            this.Text = "Output - " + MainForm.RootDir_ProjectCodeName;
            Print("Generating..." + Environment.NewLine + Environment.NewLine);

            // Print the projects directory location
            Print("Project location: " + MainForm.RootDir_ProjectLocation + Environment.NewLine);

            // Generate selected project type
            switch (MainForm.ProjectTypes_SelectedProject)
            {
                case MainForm.ProjectTypes.Console:
                    ConsoleProject consoleProject = new ConsoleProject();
                    consoleProject.Generate(ref outputForm);
                    break;

                case MainForm.ProjectTypes.Library:
                    LibraryProject libraryProject = new LibraryProject();
                    libraryProject.Generate(ref outputForm);
                    break;

                case MainForm.ProjectTypes.SDL2:
                    SDL2Project sdl2Project = new SDL2Project();
                    sdl2Project.Generate(ref outputForm);
                    break;

                default:
                    Print("ERROR: Unknown project. Aborting!" + Environment.NewLine);
                    MessageBox.Show("Unknown project. Aborting!", "ERROR");
                    return;
            }

            // Finished
            GenerationComplete();
        }

        private void GenerationComplete()
        {
            Print(Environment.NewLine + "COMPLETE" + Environment.NewLine);

            // WORKAROUND: To make the text box scroll to the end/bottom
            ScrollToBottom(txtOutput);

            // Ready the button
            btnComplete.ForeColor = Color.ForestGreen;
            btnComplete.Enabled = true;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            // Check if user wants to show the project file location at exit this program
            if(chkShowProject.Checked)
            {
                Process.Start("explorer", MainForm.RootDir_ProjectLocation + @"\Source\Project");
            }

            Application.Exit();
        }

        public void Print(string text)
        {
            txtOutput.AppendText(text);
        }

        // WORKAROUND: To make the text box scroll to the end/bottom.
        public static void ScrollToBottom(System.Windows.Forms.TextBox tb)
        {
            if (System.Environment.OSVersion.Platform != System.PlatformID.Unix)
                SendMessage(tb.Handle, WM_VSCROLL, new System.IntPtr(SB_BOTTOM), System.IntPtr.Zero);
        }

        private void chkShowProject_CheckedChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
