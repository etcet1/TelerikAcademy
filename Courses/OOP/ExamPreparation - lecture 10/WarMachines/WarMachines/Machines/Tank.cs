namespace WarMachines.Machines
{
    using System.Text;
    using WarMachines.Interfaces;

    class Tank : Machine, ITank, IMachine
    {
        private const double InitialHealthPoints = 100;
        private const int AttackPointsModifier = 40;
        private const int DefensePointsModifier = 30;

        public Tank(string initialName, double initalAttackPoints, double initialDefensePoints)
            : base(initialName, InitialHealthPoints, initalAttackPoints, initialDefensePoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set;}

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.AttackPoints += AttackPointsModifier;
                this.DefensePoints -= DefensePointsModifier;
            }
            else
            {
                this.AttackPoints -= AttackPointsModifier;
                this.DefensePoints += DefensePointsModifier;
            }

            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString());

            string defenseModeToString = this.DefenseMode ? On : Off;
            result.AppendLine(string.Format(" *Defense: {0}", defenseModeToString));

            return result.ToString();
        }
    }
}
