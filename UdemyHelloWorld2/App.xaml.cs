using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyHelloWorld2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //basic nav page
            //MainPage = new NavigationPage(new WelcomePage())
            //{
            //    BarBackgroundColor = Color.Gray,
            //    BarTextColor = Color.White
            //};


            // MainPage = new TabbleView();

            MainPage = new NavigationPage(new TabbleView());
            
           
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
