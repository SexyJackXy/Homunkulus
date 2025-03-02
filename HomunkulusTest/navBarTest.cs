using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using System.IO;

namespace FrontEndTests
{
    [TestFixture]
    public class NavbarTest
    {
        private TestStack.White.Application app;
        private Window page;

        [SetUp]
        public void Setup()
        {
            string appPath = Path.GetFullPath(@"C:\Users\Tim\Documents\GitHub\Homunkulus\Homunkulus\bin\Debug\net6.0-windows\Homunkulus.exe");
            app = TestStack.White.Application.Launch(appPath);
            page = app.GetWindow("Landingpage");
        }

        [Test]
        public void Basic_SideSwitch_ShouldSucced()
        {
            //homeSite
            var homeButtonHome = page.Get<UIItem>(SearchCriteria.ByAutomationId("home_pbox"));
            var createButtonHome = page.Get<UIItem>(SearchCriteria.ByAutomationId("create_pbox"));
            var planButtonHome = page.Get<UIItem>(SearchCriteria.ByAutomationId("plans_pbox"));
            var windowName = string.Empty;

            homeButtonHome.Click();
            windowName = app.GetWindows().FirstOrDefault().Name;
            //Assert.AreEqual(windowName, "Landingpage");

            System.Threading.Thread.Sleep(1000);

            createButtonHome.Click();
            windowName = app.GetWindows().FirstOrDefault().Name;
            Assert.AreEqual(windowName, "Landingpage");
        }

        [TearDown]
        public void Cleanup()
        {
            app.Close();
        }
    }
}
