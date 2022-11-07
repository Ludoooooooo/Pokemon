using System.Security.Cryptography.X509Certificates;

namespace PokemonGO
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choisissez un Pokémon : 1 : Carapuce | 2 : Salamèche | 3 : Magicarpe ");
            string chx = Console.ReadLine();
            int choix = int.Parse(chx);


            Pokemon pokemon = new Pokemon("", 0, 0, 0, 0);
            Pokemon pkmnsauvage = new Pokemon("", 0, 0, 0, 0);

            if (choix == 1)

            {
                Console.WriteLine("Vous avez choisi Carapuce ! ");
                pokemon = new("Carapuce", 20, 8, 5, 8);
            }
            else if (choix == 2)
            {
                Console.WriteLine("Vous avez choisi Salamèche ! ");
                pokemon = new("Salamèche", 20, 10, 3, 8);

            }
            else if (choix == 3)
            {
                Console.WriteLine("Vous avez choisi Magicarpe ! ");
                pokemon = new("Magicarpe", 20, 1, 1, 8);
            }
            bool game = true;



            int x = 1;  /* Si le switch case = Voir les stats, affiche les stats et recommence la boucle pour éviter une attaque*/
            do
            {
                Console.WriteLine("Combattre : 1 | Soigner : 2 | Stats : 3 | Quitter le jeu : 4 ");
                switch (Console.ReadLine())
                {
                    case "1":
                        pkmnsauvage = new();
                        break;
                    case "2":
                        pokemon.SoignerFull();
                        break;
                    case "3":
                        pokemon.Stats();
                        x = 0;
                        break;
                    case "4":
                        Console.WriteLine("A bientôt ! ");
                        game = !game;
                        break;
                    default:
                        Console.WriteLine("Rien ne se passe...");
                        break;
                }


                    while (game && pokemon.Vivant)
                    {
                        if (pkmnsauvage.PDV <= 0)
                        {
                            pkmnsauvage = new();
                        }

                        do
                        {
                            Console.WriteLine("Choisissez une action | 1 : Attaquer | 2 : Soigner | 3 : Fuir ");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    pkmnsauvage.PrendreDegats(pokemon.ATT);
                                    break;
                                case "2":
                                    pokemon.Soigner();
                                    break;
                                case "3":
                                    Console.WriteLine("C'est l'heure de la fuite ! ");
                                    break;
                                default:
                                    Console.WriteLine("Rien ne se passe...");
                                    break;
                            }
                        } while (x == 0);


                        if (pkmnsauvage.PDV <= 0)
                        {
                            Console.WriteLine("Le " + pkmnsauvage.Nom + " sauvage a été vaincu !");

                        }
                        else
                        {
                            pokemon.PrendreDegats(pkmnsauvage.ATT);
                        }

                        if (pokemon.PDV <= 0)
                        {
                            Console.WriteLine("Votre Pokémon est KO !");
                            break;
                        }

                    }

            } while (x == 0);

        }









    }
}