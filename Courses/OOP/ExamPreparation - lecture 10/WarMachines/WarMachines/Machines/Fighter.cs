namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter, IMachine
    {
        private const double InitialHealthPoints = 200;

        public Fighter(string initialName, double initalAttackPoints, double initialDefensePoints,
            bool initialStealthMode)
            : base(initialName, InitialHealthPoints, initalAttackPoints, initialDefensePoints)
        {
            this.StealthMode = initialStealthMode;
        } 

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString());

            string stealthModeToString = this.StealthMode ? On : Off;
            result.AppendLine(string.Format(" *Stealth: {0}", stealthModeToString));

            return result.ToString();
        }
    }
}
