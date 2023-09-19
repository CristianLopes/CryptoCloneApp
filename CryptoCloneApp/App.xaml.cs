using CryptoCloneApp.Handlers;
using CryptoCloneApp.Resources.Styles;

namespace CryptoCloneApp;

public partial class App : Application
{
	private static readonly DarkTheme DarkTheme = new DarkTheme();
	private static readonly LightTheme LightTheme = new LightTheme();

	public static Action<AppTheme> ThemeChanged;

    public static readonly Color IconColorDarkTheme = Colors.White;
    public static readonly Color IconColorLightTheme = Colors.Black;
    public static IServiceProvider ServiceProvider;
	public App(IServiceProvider serviceProvider)
	{
        Set(serviceProvider);
        InitializeComponent();

		InitTheme();
        MainPage = new AppShell();
        BorderlessEntryHandler.Apply();
    }

    public static void Set(IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
    }

    public static T GetService<T>() => ServiceProvider.GetService<T>();

    private void InitTheme()
	{
        Application.Current.UserAppTheme = AppTheme.Dark;
        Application.Current.Resources.MergedDictionaries.Add(DarkTheme);
    }

    public static AppTheme ChangeTheme()
	{
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (Application.Current.UserAppTheme == AppTheme.Dark)
		{
			Application.Current.UserAppTheme = AppTheme.Light;
            mergedDictionaries.Remove(DarkTheme);
			mergedDictionaries.Add(LightTheme);
        }
		else
		{
            Application.Current.UserAppTheme = AppTheme.Dark;
            mergedDictionaries.Remove(LightTheme);
            mergedDictionaries.Add(DarkTheme);
        }

        ThemeChanged?.Invoke(Application.Current.UserAppTheme);
        return Application.Current.UserAppTheme;
    }
}
