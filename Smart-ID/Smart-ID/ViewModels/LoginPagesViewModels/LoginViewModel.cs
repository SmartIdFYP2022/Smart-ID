using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Smart_ID.ViewModels.LoginPagesViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel() 
        {
            btnDashboard = new Command(DashboardButton);
        }
        //ICommands
        public ICommand btnDashboard { get; set; }

        //Functions
        public async void DashboardButton(object sender)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AppShell(), true);
        }
    }
}
