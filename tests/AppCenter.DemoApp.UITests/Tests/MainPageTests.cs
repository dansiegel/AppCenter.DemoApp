using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using AppCenter.DemoApp.UITests.Pages;

namespace AppCenter.DemoApp.UITests.Tests
{
    public class MainPageTests : AbstractSetup
    {
        public Tests(Platform platform)
            : base(platform)
        {
        }

        [Test]
        public void DidAppStart()
        {
            var mainPage = new MainPage();
            mainPage.AppStarted();
        }
    }
}
