using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;

namespace Lands.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsRunning { get; set; }

        public bool IsRemembered { get; set; }


        public LoginViewModel()
        {
            this.IsRunning = true;
        }
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await App.Current.MainPage.DisplayAlert("Error", "You must  enter an Email", "OK");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "You must  enter an Password", "OK");
                return;
            }

            if (this.Email != "edson250@hotmail.com" || this.Password != "1234")
            {
                await App.Current.MainPage.DisplayAlert("Error","Email or Password incorret", "OK");
                return;
            }

            await App.Current.MainPage.DisplayAlert("OK", "Fuck yeahh", "OK");
        }
    }
}
