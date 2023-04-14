using currency4;

namespace currency6
{
    public class PredictinData
    {



        public void reader()

        {
            string address = @"F:\currency data\time.text";
            StreamReader streader = new StreamReader(address);


            double line1 = Convert.ToDouble(streader.ReadLine());
            double line2 = Convert.ToDouble(streader.ReadLine());
            double line3 = Convert.ToDouble(streader.ReadLine());
            double line4 = Convert.ToDouble(streader.ReadLine());
            double line5 = Convert.ToDouble(streader.ReadLine());
            double line6 = Convert.ToDouble(streader.ReadLine());

            var plus = line1 + line2 + line3 + line4 + line5 + line6;


            long average1 = Convert.ToInt32(plus) / 6;

            var currencyinfo = currencyprocess.currencyinformation();

            var q = currencyinfo.Result.high;
            var e = currencyinfo.Result.low;
            var r = q + e;
            var t = Convert.ToInt32(r) / 2;

            var m = t - average1;

            var predictonbuy = m + currencyinfo.Result.buy;
            var predictonsell = m + currencyinfo.Result.sell;


            Console.WriteLine("predicton of buy  is:  {0}", predictonbuy);

            Console.WriteLine("predicton of sell  is:  {0}", predictonsell);
        }





    }
}


