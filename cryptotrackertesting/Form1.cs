using Binance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptotrackertesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BinanceAPI binanceAPI = new BinanceAPI();

        private void returnData_Click(object sender, EventArgs e)
        {

        }
        public string returnDataText
        {
            get
            {
                return this.returnData.Text;
            }
            set
            {
                this.returnData.Text = value;
            }
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            var status = new StatusResult();
            status = await binanceAPI.StatusRequest();
            this.returnData.Text = "Status: " + status.Status + "\n" + "Msg: " + status.Msg;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var price = new CoinPrice();
            price = await binanceAPI.PriceRequest(pairName.Text.ToUpper());
            this.CoinPrices.Text = price.Symbol +" Price: $" + price.Price; 
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if(APIKey.Text == "Enter API Key")
            {
                APIKey.Text = "QvNDAwk1bxFU51DBkZPNksEnY4uoEBJJP79FPzKq2LoCybeU9UkzuerurfMLvSsg";
                SecretKey.Text = "6RemCIgFNMJG00T2wLMXgVOOz6cAbxcrm5PCisbL5Hpv7B5bLXB9JiW8TQzccW0T";
            }

            binanceAPI.Key = APIKey.Text;
            binanceAPI.Secret = SecretKey.Text;
            this.balancesLabel.Text = "";
            var wallet = new Wallet();
            SnapshotVo snapshot = new SnapshotVo();
            var data = new Data();
            Balance[] balances = data.Balances;
           // var balance = new Balance();
            string output="";
            wallet = await binanceAPI.walletData();
            snapshot = wallet.SnapshotVos[0];
            data = snapshot.Data;
            balances = data.Balances;
            
            
            for(var count = 0; count< balances.Count(); count++)
            {
                var coin = balances[count];
                output += coin.Asset +": Free: " + coin.Free + " Locked: " +coin.Locked +"\n";
            }

            this.balancesLabel.Text = "Value in BTC: " + data.TotalAssetOfBtc +"\n Coins:\n" + output; 
        }

        private async void AccountInfo_Click(object sender, EventArgs e)
        {
            if (APIKey.Text == "Enter API Key")
            {
                APIKey.Text = "QvNDAwk1bxFU51DBkZPNksEnY4uoEBJJP79FPzKq2LoCybeU9UkzuerurfMLvSsg";
                SecretKey.Text = "6RemCIgFNMJG00T2wLMXgVOOz6cAbxcrm5PCisbL5Hpv7B5bLXB9JiW8TQzccW0T";
            }

            binanceAPI.Key = APIKey.Text;
            binanceAPI.Secret = SecretKey.Text;

            string output = "";
            this.AccountInfoLabel.Text = "";
            var accountInfo = new AccountInfo();

            accountInfo = await binanceAPI.AccountInfo();
            Balance[] balances = accountInfo.Balances;
            

            for (var count = 0; count < balances.Count(); count++)
            {
                var coin = balances[count];
                if (!(coin.Free == "0.00000000" & coin.Locked == "0.00000000")&!(coin.Free == "0.00" & coin.Locked == "0.00"))
                {
                    output += coin.Asset + ": Free: " + coin.Free + " Locked: " + coin.Locked + "\n";
                }
            }

            this.AccountInfoLabel.Text = "\n Coins:\n" + output;
        }
    }
}
