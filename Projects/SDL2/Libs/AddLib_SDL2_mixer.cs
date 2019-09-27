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
        public void AddLib_SDL2_mixer()
        {
            // Adding SDL2_mixer library to the project
            Print("Adding SDL2_mixer library to the project:" + Environment.NewLine);

            // Create all directories for external library
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_mixer");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_mixer\include");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_mixer\lib");
            Directory.CreateDirectory(RootDir + @"\Libs\SDL2_mixer\lib\licenses");

            // Copy all files to /Libs/SDL2_mixer
            string sourceDirectory = DepDir + @"Libs\SDL2_mixer";
            string archiveDirectory = RootDir + @"\" + @"Libs\SDL2_mixer";

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
            Print("Copying DLLs: SDL2_mixer ");
            File.Copy(DepDir + @"Libs\SDL2_mixer\lib\SDL2_mixer.dll", RootDir + @"\" + @"Game\SDL2_mixer.dll");
            File.Copy(DepDir + @"Libs\SDL2_mixer\lib\SDL2_mixer_d.dll", RootDir + @"\" + @"Game\SDL2_mixer_d.dll");
            File.Copy(DepDir + @"Libs\SDL2_mixer\lib\libogg-0.dll", RootDir + @"\" + @"Game\libogg-0.dll");
            File.Copy(DepDir + @"Libs\SDL2_mixer\lib\libvorbis-0.dll", RootDir + @"\" + @"Game\libvorbis-0.dll");
            File.Copy(DepDir + @"Libs\SDL2_mixer\lib\libvorbisfile-3.dll", RootDir + @"\" + @"Game\libvorbisfile-3.dll");
            Print("Done" + Environment.NewLine);

            // Deploy licenses
            Print("Deploy licenses: SDL2_mixer ");
            File.Copy(DepDir + @"Libs\SDL2_mixer\lib\licenses\LICENSE.SDL2_mixer.txt", RootDir + @"\" + @"Game\Licenses\LICENSE.SDL2_mixer.txt");
            File.Copy(DepDir + @"Libs\SDL2_mixer\lib\licenses\LICENSE.ogg-vorbis.txt", RootDir + @"\" + @"Game\Licenses\LICENSE.ogg-vorbis.txt");
            Print("Done" + Environment.NewLine);
            
            Print(Environment.NewLine + "Done" + Environment.NewLine);
        }
    }
}
