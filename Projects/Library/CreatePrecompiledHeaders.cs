﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCreator.Projects.Library
{
    public partial class LibraryProject
    {
        // Generate the Precompiled Headers (pch.h and pch.cpp)
        public void CreatePrecompiledHeaders()
        {
            CreateFile_pch_h();
            CreateFile_pch_cpp();
        }

        private void CreateFile_pch_h()
        {
            Print("Creating the pch.h file (Precompiled Headers): ");

            using (StreamWriter sw = new StreamWriter(RootDir + @"\Source\pch.h"))
            {
                sw.WriteLine("// Precompiled Headers");
                sw.WriteLine("//");
                sw.WriteLine("//\t\tWhy:");
                sw.WriteLine("//\t\t\tFaster compile speed (about 30% faster).");
                sw.WriteLine("//\t\t\tWith PCH, all the headers that are included into pch.h will only compile if changed.");
                sw.WriteLine("//\t\t\tSo ONLY add header files that almost NEVER change, typically C-headers, C++ headers.");
                sw.WriteLine("//");
                sw.WriteLine("//\t\tAdd:");
                sw.WriteLine("//\t\t\tpch.h:\t\tContains all of the precompiled header files.");
                sw.WriteLine("//\t\t\tpch.cpp:\tDon't forget change to \"/Yc\" flag. DO NOT EDIT THIS FILE EVER !!!");
                sw.WriteLine("//");
                sw.WriteLine("//\t\tUse:");
                sw.WriteLine("//\t\t\t\"/Yu\"\tfor all *.cpp files (except for pch.cpp)");
                sw.WriteLine("//\t\t\t\"/Yc\"\tfor only pch.cpp");
                sw.WriteLine("//");
                sw.WriteLine("//\t\tPro tip:");
                sw.WriteLine("//\t\t\tGo to \"C/C++->Advanced->Forced Include File\" and add pch.h");
                sw.WriteLine("//\t\t\t\t\t(compiler adds pch.h to every *.cpp).");
                sw.WriteLine("//");
                sw.WriteLine("//\t\tAll *.cpp files that uses the \"/Yu\" flag must have a #include \"pch.h\" which MUST be");
                sw.WriteLine("//\t\t\t\t\tthe very first one to be included into the *.cpp file (top most one).");
                sw.WriteLine("//\t\t\t\t\tNOTE: Because of \"C/C++->Advanced->Forced Include File\" has pch.h included");
                sw.WriteLine("//\t\t\t\t\t\t  You DO NOT need to include pch.h because compiler do it automatically.");
                sw.WriteLine("//");
                sw.WriteLine("#pragma once");
                sw.WriteLine("#pragma message(\"Compiling precompiled headers. Why is a file changed? (BAD) \\n\")");
                sw.WriteLine("");
                sw.WriteLine("//");
                sw.WriteLine("// C Header Files");
                sw.WriteLine("//");
                sw.WriteLine("#include <cstdlib>");
                sw.WriteLine("#include <ctime>");
                sw.WriteLine("");
                sw.WriteLine("//");
                sw.WriteLine("// C++ Header Files");
                sw.WriteLine("//");
                sw.WriteLine("#include <string>");
                sw.WriteLine("#include <vector>");
                sw.WriteLine("#include <memory>");
                sw.WriteLine("");
                sw.WriteLine("//");
                sw.WriteLine("// External Library (BAD or GOOD idea to include library headers?)");
                sw.WriteLine("//");
                sw.WriteLine("//#include \"SDL2.h\"");
                sw.WriteLine("");
                sw.WriteLine("//");
                sw.WriteLine("// Project Headers (DO NOT add header files that are subject to changes.)");
                sw.WriteLine("//");
                sw.WriteLine("//#include \"example.h\"");
            }

            Print("Done" + Environment.NewLine);
        }

        private void CreateFile_pch_cpp()
        {
            Print("Creating the pch.cpp file (Precompiled Headers): ");

            using (StreamWriter sw = new StreamWriter(RootDir + @"\Source\pch.cpp"))
            {
                sw.WriteLine("// DO NOT EDIT THIS FILE !!!	For more info look at pch.h");
                sw.WriteLine("#include \"pch.h\"");
            }

            Print("Done" + Environment.NewLine);
        }
    }
}
