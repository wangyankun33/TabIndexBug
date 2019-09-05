using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabIndexBug
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            HotReloader.Current.Run(this);

            MainPage = new TestPages();
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
