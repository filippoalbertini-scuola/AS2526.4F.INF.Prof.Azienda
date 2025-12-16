using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace AS2526._4F.INF.Prof.Azienda
{
    public class Reparto
    {
        string nome;
        List<Persona> dipendenti;
        Persona responsabile;

        public Reparto(string nome)
        {
            this.nome = nome;
            dipendenti = new List<Persona>();
        }

        public void AddDipendente(Persona dipendente)
        {
            dipendenti.Add(dipendente);
        }
        public void SetResponsabile(Persona responsabile)
        {
            this.responsabile = responsabile;
        }
        public List<string> Visualizzati()
        {
            var s = new List<string>();

            s.Add($"Reparto : {nome}\n\n");
            s.Add($"responsabile : {responsabile.Visualizzati()}\n\n");

            s.Add($"dipendenti : \n");
            foreach (var dipendente in dipendenti)
            {
                s.Add("\t"+dipendente.Visualizzati());
            }

            return s;
        }
    }
}
