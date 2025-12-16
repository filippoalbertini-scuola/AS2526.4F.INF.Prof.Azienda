using System;
using System.Collections.Generic;
using System.Text;

namespace AS2526._4F.INF.Prof.Azienda
{
    public class Azienda
    {
        string nome;
        Persona ceo;
        Persona cto;

        List<Sede> sedi;
        List<Reparto> reparti;

        public Azienda(string nome)
        { 
            this.nome = nome;
            sedi = new List<Sede>();
        }

        public void SetCEO(Persona ceo)
        { 
            this.ceo = ceo;
        }
        public void SetCTO(Persona cto)
        { 
            this.cto = cto;
        }

        public void AddSede(Sede sede)
        {
            sedi.Add(sede);
        }

        public void AddReparto(Reparto reparto)
        {
            reparti.Add(reparto);
        }
    }
}
