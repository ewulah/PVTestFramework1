using OpenQA.Selenium; 
using OpenQA.Selenium.Firefox; 
using System; 
using OpenQA.Selenium.Support.PageObjects;

namespace PVTestFramework1.Selenium
{
    public class Driver
    {
        protected static IWebDriver driver = new FirefoxDriver();

        public static void Initialize()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        public static string Title
        {
            get { return driver.Title; }
        }

        public static ISearchContext WebDriver
        {
            get { return driver; }
        }

        public static void Navigate(string url)
        {
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            driver.Url = url;
        }

        public static void Close()
        {
            driver.Quit();
        }
    }
}
