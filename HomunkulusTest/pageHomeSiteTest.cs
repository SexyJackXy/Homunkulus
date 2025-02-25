using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using System.IO;
using System.Linq;
using System.Threading;

namespace FrontEndTests
{
    [TestFixture]
    public class pageHomeSiteTest
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
        public  void ButtonClick_CreateBackup_ShouldSucced()
        {
            var button = page.Get<Button>(SearchCriteria.ByAutomationId("create_btn"));
            button.Click();
            System.Threading.Thread.Sleep(10000);

            var allWindows = app.GetWindows();
            var windowName = allWindows.FirstOrDefault().Name;

            Assert.AreEqual(windowName, "pageBackupConfiguration");

            var breakHere = string.Empty;
        }

        [Test]
        public void ButtonClick_ShowBackup_ShouldSucced()
        {
            var button = page.Get<Button>(SearchCriteria.ByAutomationId("show_backup_btn"));
            button.Click();
            System.Threading.Thread.Sleep(10000);

            var allWindows = app.GetWindows();
            var windowName = allWindows.FirstOrDefault().Name;

            Assert.AreEqual(windowName, "pagePlanManagement");

            var breakHere = string.Empty;
        }

        [TearDown]
        public void Cleanup()
        {
            app.Close();
        }
    }
}