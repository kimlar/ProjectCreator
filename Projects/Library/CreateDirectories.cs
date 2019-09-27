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
                            /Assets
                            /Docs
                            /Lib
                            /Libs
                            /Source
                                /Project
                                /Tester
                            /Temp
            */

            try
            {
                Print("\t/" + Environment.NewLine);

                Directory.CreateDirectory(RootDir + @"\Assets");
                Print("\tAssets" + Environment.NewLine);

                Directory.CreateDirectory(RootDir + @"\Docs");
                Print("\tDocs" + Environment.NewLine);

                Directory.CreateDirectory(RootDir + @"\Lib");
                Print("\tLib" + Environment.NewLine);

                Directory.CreateDirectory(RootDir + @"\Libs");
                Print("\tLibs" + Environment.NewLine);

                Directory.CreateDirectory(RootDir + @"\Source");
                Print("\tSource" + Environment.NewLine);

                Directory.CreateDirectory(RootDir + @"\Source\Project");
                Print("\t\t/" + Environment.NewLine);
                Print("\t\tProject" + Environment.NewLine);

                // Tester project
                CreateTestDirs();

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

        // Create test project directory
        private void CreateTestDirs()
        {
            /*
                Create all sub directories for the test project:

                        /ProjectName     <----- RootDir
                            /Source                             
                                /Tester  <----- starts here
                                    /{LibName}Test
                                        /App
                                        /Assets
                                        /Docs
                                        /Libs
                                        /Source
                                            /Project

                NOTE: The /Temp directory is located at /RootDir/Temp/Tester
            */

            try
            {
                Print("\t\tTester" + Environment.NewLine);
                Print("\t\t\t" + "/" + Environment.NewLine);
                Print("\t\t\t" + TestName + Environment.NewLine);
                Print("\t\t\t\t" + "/" + Environment.NewLine);

                Directory.CreateDirectory(TestDir + @"\App");
                Print("\t\t\t\t" + "App" + Environment.NewLine);

                Directory.CreateDirectory(TestDir + @"\Assets");
                Print("\t\t\t\t" + "Assets" + Environment.NewLine);

                Directory.CreateDirectory(TestDir + @"\Docs");
                Print("\t\t\t\t" + "Docs" + Environment.NewLine);

                Directory.CreateDirectory(TestDir + @"\Libs");
                Print("\t\t\t\t" + "Libs" + Environment.NewLine);

                Directory.CreateDirectory(TestDir + @"\Source");
                Print("\t\t\t\t" + "Source" + Environment.NewLine);

                Directory.CreateDirectory(TestDir + @"\Source\Project");
                Print("\t\t\t\t\t" + "/" + Environment.NewLine);
                Print("\t\t\t\t\t" + "Project" + Environment.NewLine);

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
