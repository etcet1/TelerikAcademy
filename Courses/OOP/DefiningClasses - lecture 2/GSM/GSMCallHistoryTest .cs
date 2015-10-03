using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class GSMCallHistoryTest
    {
        static void Main(string[] args)
        {

            // GSM TEST
            List<GSM> phones = new List<GSM>();
            phones.Add(new GSM("Nokia", "E71"));
            phones.Add(new GSM("Apple", "S9300", "Lozov"));
            phones.Add(new GSM("Samsung", "S4", "Peshev", 800, "Belkin", 30, 5, 3, 256000));

            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine();
            }

            //print IPhone
            Console.WriteLine(GSM.IPhone4S.ToString());

            Console.WriteLine(new string('=', 30));

            // call history
            GSM testPhone = new GSM("Samsung", "S4");

            // create calls
            testPhone.MakeCall("0898341255", 10);
            testPhone.MakeCall("0898341255", 59);
            testPhone.MakeCall("0898341255", 34);
            testPhone.MakeCall("0898341255", 120);

            // print call history
            testPhone.PrintCallHistory();

            // total price
            Console.WriteLine("\nTotal price of the calls: {0:0.00}", testPhone.CallsBill());

            // delete the longest call
            Console.WriteLine("\n Delete of the longest call");
            testPhone.DeleteLongestCall();

            // print calls history again
            testPhone.PrintCallHistory();

            // total price
            Console.WriteLine("\nTotal price of the calls: {0:0.00}", testPhone.CallsBill());

            // clear calls list
            testPhone.CleanCallList();
        }
    }
}
