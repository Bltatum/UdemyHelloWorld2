using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UdemyHelloWorld2
{
    public partial class ContactsMethods : ContentPage
    {
        public ContactsMethods()
        {
            InitializeComponent();

            listview.ItemsSource = new List<string>
            {
                "None",
                "Email",
                "SMS"
            };
        }

        public ListView ContactMethods { get { return listview; } }
    }
}
