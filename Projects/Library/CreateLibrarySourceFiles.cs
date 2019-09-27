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
        //
        public void CreateLibrarySourceFiles()
        {
            CreateFile_library_h();
            CreateFile_library_cpp();
        }

        private void CreateFile_library_h()
        {
            Print("Creating the " + ProjectName + ".h file: ");

            using (StreamWriter sw = new StreamWriter(RootDir + @"\Source\" + ProjectName + ".h"))
            {
                sw.WriteLine("#pragma once");
                sw.WriteLine("");
                sw.WriteLine("// When making static library there is a couple of ways you could do it:");
                sw.WriteLine("//");
                sw.WriteLine("// 1. Use a class inside the library.");
                sw.WriteLine("//");
                sw.WriteLine("// 2. Use functions inside the lib. Pure C++ style.");
                sw.WriteLine("//");
                sw.WriteLine("// 3. Use functions inside the lib. Pure C style. (So you also could use it with other languages).");
                sw.WriteLine("//");
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("// Print a number");
                sw.WriteLine("void PrintNumber(int number);");
            }

            Print("Done" + Environment.NewLine);
        }

        private void CreateFile_library_cpp()
        {
            Print("Creating the " + ProjectName + ".cpp file: ");

            using (StreamWriter sw = new StreamWriter(RootDir + @"\Source\" + ProjectName + ".cpp"))
            {
                sw.WriteLine("#include \"" + ProjectName + ".h\"");
                sw.WriteLine("");
                sw.WriteLine("#include <iostream>");
                sw.WriteLine("");
                sw.WriteLine("// Print a number");
                sw.WriteLine("void PrintNumber(int number)");
                sw.WriteLine("{");
                sw.WriteLine("\t" + "std::cout << number << std::endl;");
                sw.WriteLine("}");
            }

            Print("Done" + Environment.NewLine);
        }
    }
}
