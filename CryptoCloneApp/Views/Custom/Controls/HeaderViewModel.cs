using CommunityToolkit.Mvvm.Input;
using CryptoCloneApp.ViewModels;

namespace CryptoCloneApp.Views.Custom.Controls
{
    public partial class HeaderViewModel : ViewModelBase
    {
        [RelayCommand]
        async Task OpenMenu()
        {
            await Shell.Current.GoToAsync("//LoginPage");
            //await Shell.Current.DisplayAlert("APP","Need develop feature menu","OK");
        }
    }
}
