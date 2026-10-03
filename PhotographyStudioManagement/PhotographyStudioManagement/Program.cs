using PhotographyStudioManagement.Data;

namespace PhotographyStudioManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            DatabaseHelper.InitializeDatabase();

            Application.Run(new Main());
        }
    }
}