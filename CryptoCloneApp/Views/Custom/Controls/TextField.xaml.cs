using CommunityToolkit.Maui.Behaviors;

namespace CryptoCloneApp.Views.Custom.Controls;

public partial class TextField : ContentView
{
    public static readonly BindableProperty PrefixIconProperty =
			BindableProperty.Create("PrefixIcon", typeof(ImageSource), typeof(TextField));

    public static readonly BindableProperty SuffixIconProperty =
            BindableProperty.Create("SuffixIcon", typeof(ImageSource), typeof(TextField));

    public static readonly BindableProperty PlaceholderProperty =
        BindableProperty.Create("Placeholder", typeof(string), typeof(TextField));

    public static readonly BindableProperty IsPasswordProperty =
        BindableProperty.Create("IsPassword", typeof(bool), typeof(TextField));

    public ImageSource PrefixIcon
    {
        get => (ImageSource)GetValue(PrefixIconProperty);
        set => SetValue(PrefixIconProperty, value);
    }

    public ImageSource SuffixIcon
    {
        get => (ImageSource)GetValue(SuffixIconProperty);
        set => SetValue(SuffixIconProperty, value);
    }

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    public bool IsPassword
    {
        get => (bool)GetValue(IsPasswordProperty);
        set => SetValue(IsPasswordProperty, value);
    }

    public TextField()
	{
		InitializeComponent();
        App.ThemeChanged += OnThemeChanged;
	}

    private void OnThemeChanged(AppTheme currentTheme)
    {
        prefixImage.Behaviors.Clear();
        suffixImage.Behaviors.Clear();
        var behavior = new IconTintColorBehavior
        {
            TintColor = currentTheme == AppTheme.Dark ? App.IconColorDarkTheme : App.IconColorLightTheme,
        };

        prefixImage.Behaviors.Add(behavior);
        suffixImage.Behaviors.Add(behavior);
    }
}