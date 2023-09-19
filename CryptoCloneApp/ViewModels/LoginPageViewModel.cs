using CommunityToolkit.Mvvm.Input;

namespace CryptoCloneApp.ViewModels
{
    public partial class LoginPageViewModel : ViewModelBase
    {
        [RelayCommand]
        async Task Login() => await Shell.Current.GoToAsync("//HomePage");
    }
}
