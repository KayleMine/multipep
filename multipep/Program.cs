using System;
using System.IO;
using System.Windows.Forms;

namespace multipep
{
    internal static class Program
    {
        private const string ApepFileName = "apep.exe";
        private const string ApepIniFileName = "Apep.ini";

        [STAThread]
        static void Main()
        {
            string currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string apepFilePath = Path.Combine(currentDirectory, ApepFileName);
            string apepIniFilePath = Path.Combine(currentDirectory, ApepIniFileName);

            if (!File.Exists(apepFilePath))
            {
                MessageBox.Show($"Could not find {ApepFileName} near the application.\nPlace me near Apep!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(apepIniFilePath))
            {
                MessageBox.Show($"Could not find {ApepIniFileName} near the application.\nSetup Apep first, config not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }
    }
}