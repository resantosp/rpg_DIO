namespace rpgPOO.source.Entities
{
    public class Cleric : Hero
    {
         public Cleric(string Name, int Level, string Race, string heroClass, int HP) : base(Name, Level, Race, heroClass, HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.Race = Race;
            this.heroClass = heroClass;
            this.HP = HP;
        }

        public override string Attack()
        {
            return this.Name + " " + "Channels Positive Energy and Cure The First Hero to Attack at the row";
        }
    }
}