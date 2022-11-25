using Smart_ID.Views.LoginPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Smart_ID.ViewModels.NavigationPagesViewModels
{
    public class SettingsViewModel
    {
        public SettingsViewModel()
        {
            btnLogin = new Command(logout);
        }

        public ICommand btnLogin { get; set; }

        //Functions
        public async void logout(object sender)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Login(), true);
        }
    }
} 
