namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        protected const string On = "ON";
        protected const string Off = "OFF";

        private string name;
        private IPilot pilot;
        private IList<string> targets;

        public Machine(string initialName, double initialHealthPoints,
            double initalAttackPoints, double initialDefensePoints)
        {
            this.Name = initialName;
            this.HealthPoints = initialHealthPoints;
            this.AttackPoints = initalAttackPoints;
            this.DefensePoints = initialDefensePoints;
            
            //TO DO
            
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Machine name cannot be empty.");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {

                //to do add only one at a time
                if (value== null)
                {
                    throw new ArgumentNullException("Pilot cannot be null.");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints {get; set;}

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets
        {
            get 
            {
                return new List<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentNullException("Target cannot be null or empty.");
            }

            this.targets.Add(target);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            string targetsString = this.Targets.Count == 0 ? "None" : string.Join(", ", this.Targets);

            result.AppendLine(string.Format("- {0}",this.Name));
            result.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            result.AppendLine(string.Format(" *Health: {0}",this.HealthPoints));
            result.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            result.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            result.Append(string.Format(" *Targets: {0}", targetsString));

            return result.ToString();
        }
    }
}
