using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PagesDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Page1());
            //MainPage = new FlyoutPage1();
            MainPage = new TabbedPage1();
            //MainPage = new CarouselDemo();
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
