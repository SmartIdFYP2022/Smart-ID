using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Smart_ID.ViewModels.RecordPagesViewModels
{
    public class LibraryPageViewModel
    {
        public LibraryPageViewModel()
        {
            btnDashboard = new Command(Dashboard);
        }
        //ICommands
        public ICommand btnDashboard { get; set; }

        //Functions
        public async void Dashboard(object sender)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AppShell(), true);
        }
    }
}
