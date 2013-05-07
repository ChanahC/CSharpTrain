using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace QuickSharp{
    public class GlobalizationX{
        private static void Main()
        {
            Console.WriteLine(Thread.CurrentThread.CurrentCulture.Name);
            //This gets the current thread's (which in this case is the main thread which executes Main())
            // Culture or localization
            CultureInfo x = new CultureInfo("ko-KR"); //creating a culture info class
            Thread.CurrentThread.CurrentCulture = x; //setting the threads culture info into x
            Console.WriteLine(Thread.CurrentThread.CurrentCulture.Name);
            Console.WriteLine();
            //This is for listing all the possible values for culture info
             foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures)){
              Console.WriteLine("{0} | {1}", ci.EnglishName, ci.Name);
            }
            CultureInfo currentUI = CultureInfo.CurrentUICulture; //gets the UI culture of the current running app
            Console.WriteLine(currentUI);
            InputLanguage inL = InputLanguage.CurrentInputLanguage;
            //getting the current input language
            CultureInfo xinfo = inL.Culture;
            //getting the culture of the current input language
            Console.WriteLine("Culture identifier = {0}\n"+"Display name = {1}\n"+"Calender = {2}\n",xinfo.ToString(),xinfo.DisplayName,xinfo.Calendar.ToString());
          
        }
    }
}