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
        // Generate Main.cpp file
        public void CreateTestMainCppFile()
        {
            Print("Creating the test Main.cpp file: ");

            using (StreamWriter sw = new StreamWriter(TestDir + @"\Source\Main.cpp"))
            {
                sw.WriteLine("#include <iostream>");
                sw.WriteLine("");
                sw.WriteLine("#include \"" + ProjectName + ".h\"");
                sw.WriteLine("");
                sw.WriteLine("int main(int argc, char *argv[])");
                sw.WriteLine("{");
                sw.WriteLine("\t" + "std::cout << \"OK\" << std::endl;");
                sw.WriteLine("\t");
                sw.WriteLine("\t" + "PrintNumber(5); // From the library");
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
