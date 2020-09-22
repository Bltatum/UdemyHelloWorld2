using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UdemyHelloWorld2
{
    public partial class EntryEditorPage : ContentPage
    {
        public EntryEditorPage()
        {
            InitializeComponent();
        }

        void Entry_Completed(System.Object sender, System.EventArgs e)
        {
           label.Text = "Password Saved";
        }

        void Entry_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            phone.Text = e.NewTextValue;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Entry Saved", null, "Close");
        }

        void Picker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var contactMethod = contactMethods.Items[contactMethods.SelectedIndex];

            DisplayAlert("Selection", contactMethod, "Ok");
        }

    }
}
