namespace rpgPOO.source.Entities
{
    public class Knight : Hero
    {
         public Knight(string Name, int Level, string Race, string heroClass) : base(Name, Level, Race, heroClass)
        {
            this.Name = Name;
            this.Level = Level;
            this.Race = Race;
            this.heroClass = heroClass;
        }

        public override string Attack()
        {
            return this.Name + " " + "Attacks with an Axe";
        }
    }
}