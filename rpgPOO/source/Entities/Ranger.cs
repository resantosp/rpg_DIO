namespace rpgPOO.source.Entities
{
    public class Ranger : Hero
    {
        public Ranger(string Name, int Level, string Race, string heroClass, int HP) : base(Name, Level, Race, heroClass, HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.Race = Race;
            this.heroClass = heroClass;
            this.HP = HP;
        }

        public override string Attack()
        {
            return this.Name + " " + "Attacks with a Compound Bow";
        }
    }
}