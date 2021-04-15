using System;

public class Binance
{
    string binanceAPIaddress = "https://api.binance.com";

    public BinanceAPI()
    {
        using (var client = new WebClient())
        {
            var contents = client.DownloadString(binanceAPIaddress);
            Console.WriteLine(contents);

        }
    }
}
