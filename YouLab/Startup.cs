using System;
using System.Threading;
using System.Windows.Forms;

namespace YouLab
{
    static class Startup
    {
        private static Mutex mutex = new Mutex(true, "mutex");

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                MainForm mainForm = new MainForm();
                Application.Run(mainForm);
            }
            else
            {
                MessageBox.Show("The program already running!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }            
        }
    }
}