namespace CryptoCloneApp.Views.Pages;

public partial class NftListPage : ContentPage
{
	public NftListPage()
	{
		InitializeComponent();
	}

	private void Entry_Focused(object sender, FocusEventArgs e)
	{
		var width = entrySearch.Width;
        iconSearch.TranslateTo(width, 0, 400, easing: Easing.CubicInOut);
    }

	private void Entry_Unfocused(object sender, FocusEventArgs e)
	{
        iconSearch.TranslateTo(0, 0, 400, easing: Easing.CubicInOut);
    }

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		entrySearch.Unfocus();
    }
}