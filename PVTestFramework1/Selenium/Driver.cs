using OpenQA.Selenium; 
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System; 
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Remote;

namespace PVTestFramework1.Selenium
{
    public class Driver
    {
        protected static RemoteWebDriver driver;
        //protected static IWebDriver driver = new FirefoxDriver();

        public static void Initialize_Local()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
       
        public static void Initialize_Grid(string browser)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();

            switch (browser)
            {
                case "firefox":
                    capabilities = DesiredCapabilities.Firefox();
                    capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
                    break;
                case "chrome":
                    capabilities = DesiredCapabilities.Chrome();
                    capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
                    break;
                case "edge":
                    capabilities = DesiredCapabilities.Edge();
                    capabilities.SetCapability(CapabilityType.BrowserName, "edge");
                    break;
                case "ie":
                    capabilities = DesiredCapabilities.InternetExplorer();
                    capabilities.SetCapability(CapabilityType.BrowserName, "internet explorer");
                    break;
                default:
                    capabilities = DesiredCapabilities.Firefox();
                    capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
                    break;
            }


            //capabilities = DesiredCapabilities.Firefox();
            //capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));

            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);
            //driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

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
