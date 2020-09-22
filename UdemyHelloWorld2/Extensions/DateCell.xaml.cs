using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UdemyHelloWorld2.Extensions
{
    public partial class DateCell : ViewCell
    {
        //creating a bindable property for label
        public static readonly BindableProperty LabelProperty =
            BindableProperty.Create("Label", typeof(string), typeof(DateCell));

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public DateCell()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}
