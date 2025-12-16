using System;
using System.Collections.Generic;
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
    }
}
