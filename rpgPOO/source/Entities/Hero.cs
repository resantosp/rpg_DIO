namespace rpgPOO.source.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, string Race, string heroClass) //perceba como o construtor facilita e te faz escrever menos linhas de código
        {
            this.Name = Name;
            this.Level = Level;
            this.Race = Race;
            this.heroClass = heroClass;
        }
        
        public string Name;
        public int Level;
        public string Race;
        public string heroClass;

        public override string ToString()
        {
            return "\nHERO " + this.Name + "\n\tLEVEL: " + this.Level + "\n\tRACE: " + this.Race + "\n\tCLASS: " + this.heroClass;
        }

        public virtual string Attack()
        {
            return this.Name + " " + "Attacks with a FireBall";
        }
    }
}