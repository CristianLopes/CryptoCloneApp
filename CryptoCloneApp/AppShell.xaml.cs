using CryptoCloneApp.Views;
using CryptoCloneApp.Views.Pages;

namespace CryptoCloneApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
	}
}
