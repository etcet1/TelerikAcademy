using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Call
    {
        //date, time, dialed phone number and duration 
        private DateTime date;
        private string dialedPhone;
        private int duration;

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string DialedPhone
        {
            get { return this.dialedPhone; }
            set { this.dialedPhone = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public List<Call> CallHistory { get; set; }

        public Call(DateTime date, int duration)
        {
            this.date = date;
            this.duration = duration;
        }

        public Call(string number, DateTime date, int duration)
        {
            this.dialedPhone = number;
            this.date = date;
            this.duration = duration;
        }

    }
}
