using System;
using System.Windows.Forms;
using Trajectory;

namespace trajectory
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and run the main form of your application
            Application.Run(new Trajectory.MainMenu());
        }
    }
}