using CryptoCloneApp.Models;

namespace CryptoCloneApp.Services
{
    public class MockNftService : INftService
    {
        public async Task<IEnumerable<NftListItem>> GetNftsAsync()
        {
            return new List<NftListItem>()
            {
                new NftListItem()
                {
                    EthPrice="1.2 ETH",
                    Image="nfts/nft_0.png",
                    NftType= NftType.Graphic2D,
                    OwnerImage="avatars/avatar_hacker.png",
                    OwnerName="Hacker",
                    UsdPrice="$2.453,23",
                },

                new NftListItem()
                {
                    EthPrice="1.2 ETH",
                    Image="nfts/nft_1.png",
                    NftType= NftType.Graphic2D,
                    OwnerImage="avatars/avatar_hacker.png",
                    OwnerName="Hacker",
                    UsdPrice="$2.453,23",
                },

                new NftListItem()
                {
                    EthPrice="1.2 ETH",
                    Image="nfts/nft_2.png",
                    NftType=NftType.Graphic3D,
                    OwnerImage="avatars/avatar_hacker.png",
                    OwnerName="Hacker",
                    UsdPrice="$2.453,23",
                },

                new NftListItem()
                {
                    EthPrice="1.2 ETH",
                    Image="nfts/nft_3.png",
                    NftType=NftType.Graphic3D,
                    OwnerImage="avatars/avatar_hacker.png",
                    OwnerName="Hacker",
                    UsdPrice="$2.453,23",
                },

                new NftListItem()
                {
                    EthPrice="1.2 ETH",
                    Image="nfts/nft_4.png",
                    NftType=NftType.Graphic3D,
                    OwnerImage="avatars/avatar_hacker.png",
                    OwnerName="Hacker",
                    UsdPrice="$2.453,23",
                },

                new NftListItem()
                {
                    EthPrice="1.2 ETH",
                    Image="nfts/nft_5.png",
                    NftType=NftType.Graphic3D,
                    OwnerImage="avatars/avatar_hacker.png",
                    OwnerName="Hacker",
                    UsdPrice="$2.453,23",
                },

                new NftListItem()
                {
                    EthPrice="1.2 ETH",
                    Image="nfts/nft_6.png",
                    NftType=NftType.Graphic3D,
                    OwnerImage="avatars/avatar_hacker.png",
                    OwnerName="Hacker",
                    UsdPrice="$2.453,23",
                },

                 new NftListItem()
                {
                    EthPrice="1.2 ETH",
                    Image="nfts/nft_7.png",
                    NftType=NftType.Graphic3D,
                    OwnerImage="avatars/avatar_hacker.png",
                    OwnerName="Hacker",
                    UsdPrice="$2.453,23",
                },

               new NftListItem()
                {
                    EthPrice="1.2 ETH",
                    Image="nfts/nft_8.png",
                    NftType=NftType.Graphic3D,
                    OwnerImage="avatars/avatar_hacker.png",
                    OwnerName="Hacker",
                    UsdPrice="$2.453,23",
                },
            };
        }
    }
}
