using CommunityToolkit.Maui.Behaviors;
using CryptoCloneApp.ViewModels;

namespace CryptoCloneApp.Views.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginPageViewModel loginPageViewModel)
    {
        InitializeComponent();
        BindingContext = loginPageViewModel;
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        if (sender is not Image image)
        {
            return;
        }

        image.Behaviors.Clear();
        var currentTheme = App.ChangeTheme();
        var behavior = new IconTintColorBehavior
        {
            TintColor = currentTheme == AppTheme.Dark ? App.IconColorDarkTheme : App.IconColorLightTheme,
        };

        image.Behaviors.Add(behavior);
    }
}

