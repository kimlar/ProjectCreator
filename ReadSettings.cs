using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCreator
{
    public class ReadSettings
    {
        private string DefaultProjectDir;
        private int DefaultProjectType;
        private bool DefaultShowProjectLocation;

        public ReadSettings()
        {
            try
            {
                // Read the file and display it line by line.
                int count = 0;
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader("Settings.txt");
                while ((line = file.ReadLine()) != null)
                {
                    // Not a setting line, skipping
                    if (line == "" || line[0] == '#')
                        continue;

                    // Found a setting line
                    switch (count++)
                    {
                        case 0:
                            DefaultProjectDir = line;
                            break;
                        case 1:
                            DefaultProjectType = Int32.Parse(line);
                            break;
                        case 2:
                            DefaultShowProjectLocation = (line == "0" ? false : true);
                            break;
                    }
                }
                file.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("We got an exception: " + ex, "Error reading Settings.txt");
            }
        }

        public string GetDefaultProjectDir()
        {
            return DefaultProjectDir;
        }

        public int GetDefaultProjectType()
        {
            return DefaultProjectType;
        }

        public bool GetDefaultShowProjectLocation()
        {
            return DefaultShowProjectLocation;
        }
    }
}
