using PVTestFramework1.Selenium;

namespace PVTestFramework1.Pages
{
    public class HomePage
    {
        public static void GoTo()
        {
            Driver.Navigate("https://www.previser.com/");
        }

        public static bool IsAt()
        {
            if (Driver.Title == "Previser | Dental Risk and Periodontal Disease Analysis Software")
                return true;
            return false;
        }
    }
}
