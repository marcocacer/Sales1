
using GalaSoft.MvvmLight.Command;
using Sales1.Helpers;
using Sales1.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sales1.ViewModels
{
    public class MenuItemViewModel
    {
        #region Properties
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }
        #endregion

        #region Commands
        public ICommand GotoCommand
        {
            get
            {
                return new RelayCommand(Goto);
            }
        }

        private void Goto()
        {
            if(this.PageName == "LoginPage")
            {
                Settings.AccessToken = string.Empty;
                Settings.TokenType = string.Empty;
                Settings.IsRemembered = false;
                MainViewModel.GetInstance().Login = new LoginViewModel();
                Application.Current.MainPage = new NavigationPage(new LoginPage());
            }
        }
        #endregion
    }
}
