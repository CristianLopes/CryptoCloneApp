using CommunityToolkit.Maui.Behaviors;
using CryptoCloneApp.Resources.Styles;

namespace CryptoCloneApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
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

