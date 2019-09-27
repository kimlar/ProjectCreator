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
        // Generate Main.cpp file
        public void CreateMainCppFile()
        {
            Print("Creating the Main.cpp file: ");

            using (StreamWriter sw = new StreamWriter(RootDir + @"\Source\Main.cpp"))
            {
                sw.WriteLine("#include <iostream>");
                sw.WriteLine("");
                sw.WriteLine("int main(int argc, char *argv[])");
                sw.WriteLine("{");
                sw.WriteLine("\t" + "std::cout << \"OK\" << std::endl;");
                sw.WriteLine("\t");
                sw.WriteLine("\t" + "system(\"pause>nul\"); // Wait for key press");
                sw.WriteLine("\t");
                sw.WriteLine("\t" + "return 0;");
                sw.WriteLine("}");
            }

            Print("Done" + Environment.NewLine);
        }
    }
}
