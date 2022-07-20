namespace CryptoCloneApp.Controls;

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
	}
}