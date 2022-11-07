using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGO
{
    internal class Pokemon : Pkmnsauvage 
    {
        public string Nom { get; set; }
        public int PDV { get; set; }
        public int ATT { get; set; }
        public int DEF { get; set; }
        public int VIT { get; set; }
        public bool Vivant { get; set; } = true;


        public Pokemon()
        {
            Nom = "";
            PDV = 20;
            ATT = 10;
            DEF = 10;
            VIT = 10;
        }

        public Pokemon(string nom, int pdv, int att, int def, int vit)
        {
            Nom = nom;
            PDV = pdv;
            ATT = att;
            DEF = def;
            VIT = vit;
        }

        public void PrendreDegats(int att)
        {
            int y = att - DEF;
            PDV = PDV - y;
            Console.WriteLine(Nom + " reçoit " + y + " points de dégâts. ");
            
            if (PDV < 0)
            {
                PDV = 0;
                GameOver();
            }
            else
            {
                Console.WriteLine("Il vous reste " + PDV + "PDV !");
            }
        }
        public void Soigner()
        {
            PDV = PDV + 10;
            if (PDV >= 20)
            {
                PDV = 20;
            }
            Console.WriteLine(Nom + " a été soigné de 10 PDV ");
        }

        public void SoignerFull()
        {
            PDV = 20;
            Console.WriteLine(Nom + "a été complètement soigné ! ");
        }

        public void Stats()
        {
            Console.WriteLine("Statistiques de votre " + Nom + " : ");
            Console.WriteLine(" PDV : " + PDV + " | Attaque : " + ATT + " | Défense : " + DEF + " | Vitesse : " + VIT + ".");
        }


        public void GameOver()
        {
            Console.WriteLine("Le pokémon sauvage vous a battu !");
            Vivant = false;
        }

    }
        
    
}
