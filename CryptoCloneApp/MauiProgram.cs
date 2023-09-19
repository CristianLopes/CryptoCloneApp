using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using CryptoCloneApp.Services;
using CryptoCloneApp.ViewModels;
using CryptoCloneApp.Views.Custom.Controls;
using CryptoCloneApp.Views.Pages;

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


		builder.Services.AddTransient<LoginPage>();
		builder.Services.AddTransient<WalletPage>();
		builder.Services.AddTransient<NftListPage>();
		builder.Services.AddTransient<NftDetailPage>();
		builder.Services.AddTransient<ProfilePage>();
		builder.Services.AddTransient<RankingPage>();
		
		builder.Services.AddTransient<LoginPageViewModel>();
		builder.Services.AddTransient<WalletPageViewModel>();
		builder.Services.AddTransient<NftListPageViewModel>();
		builder.Services.AddTransient<NftDetailPageViewModel>();
		builder.Services.AddTransient<ProfilePageViewModel>();
		builder.Services.AddTransient<RankingPageViewModel>();

        builder.Services.AddTransient<Header>();
        builder.Services.AddTransient<HeaderViewModel>();

		//adding services
        builder.Services.AddTransient<INftService, MockNftService>();

        return builder.Build();
	}
}
