using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginApp
{
    public class UserRecord
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        
        private UserRecord userData;
        public MainPage()
        {
            InitializeComponent();
            userData = new UserRecord();
            BindingContext = userData;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Checking();
           

            
        }
        private char[] Numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        private char[] Characters = {'\\', '\'', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', '=', '{', '}', '[', ']', '|', '/', ':', ';', '"', '<', '>', ',', '.', '?', ' '};
        private void Checking()
        {
            bool hasNumbers = false;
            bool hasChars = false;
            foreach(char pas in userData.Password)
            {
                foreach(char num in Numbers)
                {
                    if(pas == num) { hasNumbers = true; break; }
                }
                foreach(char chars in Characters)
                {
                    if (pas == chars) { hasChars = true; break; }
                }
            }

            if(userData.Username != "")
            {
               if(userData.Password.Length >= 8)
               {
                    if(hasNumbers is true && hasChars is true)
                    {
                        Application.Current.MainPage.Navigation.PushAsync(new PassPage(userData));
                    }
                    else
                    {
                        Application.Current.MainPage.DisplayAlert("Error", "Heslo neobsahuje speciální znak nebo číslici!", "Ok");

                    }
               }
               else
               {
                    Application.Current.MainPage.DisplayAlert("Error", "Heslo je kratší než 8 znaků!", "Ok");
               }
            }
            else
            {
               Application.Current.MainPage.DisplayAlert("Error", "Přihlašovací jméno nebylo zadáno!", "Ok");
            }
        }
    }
}
