using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SneakersUIDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.SneakersView();
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
