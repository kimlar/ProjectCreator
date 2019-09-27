using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCreator.Projects.SDL2
{
    public partial class SDL2Project
    {
        // Add external library to the project
        public void AddLib_SDL2()
        {
            // Adding SDL2 library to the project
            Print("Adding SDL2 library to the project:" + Environment.NewLine);

            // Create all directories for external library
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2\include");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2\lib");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2\lib\licenses");

            // Copy all files to /Libs/SDL2
            string sourceDirectory = DepDir + @"Libs\SDL2";
            string archiveDirectory = RootDir + @"\" + @"Libs\SDL2";

            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.*", SearchOption.AllDirectories);

                foreach (string currentFile in txtFiles)
                {
                    string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    Print("\t\t" + archiveDirectory + @"\" + fileName + Environment.NewLine);
                    File.Copy(sourceDirectory + @"\" + fileName, archiveDirectory + @"\" + fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception occurred: " + ex.Message, "ERROR");
            }

            // Deploy stuff for /Game
            Print("Copying DLLs: SDL2 ");
            File.Copy(DepDir + @"Libs\SDL2\lib\SDL2.dll", RootDir + @"\" + @"Game\SDL2.dll");
            File.Copy(DepDir + @"Libs\SDL2\lib\SDL2_d.dll", RootDir + @"\" + @"Game\SDL2_d.dll");
            Print("Done" + Environment.NewLine);

            // Deploy licenses
            Print("Deploy licenses: SDL2 ");
            File.Copy(DepDir + @"Libs\SDL2\lib\licenses\LICENSE.SDL2.txt", RootDir + @"\" + @"Game\Licenses\LICENSE.SDL2.txt");
            Print("Done" + Environment.NewLine);

            Print(Environment.NewLine + "Done" + Environment.NewLine);
        }
    }
}
