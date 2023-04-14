using currency4;

namespace currency5
{
    public class DataSaver
    {


        public void datasaver()
        {
            string address = @"F:\currency data\time.text";
            StreamWriter stwriter = new StreamWriter(address);

            TimeSpan tens = new TimeSpan(0, 0, 10);

            for (int i = 0; i < 6; i++)
            {

                var currencyinfo = currencyprocess.currencyinformation();

                stwriter.WriteLine(currencyinfo.Result.buy);


                Thread.Sleep(tens);

            }
            stwriter.Close();
        }
    }
}