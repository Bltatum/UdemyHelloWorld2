using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UdemyHelloWorld2
{
    public partial class IntroductionPage : ContentPage
    {
        public IntroductionPage()
        {
            InitializeComponent();
        }

       async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        //Overides the back button on device(android)
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
