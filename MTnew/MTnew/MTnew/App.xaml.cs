using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MTnew.View;

using Xamarin.Forms;

namespace MTnew
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage(); // new NavigationPage(new MTnew.MainPage());
            MainPage = new Loginpage();
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
