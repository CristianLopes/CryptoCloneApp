namespace CryptoCloneApp.Models
{
    public class NftListItem
    {
        public string Image { get; set; }
        public string OwnerImage { get; set; }
        public string OwnerName { get; set; }
        public string EthPrice { get; set; }
        public string UsdPrice { get; set; }
        public NftType NftType { get; set; }
    }
}
