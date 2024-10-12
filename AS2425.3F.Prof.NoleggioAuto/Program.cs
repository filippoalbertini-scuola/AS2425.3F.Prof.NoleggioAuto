namespace AS2425._3F.Prof.NoleggioAuto
{
    /// <summary>
    /// Dati i kilometri finali e iniziali, il nome del conducente ed un importo chilometrico 
    /// fisso di € 1,70 calcolare il totale da pagare
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prof;3F;12/10/24;Calcolo importo noleggio auto");
            string km;

            const double costoKilometrico = 1.70;

            Console.WriteLine("Digita il nome del conducente");
            string nome = Console.ReadLine();

            Console.WriteLine("Digita i km iniziali della vettura");
            km = Console.ReadLine();
            int kmIniziali = Convert.ToInt32(km);

            Console.WriteLine("Digita i km finali della vettura");
            km = Console.ReadLine();
            int kmFinali = Convert.ToInt32(km);

            // calcolo importo complessivo del noleggio
            double importoTotale = (kmFinali - kmIniziali)*costoKilometrico;

            Console.WriteLine($"Caro {nome} il tuo importo complessivo da pagare è {importoTotale}");

        }
    }
}
