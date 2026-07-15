namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Ensure database file and schema exist before any form or DB operation
            try
            {
                var db = new SpaceShooter.Database.Database();
                db.InitializeDatabase();
            }
            catch
            {
                // swallow exceptions here to avoid blocking startup; DB errors will surface on operations
            }

            Application.Run(new MAINMENU());

        }
    }
}