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
        public void AddLib_SDL2_net()
        {
            // Adding SDL2_net library to the project
            Print("Adding SDL2_net library to the project:" + Environment.NewLine);

            // Create all directories for external library
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_net");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_net\include");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_net\lib");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_net\lib\licenses");

            // Copy all files to /Libs/SDL2_net
            string sourceDirectory = DepDir + @"Libs\SDL2_net";
            string archiveDirectory = RootDir + @"\" + @"Libs\SDL2_net";

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
            Print("Copying DLLs: SDL2_net ");
            File.Copy(DepDir + @"Libs\SDL2_net\lib\SDL2_net.dll", RootDir + @"\" + @"Game\SDL2_net.dll");
            File.Copy(DepDir + @"Libs\SDL2_net\lib\SDL2_net_d.dll", RootDir + @"\" + @"Game\SDL2_net_d.dll");
            Print("Done" + Environment.NewLine);

            // Deploy licenses
            Print("Deploy licenses: SDL2_net ");
            File.Copy(DepDir + @"Libs\SDL2_net\lib\licenses\LICENSE.SDL2_net.txt", RootDir + @"\" + @"Game\Licenses\LICENSE.SDL2_net.txt");
            Print("Done" + Environment.NewLine);
            
            Print(Environment.NewLine + "Done" + Environment.NewLine);
        }
    }
}
