using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;

namespace CryptoCloneApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Inter-Bold.ttf", "InterBold");
				fonts.AddFont("Inter-Medium.ttf", "InterMedium");
				fonts.AddFont("Inter-Regular.ttf", "InterRegular");
			}).UseMauiCommunityToolkit().UseMauiCommunityToolkitMarkup(); ;

		return builder.Build();
	}
}
