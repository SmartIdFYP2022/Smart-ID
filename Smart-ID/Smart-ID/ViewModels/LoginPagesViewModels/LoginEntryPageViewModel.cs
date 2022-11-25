using Smart_ID.Views.LoginPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Smart_ID.ViewModels.LoginPagesViewModels
{
    public class LoginEntryPageViewModel
    {
        public LoginEntryPageViewModel()
        {
            btnLogin = new Command(LoginButton);
        }

        //ICommands
        public ICommand btnLogin { get; set; }

        //Functions
        public async void LoginButton(object sender)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Login(), true);
        }
    }
}
