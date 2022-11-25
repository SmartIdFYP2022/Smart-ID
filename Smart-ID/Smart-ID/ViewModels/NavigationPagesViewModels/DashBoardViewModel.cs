using Smart_ID.Models.NavigationPagesModels;
using Smart_ID.ViewModels.RecordPagesViewModels;
using Smart_ID.Views.LoginPages;
using Smart_ID.Views.NavigationPages;
using Smart_ID.Views.RecordPages;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Smart_ID.ViewModels.NavigationPagesViewModels
{
    public class DashBoardViewModel
    {
   
        public DashBoardViewModel()
        {

            TransactionPageButton = new Command(TransactionPage);
            btnSettings = new Command(settingPage);
            btnProfile = new Command(ProfilePage);

        }
            
        //ICommands
        public ICommand TransactionPageButton { get; set; }
        public ICommand btnSettings { get; set; }
        public ICommand btnProfile { get; set; }

        //Functions
        public async void TransactionPage(object sender)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new TransactionsPage(), true);
        }
        public async void settingPage(object sender)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AppShell(), true);
        }
        public async void ProfilePage(object sender)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AppShell(), true);
        }
    }
}
