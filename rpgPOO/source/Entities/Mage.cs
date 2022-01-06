namespace rpgPOO.source.Entities
{
    public class Mage : Hero
    {
        public Mage(string Name, int Level, string Race, string heroClass) : base(Name, Level, Race, heroClass)
        {
            this.Name = Name;
            this.Level = Level;
            this.Race = Race;
            this.heroClass = heroClass;
        }

        public override string Attack()
        {
            return this.Name + " Attacks with a Spell";
        }
        public string Attack(int Bonus)
        {
            if (Bonus >= 6)
            {
                return this.Name + " " + "Attacks with a Spell. It's super efective with bonus +" + Bonus;
            }
            else
            {
                return this.Name + " " + "Attacks with a spell. Not effective with bonus +" + Bonus;
            }
        }
    }
}