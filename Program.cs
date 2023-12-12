namespace hasan.badr.varasto
{
    using System;

    class Varasto
    {
        // Staattinen laskuri olion luomiseen
        private static int laskuri = 0;

        // Ominaisuudet (Properties)
        public int TuoteId { get; }
        public string Nimi { get; set; }
        public int Maara { get; set; }
        public double Paino { get; set; }
        public bool OnHyllyssa { get; set; }

        // Konstruktori
        public Varasto(string nimi, int maara, double paino, bool onHyllyssa)
        {
            TuoteId = ++laskuri;
            Nimi = nimi;
            Maara = maara;
            Paino = paino;
            OnHyllyssa = onHyllyssa;
            Console.WriteLine($"Tuote {Nimi} (ID: {TuoteId}) luotu.");
        }

        // Metodit
        public void PoisHyllysta()
        {
            if (OnHyllyssa)
            {
                OnHyllyssa = false;
                Console.WriteLine($"Tuote {Nimi} poistettu hyllystä.");
            }
            else
            {
                Console.WriteLine($"Tuote {Nimi} ei ole hyllyssä.");
            }
        }

        public void PalautaHyllyyn()
        {
            if (!OnHyllyssa)
            {
                OnHyllyssa = true;
                Console.WriteLine($"Tuote {Nimi} palautettu hyllyyn.");
            }
            else
            {
                Console.WriteLine($"Tuote {Nimi} on jo hyllyssä.");
            }
        }

        public void MuutaPainoa(double uusiPaino)
        {
            Paino = uusiPaino;
            Console.WriteLine($"Tuotteen {Nimi} paino muutettu: {Paino} kg.");
        }

        public void MuutaNimea(string uusiNimi)
        {
            Nimi = uusiNimi;
            Console.WriteLine($"Tuotteen nimi muutettu: {Nimi}");
        }

        // Metodi laskurin arvon tulostamiseksi
        public static void TulostaLaskuri()
        {
            Console.WriteLine($"Luotujen tuotteiden määrä: {laskuri}");
        }
    }

    class Ohjelma
    {
        static void Main()
        {
            // Luodaan Varasto-instansseja
            Varasto tuote1 = new Varasto("Tuote 1", 10, 2.5, true);
            Varasto tuote2 = new Varasto("Tuote 2", 5, 1.8, false);
            Varasto tuote3 = new Varasto("Tuote 3", 20, 3.2, true);

            // Käytetään gettereitä ja settereitä
            tuote1.Nimi = "Päivitetty Tuote 1";
            Console.WriteLine($"Päivitetty nimi tuotteelle 1: {tuote1.Nimi}");

            // Käytetään tuotteen toimintometodeita
            tuote1.PoisHyllysta();
            tuote2.PalautaHyllyyn();
            tuote3.MuutaPainoa(4.0);
            tuote3.MuutaNimea("Uusi Tuote 3");

            // Tulosta laskurin arvo
            Varasto.TulostaLaskuri();
        }
    }

}