using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UdemyHelloWorld2
{
    public partial class Popups : ContentPage
    {
        public Popups()
        {
            InitializeComponent();
        }
        
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            //simple alert popup
            //var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");
            //if (response)
            //    await DisplayAlert("Done", "Your answer will be saved", "Ok");

            //action sheet
            var response = await DisplayActionSheet("This is an action sheet", "Cancel", "Delete", "Send Message", "Share", "Save");
                await DisplayAlert("Response", response, "Close");
        }
    }
}
