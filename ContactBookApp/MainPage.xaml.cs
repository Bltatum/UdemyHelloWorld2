using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactBookApp.Models;
using Xamarin.Forms;

namespace ContactBookApp
{
    public partial class MainPage : ContentPage
    { 
        private ObservableCollection<Contact> _contacts;

        public MainPage()
        {
            InitializeComponent();

            _contacts = new ObservableCollection<Contact>
           {
               new Contact {Id = 1, FirstName= "Brennen", LastName= "Tatum", Email="brennen@email.com", IsBlocked=false, Phone="6155550330"},
               new Contact {Id = 2, FirstName= "Emily", LastName= "Tatum", Email="emily@email.com", IsBlocked=false, Phone="6155551000"}
           };

            contacts.ItemsSource = _contacts;
        }

        void Add_Clicked(System.Object sender, System.EventArgs e)
        {
            var contactPage = new ContactDetailPage(new Contact());
            contactPage.ContactAdded += (source, contact) =>
            {
                _contacts.Add(contact);
            };

            Navigation.PushAsync(contactPage);
        }

      async void Delete_Clicked(System.Object sender, System.EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;

            if (await DisplayAlert("Warning", $"Are you sure you want to delete {contact.FullName}?", "Yes", "No"))
                _contacts.Remove(contact);
        }

       async void contacts_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (contacts.SelectedItem == null)
                return;

            var selectedContact = e.SelectedItem as Contact;

            contacts.SelectedItem = null;

            var contactDetailPage = new ContactDetailPage(selectedContact);
            contactDetailPage.ContactUpdated += (source, contact) =>
            {
                selectedContact.Id = contact.Id;
                selectedContact.FirstName = contact.FirstName;
                selectedContact.LastName = contact.LastName;
                selectedContact.Phone = contact.Phone;
                selectedContact.Email = contact.Email;
                selectedContact.IsBlocked = contact.IsBlocked;
            };

           await Navigation.PushAsync(contactDetailPage);

        }
    }
}
