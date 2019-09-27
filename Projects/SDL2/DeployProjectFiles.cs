using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCreator.Projects.SDL2
{
    public partial class SDL2Project
    {
        public string DepDir; // Source directory for the deploy files

        // Copy all project files to the project.
        public void DeployAllFiles()
        {
            //
            DepDir = @"Projects\SDL2_Project\";
            
            Print("Deploying files:" + Environment.NewLine);

            // Deploy files ...
            DeployFile(@"Assets\test_image.png");
            DeployFile(@"Docs\Project_Setup_Specifications.txt");

            // Deploy libs ...
            AddLib_SDL2();
            AddLib_SDL2_gpu();
            AddLib_SDL2_mixer();
            if(AddSDL2_net)
                AddLib_SDL2_net();
            if(AddSDL2_ttf)
                AddLib_SDL2_ttf();

            // Deploy stuff for /Game
            File.Copy(DepDir + @"Assets\test_image.png", RootDir + @"\" + @"Game\test_image.png");
            //File.Copy(DepDir + @"Libs\SDL\lib\SDL2.dll", RootDir + @"\" + @"Game\SDL2.dll");
            //File.Copy(DepDir + @"Libs\SDL\lib\SDL2_d.dll", RootDir + @"\" + @"Game\SDL2_d.dll");
            //File.Copy(DepDir + @"Libs\SDL_gpu\lib\SDL2_gpu.dll", RootDir + @"\" + @"Game\SDL2_gpu.dll");
            //File.Copy(DepDir + @"Libs\SDL_gpu\lib\SDL2_gpu_d.dll", RootDir + @"\" + @"Game\SDL2_gpu_d.dll");
            
            Print("Deploying done" + Environment.NewLine);
        }

        private void DeployFile(string depFile)
        {
            Print("\t" + depFile);

            File.Copy(DepDir + depFile, RootDir + @"\" + depFile);

            Print("\t" + "Done" + Environment.NewLine);
        }

    }
}
