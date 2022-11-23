using Smart_ID.Models.NavigationPagesModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Smart_ID.ViewModels.NavigationPagesViewModels
{
    public class DashBoardViewModel
    {
        ObservableCollection<DashBoardListModel> dataList = new ObservableCollection<DashBoardListModel>();
        public ObservableCollection<DashBoardListModel> DashBoardLists { get { return dataList; } }

        public DashBoardViewModel()
        {
            dataList.Add(new DashBoardListModel { ImgUrl = "menu_icon.svg", Name = "File skripshit", MemorySpace = 50, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListModel { ImgUrl = "menu_icon.svg", Name = "Exploration.png", MemorySpace = 4, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListModel { ImgUrl = "menu_icon.svg", Name = "Brief website.pdf ", MemorySpace = 2, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListModel { ImgUrl = "menu_icon.svg", Name = "File skripshit", MemorySpace = 50, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListModel { ImgUrl = "menu_icon.svg", Name = "Exploration.png", MemorySpace = 4, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListModel { ImgUrl = "menu_icon.svg", Name = "Brief website.pdf ", MemorySpace = 2, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListModel { ImgUrl = "menu_icon.svg", Name = "File skripshit", MemorySpace = 50, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListModel { ImgUrl = "menu_icon.svg", Name = "Exploration.png", MemorySpace = 4, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListModel { ImgUrl = "menu_icon.svg", Name = "Brief website.pdf ", MemorySpace = 2, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListModel { ImgUrl = "menu_icon.svg", Name = "File skripshit", MemorySpace = 50, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListModel { ImgUrl = "menu_icon.svg", Name = "Exploration.png", MemorySpace = 4, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListModel { ImgUrl = "menu_icon.svg", Name = "Brief website.pdf ", MemorySpace = 2, Items = 32, IconUrl = "three_dots_icon.png" });
        }
        //public ICommand FlayoutButton { get; set; }
        //public async void CanExecuteFlayoutAsync(object obj)
        //{
        //    //await Application.Current.MainPage.Navigation.PushAsync(new FlyoutMenuPage());

        //}
    }
}
