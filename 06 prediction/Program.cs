using currency1;
using currency4;
using currency5;
using currency6;
using System.Runtime.CompilerServices;
using System.Threading;




Console.WriteLine("please wait (ONE MINUTE)");


ApiHelper.InitializeClient();
var currencyinfo = await currencyprocess.currencyinformation();


PredictinData PD = new PredictinData();
DataSaver DS = new DataSaver();
do
{
  
DS.datasaver();

PD.reader();
  
}while(true);
