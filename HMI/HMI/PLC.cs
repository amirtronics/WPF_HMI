using System.IO;
using TwinCAT.Ads;

namespace HMI
{
    public class PLC
    {
        TcAdsClient tcAds = new TcAdsClient();

        public string adsAddress { get; set; }
        public int adsPort { get; set; }

        public void Connect()
        {
            tcAds.Connect(adsAddress, adsPort);
        }

        public void Disconnect()
        {
            tcAds.Disconnect();
            tcAds.Dispose();
        }
    }
}
