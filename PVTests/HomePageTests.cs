using System;
using PVTestFramework1.Pages;
using NUnit.Framework;

namespace PVTests
{
    public class HomePageTests
    {
        [Test]
        public void CanGoToHomePage()
        {
            HomePage.GoTo();
            Assert.IsTrue(HomePage.IsAt(), "Failed to navigate to PreViser home page.");
        }

        [TearDown]
        public static void  CloseBrowser()
        {

        }
    }
}
