using CryptoCloneApp.Models;

namespace CryptoCloneApp.Services
{
    public interface INftService
    {
        Task<IEnumerable<NftListItem>> GetNftsAsync();
    }
}
