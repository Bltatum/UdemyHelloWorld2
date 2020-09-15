using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UdemyHelloWorld2
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

      async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
           await Navigation.PushAsync(new IntroductionPage());
        }
    }
}
           //for modal when you want user to take action
           // await Navigation.PushModalAsync(new IntroductionPage());
