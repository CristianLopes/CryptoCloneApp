using CommunityToolkit.Mvvm.Input;
using CryptoCloneApp.Views.Pages;

namespace CryptoCloneApp.ViewModels
{
    public partial class LoginPageViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        [RelayCommand]
        async Task Login() => await Shell.Current.GoToAsync("//HomePage");
    }
}
