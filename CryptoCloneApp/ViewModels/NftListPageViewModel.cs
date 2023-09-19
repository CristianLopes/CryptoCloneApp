using CryptoCloneApp.Models;
using CryptoCloneApp.Services;
using System.Collections.ObjectModel;

namespace CryptoCloneApp.ViewModels
{
    public partial class NftListPageViewModel : ViewModelBase
    {
        private readonly INftService _nftService;

        public ObservableCollection<NftListItem> NftListItems { get; }
        public ObservableCollection<string> Categories { get; } = new ObservableCollection<string>
        {
            "All",
            "3D",
            "2D",
            "GIFs",
            "Collectibles",
            "Metaverse",
            "Gaming",
        };

        public NftListPageViewModel(INftService nftService)
        {
            _nftService = nftService;
            NftListItems = new ObservableCollection<NftListItem>();

            LoadItems();
        }

        private async Task LoadItems()
        {
            var data = await _nftService.GetNftsAsync();
            foreach (var item in data)
            {
                NftListItems.Add(item);
            }
        }
    }
}
