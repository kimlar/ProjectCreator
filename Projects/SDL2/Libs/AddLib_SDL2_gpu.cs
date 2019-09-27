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
        public void AddLib_SDL2_gpu()
        {
            // Adding SDL2_gpu library to the project
            Print("Adding SDL2_gpu library to the project:" + Environment.NewLine);

            // Create all directories for external library
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_gpu");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_gpu\include");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_gpu\lib");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_gpu\lib\licenses");

            // Copy all files to /Libs/SDL2_gpu
            string sourceDirectory = DepDir + @"Libs\SDL2_gpu";
            string archiveDirectory = RootDir + @"\" + @"Libs\SDL2_gpu";

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
            Print("Copying DLLs: SDL2_gpu ");
            File.Copy(DepDir + @"Libs\SDL2_gpu\lib\SDL2_gpu.dll", RootDir + @"\" + @"Game\SDL2_gpu.dll");
            File.Copy(DepDir + @"Libs\SDL2_gpu\lib\SDL2_gpu_d.dll", RootDir + @"\" + @"Game\SDL2_gpu_d.dll");
            Print("Done" + Environment.NewLine);

            // Deploy licenses
            Print("Deploy licenses: SDL2_gpu ");
            File.Copy(DepDir + @"Libs\SDL2_gpu\lib\licenses\LICENSE.SDL2_gpu.txt", RootDir + @"\" + @"Game\Licenses\LICENSE.SDL2_gpu.txt");
            Print("Done" + Environment.NewLine);
            
            Print(Environment.NewLine + "Done" + Environment.NewLine);
        }
    }
}
