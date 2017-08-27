using System;
using PVTestFramework1.Pages;
using NUnit.Framework;
using PVTestFramework1.Selenium;

namespace PVTests
{
    [TestFixture]
    public class HomePageTests
    {
        /*
        [OneTimeSetUp]
        public void Instantiate_Grid()
        {
            //Driver.Initialize_Grid("firefox");
            Driver.Initialize_Grid("ie");
        }
        */
        [TestCase("firefox")]
        [TestCase("ie")]
        public void CanGoToHomePage(string browser)
        {
            Driver.Initialize_Grid(browser);
            HomePage.GoTo();
            Assert.IsTrue(HomePage.IsAt(), "Failed to navigate to PreViser home page.");
            Driver.Close();
        }

        [Test]
        [Parallelizable]
        public void CanGoToHomePage_ff()
        {
            Driver.Initialize_Grid("firefox");
            HomePage.GoTo();
            Assert.IsTrue(HomePage.IsAt(), "Failed to navigate to PreViser home page.");
            Driver.Close();
        }

        [Test]
        [Parallelizable]
        public void CanGoToHomePage_ie()
        {
            Driver.Initialize_Grid("ie");
            HomePage.GoTo();
            Assert.IsTrue(HomePage.IsAt(), "Failed to navigate to PreViser home page.");
            Driver.Close();
        }

        [TearDown]
        public static void  CloseBrowser()
        {
            //Driver.Close();
        }
    }
}
