namespace TcddBiletExist
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
            //if (FormName == "Mail")
            //{
            //    Application.Run(new Form1());
            //}
            //else
            //{
            Application.Run(new OtoMail());
            //}
        }
    }
}