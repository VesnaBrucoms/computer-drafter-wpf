using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Computer_Drafter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void Application_Startup(object sender, StartupEventArgs e)
        {
            IniSettings.Ini.GetInstance.Read(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "//Computer Drafter", "settings");
        }

        public void Application_Exit(object sender, ExitEventArgs e)
        {
            IniSettings.Ini.GetInstance.Write(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "//Computer Drafter", "settings");
        }
    }
}
