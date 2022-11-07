namespace PokemonGO
{
    internal class Pkmnsauvage
    {
        int[] PVRandoms = { 11, 20, 25 };
        string[] NomsRandoms = { "Ratata", "Roucool", "Racailloux" };
        int[] DegatsRandoms = { 5, 8, 10 };

        public string Nom { get; set; }
        public int PDV { get; set; }
        public int ATT { get; set; }
        public bool Vivant { get; set; } = true;

        public Pkmnsauvage()
        {
            Random random = new Random();
            Nom = NomsRandoms[random.Next(0, 3)];
            PDV = PVRandoms[random.Next(0, 3)];
            ATT = DegatsRandoms[random.Next(0, 3)];

            Console.WriteLine("Attention, un " + Nom + " sauvage fonce sur toi !");
        }

        public void PrendreDegats(int att)
        {
            PDV = PDV - att;
            Console.WriteLine("Le " + Nom + " sauvage reçoit " + att + " points de dégâts.");
            if (PDV < 0)
            {
                PDV = 0;
            }
            else
            {
                Console.WriteLine("Il lui reste " + PDV + "PV.");
            }
        }
    }
}
