using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace AppCenter.DemoApp.UITests.Pages
{
    public class MainPage : BasePage
    {
        public void AppStarted()
        {
            app.Screenshot("Main Page");
        }
    }
}