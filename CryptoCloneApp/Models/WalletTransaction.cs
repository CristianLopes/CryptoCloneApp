namespace CryptoCloneApp.Models
{
    public class WalletTransaction
    {
        public string Id { get; set; }
        public string Date { get; set; }
        public double EthBalance { get; set; }
        public double UsdValue { get; set; }
    }
}