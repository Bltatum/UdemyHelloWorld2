using System;
using System.Collections.Generic;
using ContactBookApp.Models;
using Xamarin.Forms;

namespace ContactBookApp
{
    public partial class ContactDetailPage : ContentPage
    {
        public event EventHandler<Contact> ContactAdded;
        public event EventHandler<Contact> ContactUpdated;

        public ContactDetailPage(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));
            
            InitializeComponent();

            BindingContext = new Contact
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Phone = contact.Phone,
                Email = contact.Email,
                IsBlocked = contact.IsBlocked
            };
        }

       async void Save_Clicked(System.Object sender, System.EventArgs e)
        {
            var contact = BindingContext as Contact;

            if(string.IsNullOrWhiteSpace(contact.FullName))
            {
              await DisplayAlert("Error", "Please enter a name.", "Ok");
                return;
            }

            if(contact.Id == 0)
            {
                contact.Id = 1;

                ContactAdded?.Invoke(this, contact);
            }
            else
            {
                ContactUpdated?.Invoke(this, contact);
            }

            await Navigation.PopAsync();
        }
    }
}
