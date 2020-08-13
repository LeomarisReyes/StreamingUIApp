using System;
using StreamingUIApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StreamingUIApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.MoviePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
