using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace AppBar
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // create application bar instance
            ApplicationBar = new ApplicationBar();

            // create new button
            ApplicationBarIconButton Newpage = new ApplicationBarIconButton();
            // add image to button
            Newpage.IconUri = new Uri("/images/new.png", UriKind.Relative);
            // add text to button
            Newpage.Text = "New";
            // add button to application bar
            ApplicationBar.Buttons.Add(Newpage);

            // add delete button
            ApplicationBarIconButton Delete = new ApplicationBarIconButton();
            Delete.IconUri = new Uri("/images/delete.png", UriKind.Relative);
            Delete.Text = "Delete";
            ApplicationBar.Buttons.Add(Delete);

            // add save button
            ApplicationBarIconButton Save = new ApplicationBarIconButton();
            Save.IconUri = new Uri("/images/save.png", UriKind.Relative);
            Save.Text = "Save";
            ApplicationBar.Buttons.Add(Save);

            // add cancel button
            ApplicationBarIconButton Cancel = new ApplicationBarIconButton();
            Cancel.IconUri = new Uri("/images/cancel.png", UriKind.Relative);
            Cancel.Text = "Cancel";
            ApplicationBar.Buttons.Add(Cancel);

            // create menu items for AppBar
            ApplicationBarMenuItem Share = new ApplicationBarMenuItem();
            Share.Text = "Share via....";
            ApplicationBar.MenuItems.Add(Share);
            ApplicationBarMenuItem Contacts = new ApplicationBarMenuItem();
            Contacts.Text = "Contact us through +25477547629";
            ApplicationBar.MenuItems.Add(Contacts);
            ApplicationBarMenuItem Website = new ApplicationBarMenuItem();
            Website.Text = "Visit us on www.smn.com";
            ApplicationBar.MenuItems.Add(Website);
        }

   
    }
}