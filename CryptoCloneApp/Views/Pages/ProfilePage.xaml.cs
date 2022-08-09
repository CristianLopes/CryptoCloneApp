namespace CryptoCloneApp.Views.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}



	private void ImageViewList_Tapped(object sender, EventArgs e)
	{
		//This is not better way to change DataTemplate
		collectionViewList.IsVisible = true;
		collectionViewGrid.IsVisible = false;
	}

	private void ImageViewGrid_Tapped(object sender, EventArgs e)
	{
        //This is not better way to change DataTemplate
        collectionViewList.IsVisible = false;
        collectionViewGrid.IsVisible = true;
    }
}