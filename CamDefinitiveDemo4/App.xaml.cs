using CamDefinitiveDemo4.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CamDefinitiveDemo4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CameraViewPage();
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
