using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LocalizationSample
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application

            // C#で画面定義
            //  var content = new MainView();
            // XAMLで画面定義
            LocalizationSample.Resources.AppResources.Culture = new System.Globalization.CultureInfo("en-US");
            var content = new XamlMainView();

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
