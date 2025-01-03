using HealthDataLogger_CSharp.utils;

namespace HealthDataLogger_CSharp
{
    internal static class Program
    {

        private static BasicInformationData bid = new BasicInformationData();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }

        public static BasicInformationData GetBasicInformationData()
        {
            return bid;
        }
    }
}