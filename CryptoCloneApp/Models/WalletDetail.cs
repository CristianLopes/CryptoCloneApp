using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCloneApp.Models
{
    public class WalletDetail
    {
        public string EthBalance { get; set; }
        public string UsdBalance { get; set; }
        public IReadOnlyList<WalletTransaction> Transactions { get; set; }
    }
}
