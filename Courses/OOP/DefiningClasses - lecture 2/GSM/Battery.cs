using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd,
    }

    class Battery
    {
        //battery characteristics 
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;

        public enum BatteryType
        {
            LiPoly,
            LiIon,
            NiCd,
            NiMH
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double? Idle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }
        public double? Talk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public BatteryType Type { get; set; }

        public Battery(string model, double hoursIdle, double hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

    }
}
