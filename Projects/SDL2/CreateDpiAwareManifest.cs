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
        // Generate project filter file (.vcxproj.filters)
        public void CreateDpiAwareManifest()
        {
            Print("Creating the DeclareDPIAware.manifest file: ");

            using (StreamWriter sw = new StreamWriter(RootDir + @"\Source\Project\DeclareDPIAware.manifest"))
            {
                sw.WriteLine("<assembly xmlns=\"urn:schemas-microsoft-com:asm.v1\" manifestVersion=\"1.0\" xmlns:asmv3=\"urn:schemas-microsoft-com:asm.v3\" >");
                sw.WriteLine("  <asmv3:application>");
                sw.WriteLine("    <asmv3:windowsSettings xmlns=\"http://schemas.microsoft.com/SMI/2005/WindowsSettings\">");
                sw.WriteLine("      <dpiAware>true</dpiAware>");
                sw.WriteLine("    </asmv3:windowsSettings>");
                sw.WriteLine("  </asmv3:application>");
                sw.WriteLine("</assembly>");
            }

            Print("Done" + Environment.NewLine);
        }
    }
}
