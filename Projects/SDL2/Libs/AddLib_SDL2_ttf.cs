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
        public void AddLib_SDL2_ttf()
        {
            // Adding SDL2_ttf library to the project
            Print("Adding SDL2_ttf library to the project:" + Environment.NewLine);

            // Create all directories for external library
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_ttf");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_ttf\include");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_ttf\lib");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_ttf\lib\licenses");

            // Copy all files to /Libs/SDL2_ttf
            string sourceDirectory = DepDir + @"Libs\SDL2_ttf";
            string archiveDirectory = RootDir + @"\" + @"Libs\SDL2_ttf";

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
            Print("Copying DLLs: SDL2_ttf ");
            File.Copy(DepDir + @"Libs\SDL2_ttf\lib\SDL2_ttf.dll", RootDir + @"\" + @"Game\SDL2_ttf.dll");
            File.Copy(DepDir + @"Libs\SDL2_ttf\lib\SDL2_ttf_d.dll", RootDir + @"\" + @"Game\SDL2_ttf_d.dll");
            Print("Done" + Environment.NewLine);

            // Deploy licenses
            Print("Deploy licenses: SDL2_ttf ");
            File.Copy(DepDir + @"Libs\SDL2_ttf\lib\licenses\LICENSE.SDL2_ttf.txt", RootDir + @"\" + @"Game\Licenses\LICENSE.SDL2_ttf.txt");
            File.Copy(DepDir + @"Libs\SDL2_ttf\lib\licenses\LICENSE.freetype.txt", RootDir + @"\" + @"Game\Licenses\LICENSE.freetype.txt");
            File.Copy(DepDir + @"Libs\SDL2_ttf\lib\licenses\LICENSE.zlib.txt", RootDir + @"\" + @"Game\Licenses\LICENSE.zlib.txt");
            Print("Done" + Environment.NewLine);
            
            Print(Environment.NewLine + "Done" + Environment.NewLine);
        }
    }
}
