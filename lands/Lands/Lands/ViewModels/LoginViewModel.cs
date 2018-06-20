using GalaSoft.MvvmLight.Command;
using Lands.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lands.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;

        public string Email
        {
            get { return email; }
            set { SetValue(ref email, value); }
        }

        public string Password
        {
            get { return password; }
            set { SetValue(ref password, value); }
        }

        public bool IsRunning
        {
            get { return isRunning; }
            set { SetValue(ref isRunning, value); }
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return isEnabled; }
            set { SetValue(ref isEnabled, value); }
        }


        public LoginViewModel()
        {
            this.IsRunning = true;
            this.IsEnabled = true;

            this.Email = "edson250@hotmail.com";
            this.Password = "1234";

            //http://restcountries.eu/rest/v2/all
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
                await Application.Current.MainPage.DisplayAlert("Error", "You must  enter an Email", "OK");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must  enter an Password", "OK");
                return;
            }
            this.IsRunning = true;
            this.IsEnabled = true;

            if (this.Email != "edson250@hotmail.com" || this.Password != "1234")
            {
                IsRunning = false;
                IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert("Error","Email or Password incorret", "OK");
                this.Password = string.Empty;
                return;
            }

            isRunning = false;
            isEnabled = true;

            this.Email = string.Empty;
            this.Password = string.Empty;

            MainViewModel.GetInstance().Lands = new LandsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LandsPage());
        }
    }
}
