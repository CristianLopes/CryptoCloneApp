using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CryptoCloneApp.ViewModels
{
    public abstract partial class ViewModelBase : ObservableObject
    {
        [RelayCommand]
        void ChageTheme(Image image)
        {
            image.Behaviors.Clear();
            var currentTheme = App.ChangeTheme();
            var behavior = new IconTintColorBehavior
            {
                TintColor = currentTheme == AppTheme.Dark ? App.IconColorDarkTheme : App.IconColorLightTheme,
            };

            image.Behaviors.Add(behavior);
        }
    }
}
