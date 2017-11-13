using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;

        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Repl();
            //app.Screenshot("First screen.");
           
        }
        [Test]
        public void TestAddNewItem()
        {
            app.Tap(c=>c.Marked("AddId"));
            app.EnterText(c => c.Marked("TextId"), "Test Item 1");
            app.EnterText(c => c.Marked("DescriptionId"), "Test Description 1");
            app.Tap(c=>c.Marked("SaveId"));
        }
    }
}

