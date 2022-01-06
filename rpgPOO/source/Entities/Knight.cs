namespace rpgPOO.source.Entities
{
    public class Knight : Hero
    {
         public Knight(string Name, int Level, string Race, string heroClass, int HP) : base(Name, Level, Race, heroClass, HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.Race = Race;
            this.heroClass = heroClass;
            this.HP = HP;
        }

        public override string Attack()
        {
            return this.Name + " " + "Attacks with an Axe";
        }
    }
}