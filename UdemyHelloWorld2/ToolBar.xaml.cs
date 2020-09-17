using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UdemyHelloWorld2
{
    public partial class ToolBar : ContentPage
    {
        public ToolBar()
        {
            InitializeComponent();
        }

        void ToolbarItem_Activated(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Activated", "ToolBar item activated", "Ok");
        }
    }
}
