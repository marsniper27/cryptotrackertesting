using Newtonsoft.Json;
using System;

namespace Binance
{
    public partial class AccountInfo
    {
        [JsonProperty("makerCommission")]
        public long MakerCommission { get; set; }

        [JsonProperty("takerCommission")]
        public long TakerCommission { get; set; }

        [JsonProperty("buyerCommission")]
        public long BuyerCommission { get; set; }

        [JsonProperty("sellerCommission")]
        public long SellerCommission { get; set; }

        [JsonProperty("canTrade")]
        public bool CanTrade { get; set; }

        [JsonProperty("canWithdraw")]
        public bool CanWithdraw { get; set; }

        [JsonProperty("canDeposit")]
        public bool CanDeposit { get; set; }

        [JsonProperty("updateTime")]
        public long UpdateTime { get; set; }

        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        [JsonProperty("balances")]
        public Balance[] Balances { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }
    }

    public partial class Balance
    {
        [JsonProperty("asset")]
        public string Asset { get; set; }

        [JsonProperty("free")]
        public string Free { get; set; }

        [JsonProperty("locked")]
        public string Locked { get; set; }
    }


    public class StatusResult
    {
        public int Status { get; set; }
        public string Msg { get; set; }
    }

    public class CoinPrice
    {
        public String Symbol { get; set; }
        public String Price { get; set; }
    }

    public partial class Wallet
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("snapshotVos")]
        public SnapshotVo[] SnapshotVos { get; set; }
    }

    public partial class SnapshotVo
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updateTime")]
        public long UpdateTime { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("balances")]
        public Balance[] Balances { get; set; }

        [JsonProperty("totalAssetOfBtc")]
        public string TotalAssetOfBtc { get; set; }
    }

}
