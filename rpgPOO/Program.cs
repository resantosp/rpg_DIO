using System;
using System.Collections.Generic;
using System.Linq;
using rpgPOO.source.Entities;

//PRÓXIMOS PASSOS:
// 1. Mostrar um MENU de heróis
// 2. Colocar a opção do usuário escolher o nome

namespace rpgPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mage eldarion = new Mage("Eldarion", 44, "Elf", "Mage"); //criando o objeto
            Ranger lennora = new Ranger("Lènnora", 44, "Elf", "Ranger");
            Cleric yosef = new Cleric("Yosef", 44, "Human", "Cleric");
            Knight durin = new Knight("Durin", 44, "Dwarf", "Knight");

            System.Console.WriteLine("\n======== MENU DE HERÓIS =======");
            System.Console.WriteLine(eldarion.ToString());
            System.Console.WriteLine(lennora.ToString());
            System.Console.WriteLine(yosef.ToString());
            System.Console.WriteLine(durin.ToString());

            //Mage boss = new Mage("Maleficus", 99, "Human", "Mage");
            
            // System.Console.WriteLine(eldarion.Attack(6));
            // System.Console.WriteLine(lennora.Attack());
            // System.Console.WriteLine(yosef.Attack());
            // System.Console.WriteLine(durin.Attack());
            // System.Console.WriteLine();
            // System.Console.WriteLine(boss.Attack(4));

        }
    }
}