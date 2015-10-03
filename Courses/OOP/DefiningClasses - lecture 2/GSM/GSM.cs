using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class GSM
    {
        //model, manufacturer, price, owner, battery characteristics 
        private string manufacturer;
        private string model;
        private decimal price;
        private string owner;
        //private Battery battery;
        //private Display display;

        private static readonly GSM iPhone4S = new GSM("4S", "Apple", "Petrov", 900.00M, "Apple", 10, 3, 4.1, 65000);

        private readonly List<Call> calls = new List<Call>();

        private const decimal CallPrice = 0.5M;

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public Display Display { get; set; }

        public Battery Battery { get; set; }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.calls;
            }
        }

        public GSM(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
        }

        public GSM(string manufacturer, string model, string owner)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.owner = owner;
        }

        public GSM(string manufacturer, string model, string owner, decimal price)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.owner = owner;
            this.price = price;
        }

        public GSM(string manufacturer, string model, string owner, decimal price, string battery, double batteryHoursIdle, double battteryHoursTalk, double inches, int colors)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.Battery = new Battery(model, batteryHoursIdle, battteryHoursTalk);
            this.Display = new Display(inches, colors);
        }

        public void MakeCall(string number, int duration)
        {
            this.calls.Add(new Call(number, DateTime.Now, duration));
        }

        public void DeleteLongestCall()
        {
            int longestCallIndex = 0;
            int callLength = int.MinValue;
            for (int i = 0; i < this.calls.Count; i++)
            {
                if (this.calls[i].Duration > callLength)
                {
                    longestCallIndex = i;
                }
            }

            this.DeleteCall(longestCallIndex);
        }

        public void DeleteCall(int callId)
        {
            this.calls.RemoveAt(callId);
        }

        public void CleanCallList()
        {
            this.calls.Clear();
        }

        public decimal CallsBill()
        {
            decimal result = 0;
            long totalSeconds = 0;
            foreach (var call in this.calls)
            {
                totalSeconds += call.Duration;
            }

            decimal totalMinutes = (decimal)totalSeconds / 60;
            result = totalMinutes * CallPrice;
            return result;
        }

        //ToString override
        public override string ToString()
        {
            StringBuilder gsmData = new StringBuilder();

            gsmData.Append("GSM Details\n");
            gsmData.Append("Model: " + this.Model + " ");
            gsmData.Append("Manufacturer: " + this.Manufacturer + " ");
            if (this.Owner != null)
            {
                gsmData.Append("Owner: " + this.Owner + " ");
            }
            gsmData.Append("Price: " + this.Price + " Euro" + " ");

            return gsmData.ToString();
        }

        public void PrintCallHistory()
        {
            StringBuilder callData = new StringBuilder();

            foreach (var call in this.CallHistory)
            {
                callData.Append("Phone: ");
                callData.Append(" " + this.Model);
                callData.Append(" by " + this.Manufacturer);
                callData.Append(" dialed number - ");
                callData.Append(" " + call.DialedPhone);
                callData.Append(" on ");
                callData.Append(call.Date);
                callData.Append(" for ");
                callData.Append(call.Duration);
                callData.Append(" seconds.");

                Console.WriteLine(callData.ToString());
                callData.Clear();
            }
        }


    }
}
