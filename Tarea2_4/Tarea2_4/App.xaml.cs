using System;
using Tarea2_4.Services;
using Tarea2_4.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2_4
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new VideoView());
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
