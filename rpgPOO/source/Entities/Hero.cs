namespace rpgPOO.source.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, string Race, string heroClass, int HP) //perceba como o construtor facilita e te faz escrever menos linhas de código
        {
            this.Name = Name;
            this.Level = Level;
            this.Race = Race;
            this.heroClass = heroClass;
            this.HP = HP;
        }
        
        public string Name;
        public int Level;
        public string Race;
        public string heroClass;
        public int HP;

        public override string ToString()
        {
            return "\nHERO " + this.Name + "\tLVL: " + this.Level + "\n\tRACE: " + this.Race + "\n\tCLASS: " + this.heroClass + "\n\tHP: " + this.HP + "/749";
        }

        public virtual string Attack()
        {
            return this.Name + " " + "Attacks with a FireBall";
        }
    }
}