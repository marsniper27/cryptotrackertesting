using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading.Tasks;


namespace Binance
{


    public class BinanceAPI
    {
        static HttpClient httpClient = new HttpClient();
        public StatusResult result;
        public CoinPrice priceResult;

        public string Key = "QvNDAwk1bxFU51DBkZPNksEnY4uoEBJJP79FPzKq2LoCybeU9UkzuerurfMLvSsg";
        public string Secret = "6RemCIgFNMJG00T2wLMXgVOOz6cAbxcrm5PCisbL5Hpv7B5bLXB9JiW8TQzccW0T";


        public async Task<StatusResult> StatusRequest()
        {
            using (var request = new HttpRequestMessage())
            {
                request.RequestUri = new Uri("https://api.binance.com/sapi/v1/system/status");
                request.Method = HttpMethod.Get;

                using (var response = await httpClient.SendAsync(request))
                {
                    string content = await response.Content.ReadAsStringAsync();

                    result = JsonConvert.DeserializeObject<StatusResult>(content);
                    return result;
                }
            }
        }
        public async Task<CoinPrice> PriceRequest(string pair)
        {
            using (var request = new HttpRequestMessage())
            {
                request.RequestUri = new Uri("https://api.binance.com/api/v3/ticker/price?symbol="+pair);
                request.Method = HttpMethod.Get;

                using (var response = await httpClient.SendAsync(request))
                {
                    string content = await response.Content.ReadAsStringAsync();

                    priceResult = JsonConvert.DeserializeObject<CoinPrice>(content);
                    return priceResult;
                }
            }
        }

        public async Task<Wallet> walletData()
        {
            Wallet walletResult = new Wallet();
            string timeStamp = getTimestamp();

            var getParams = "type=SPOT&timestamp=" + timeStamp;

            string url = "https://api.binance.com/sapi/v1/accountSnapshot?" + getParams + "&signature=" + encodeSecret(getParams);
            using (var request = new HttpRequestMessage())
            {
                request.RequestUri = new Uri(url);
                request.Method = HttpMethod.Get;
                request.Headers.Add("X-MBX-APIKEY", Key);


                using (var response = await httpClient.SendAsync(request))
                {
                    string content = await response.Content.ReadAsStringAsync();

                    walletResult = JsonConvert.DeserializeObject<Wallet>(content);
                    return walletResult;
                }
            }
        }
        
        string getTimestamp()
        {
             long timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
             return timeStamp.ToString();
        }

        string encodeSecret(string requestParams)
        {
            byte[] secret = new byte[64];

            byte[] getParamsByte = new byte[requestParams.Length];


            byte[] signature = new byte[64];

            for (var count = 0; count < 64; count++)
            {
                secret[count] = Convert.ToByte(Secret[count]);
            }
            for (var count = 0; count < requestParams.Length; count++)
            {
                getParamsByte[count] = Convert.ToByte(requestParams[count]);
            }

            using (HMACSHA256 hmac = new HMACSHA256(secret))
            {
                signature = hmac.ComputeHash(getParamsByte);
            }

            return BitConverter.ToString(signature).Replace("-", "");
        }
    }
}