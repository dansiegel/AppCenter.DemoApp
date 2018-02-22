using System;

namespace AppCenter.DemoApp.Helpers
{
    public static class AppConstants
    {
        // Put constants here that are not of a sensitive nature

        public static string AppCenterStart
        {
            get
            {
                string startup = string.Empty;

                if (Guid.TryParse(Secrets.AppCenter_iOS_Secret, out Guid iOSSecret))
                {
                    startup += $"ios={iOSSecret};";
                }

                if (Guid.TryParse(Secrets.AppCenter_Android_Secret, out Guid AndroidSecret))
                {
                    startup += $"android={AndroidSecret};";
                }

                return startup;
            }
        }
    }
}
