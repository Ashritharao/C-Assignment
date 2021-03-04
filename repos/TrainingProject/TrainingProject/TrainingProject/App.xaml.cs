using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ABC();
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
