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
        // Generate Main.cpp file
        public void CreateMainCppFile()
        {
            Print("Creating the Main.cpp file: ");

            using (StreamWriter sw = new StreamWriter(RootDir + @"\Source\Main.cpp"))
            {
                sw.WriteLine("#include \"SDL_gpu.h\"");
                sw.WriteLine("");
                sw.WriteLine("int main(int argc, char** argv)");
                sw.WriteLine("{");
                sw.WriteLine("\t" + "// Tell us whenever something bad happens");
                sw.WriteLine("\t" + "GPU_SetDebugLevel(GPU_DEBUG_LEVEL_MAX);");
                sw.WriteLine("\t" + "");
                sw.WriteLine("\t" + "// Get a 800x600 window to render to");
                sw.WriteLine("\t" + "GPU_Target* screen = GPU_Init(800, 600, GPU_DEFAULT_INIT_FLAGS);");
                sw.WriteLine("\t" + "");
                sw.WriteLine("\t" + "// Did initialization fail?");
                sw.WriteLine("\t" + "if (screen == NULL)");
                sw.WriteLine("\t\t" + "return 1;");
                sw.WriteLine("\t" + "");
                sw.WriteLine("\t" + "// Load the image...");
                sw.WriteLine("\t" + "GPU_Image* image = GPU_LoadImage(\"test_image.png\");");
                sw.WriteLine("\t" + "if (image == NULL)");
                sw.WriteLine("\t\t" + "return 2;");
                sw.WriteLine("\t" + "");
                sw.WriteLine("\t" + "SDL_Event event;");
                sw.WriteLine("\t" + "Uint8 done = 0;");
                sw.WriteLine("\t" + "while (!done)");
                sw.WriteLine("\t" + "{");
                sw.WriteLine("\t\t" + "while (SDL_PollEvent(&event))");
                sw.WriteLine("\t\t" + "{");
                sw.WriteLine("\t\t\t" + "if (event.type == SDL_QUIT)");
                sw.WriteLine("\t\t\t\t" + "done = 1;");
                sw.WriteLine("\t\t" + "}");
                sw.WriteLine("\t\t" + "");
                sw.WriteLine("\t\t" + "// Clear the screen");
                sw.WriteLine("\t\t" + "GPU_Clear(screen);");
                sw.WriteLine("\t\t" + "");
                sw.WriteLine("\t\t" + "// Remember that GPU_Blit() draws the image *centered* at the given position");
                sw.WriteLine("\t\t" + "GPU_Blit(image, NULL, screen, image->w / 2, image->h / 2);");
                sw.WriteLine("\t\t" + "");
                sw.WriteLine("\t\t" + "// Show the result in the window");
                sw.WriteLine("\t\t" + "GPU_Flip(screen);");
                sw.WriteLine("\t" + "}");
                sw.WriteLine("\t" + "");
                sw.WriteLine("\t" + "// Shutdown SDL2 and SDL_gpu");
                sw.WriteLine("\t" + "GPU_Quit();");
                sw.WriteLine("\t" + "return 0;");
                sw.WriteLine("}");
            }

            Print("Done" + Environment.NewLine);
        }
    }
}
