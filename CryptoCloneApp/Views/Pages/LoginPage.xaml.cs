using CommunityToolkit.Maui.Behaviors;
using CryptoCloneApp.ViewModels;

namespace CryptoCloneApp.Views.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginPageViewModel loginPageViewModel)
    {
        InitializeComponent();
        BindingContext = loginPageViewModel;

        Loaded += LoginPage_Loaded;
    }

    private async void LoginPage_Loaded(object sender, EventArgs e)
    {
        _ = StartAnimation();
    }

    private async Task StartAnimation()
    {
        var animations = new List<Task>();
        await stackTop.TranslateTo(0, -75);
        await stackBottom.TranslateTo(0, 75);
        animations.Add(stackParentOfAll.FadeTo(1, 1000, Easing.BounceOut));
        animations.Add(stackTop.TranslateTo(0,0, 1000));
        animations.Add(stackBottom.TranslateTo(0,0, 1000));

        await Task.WhenAll(animations);
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

