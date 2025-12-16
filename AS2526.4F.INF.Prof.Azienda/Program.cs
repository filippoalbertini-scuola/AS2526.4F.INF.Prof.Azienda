namespace AS2526._4F.INF.Prof.Azienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prof; 4F Lab. DV 2.11; 16/12/2025; Gestione azienda");

            var azienda = new Azienda("La mia azienda !");

            var martinadraghi = new Persona("Martina", "Draghi");
            var filippoalbertini = new Persona("Filippo", "Albertini");
            var stefanobacchini = new Persona("Filippo", "Albertini");
            var mauriziocecchini = new Persona("Maurizio", "Cecchini");
            var alfredodonati = new Persona("Alfredo", "Donati");

            azienda.SetCEO(martinadraghi);
            azienda.SetCTO(filippoalbertini);

            var rimini = new Sede("Rimini");
            rimini.SetResponsabile(martinadraghi);

            azienda.AddSede(rimini);

            Reparto sviluppo = new Reparto("Sviluppo");
            sviluppo.AddDipendente(stefanobacchini);
            sviluppo.AddDipendente(mauriziocecchini);
            sviluppo.AddDipendente(alfredodonati);
            sviluppo.AddDipendente(filippoalbertini);

            sviluppo.SetResponsabile(filippoalbertini);

            azienda.AddReparto(sviluppo);

            foreach (var s in azienda.Visualizzati())
                Console.WriteLine(s);
            ;
        }
    }
}
