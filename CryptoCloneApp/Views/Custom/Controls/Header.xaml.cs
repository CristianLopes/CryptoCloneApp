namespace CryptoCloneApp.Views.Custom.Controls;

public partial class Header : ContentView
{
	public Header()
	{
		InitializeComponent();
        BindingContext = App.GetService<HeaderViewModel>();
	}
}