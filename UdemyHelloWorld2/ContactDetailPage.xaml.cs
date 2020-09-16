using System;
using System.Collections.Generic;
using UdemyHelloWorld2.Models;
using Xamarin.Forms;

namespace UdemyHelloWorld2
{
	public partial class ContactDetailPage : ContentPage
	{
		public ContactDetailPage(Contact contact)
		{
			if (contact == null)
				throw new ArgumentNullException();

			BindingContext = contact;

			InitializeComponent();
		}
	}
}
