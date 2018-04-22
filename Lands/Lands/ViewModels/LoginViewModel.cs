﻿namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel: BaseViewModel
    {
        //#region Events
        //public event PropertyChangedEventHandler PropertyChanged;
        //#endregion

        #region Atributes
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Properties
        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }
        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Commands
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
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an email",
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter a password",
                    "Accept");
                return;
            }

            this.isRunning = true;
            this.IsEnabled = false;
            if (this.Email != "dianarussi@yahoo.com" || this.Password != "1234")
            {
                this.isRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "Email or password incorrect.",
                   "Accept");
                this.Password = string.Empty;
                return;
            }
            this.isRunning = false;
            this.IsEnabled = true;
            await Application.Current.MainPage.DisplayAlert(
                  "OK",
                  "Fuck yeahh.",
                  "Accept");

        }
        #endregion
        #region Constructors
        public LoginViewModel ()
        {
            this.IsRemembered = true;
            this.isEnabled = true;
        }        
    }
        #endregion
}

