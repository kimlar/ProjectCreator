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
        // Creates all directories for the whole project
        public void CreateDirectories()
        {
            CreateRootDir();
            CreateSubDirs();
        }

        // Create Project Code Name directory
        private void CreateRootDir()
        {
            Print("Project directory structure:" + Environment.NewLine);

            try
            {
                if (Directory.Exists(RootDir))
                {
                    System.Windows.Forms.MessageBox.Show("Directory already exists! Aborting.", "ERROR");
                    outputForm.Close();
                    return;
                }

                Directory.CreateDirectory(RootDir);
                Print("/" + Environment.NewLine);
                Print(RootName + Environment.NewLine);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " Aborting.", "ERROR");
                outputForm.Close();
            }
        }

        // Create sub-directories
        private void CreateSubDirs()
        {
            /*
                Create all sub directories for this project:

                        /ProjectName
                            /App
                            /Assets
                            /Docs
                            /Libs
                            /Source
                                /Project
                            /Temp
            */

            try
            {
                Print("\t/" + Environment.NewLine);

                Directory.CreateDirectory(RootDir + @"\App");
                Print("\tApp" + Environment.NewLine);

                Directory.CreateDirectory(RootDir + @"\Assets");
                Print("\tAssets" + Environment.NewLine);

                Directory.CreateDirectory(RootDir + @"\Docs");
                Print("\tDocs" + Environment.NewLine);

                Directory.CreateDirectory(RootDir + @"\Libs");
                Print("\tLibs" + Environment.NewLine);

                Directory.CreateDirectory(RootDir + @"\Source");
                Print("\tSource" + Environment.NewLine);

                Directory.CreateDirectory(RootDir + @"\Source\Project");
                Print("\t\t/" + Environment.NewLine);
                Print("\t\tProject" + Environment.NewLine);

                Directory.CreateDirectory(RootDir + @"\Temp");
                Print("\tTemp" + Environment.NewLine);

                Print(Environment.NewLine);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " Aborting.", "ERROR");
                outputForm.Close();
            }
        }
    }
}
