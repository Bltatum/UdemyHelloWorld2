using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UdemyHelloWorld2
{
    public partial class TabbleView : ContentPage
    {
        public TabbleView()
        {
            InitializeComponent();
        }
        //Implementing picker with Navigation.
        void ViewCell_Tapped(System.Object sender, System.EventArgs e)
        {
            var page = new ContactsMethods();
            page.ContactMethods.ItemSelected += (source, args) =>
            {
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };

            Navigation.PushAsync(page);
        }
    }
}
