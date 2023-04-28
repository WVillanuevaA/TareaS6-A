using System;
using TareS6.Services;
using TareS6.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareS6
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Page1();
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
