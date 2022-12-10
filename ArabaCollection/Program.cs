namespace ArabaCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arabalar = new List<Araba>()
            {
                new Araba()
                {
                     Marka = "Nissan",
                     Model = "GTR-35"
                },
                new Araba()
                {
                    Marka ="Toyota",
                    Model = "Supra"
                },
            };
            Araba[] yeniArabalar = new Araba[3]
            {
                new Araba()
                {
                    Marka = "Mazda",
                    Model = "RX-7"
                },
                new Araba()
                {
                    Marka = "Dodge",
                    Model = "Charger"
                },
                new Araba()
                {
                    Marka = "Mitsubishi",
                    Model = "Lancer-Evo"
                },

            };
            arabalar.AddRange(yeniArabalar);
            foreach (var tumArabalar in arabalar)
            {
                Console.WriteLine($"{tumArabalar.Marka}: {tumArabalar.Model}");
            }

        }
        class Araba
        {
            public string Marka { get; set; }
            public string Model { get; set; }
        }
    }

}

