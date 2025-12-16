using System;
using System.Collections.Generic;
using System.Text;

namespace AS2526._4F.INF.Prof.Azienda
{
    public class Sede
    {
        string localita;
        Persona responsabile;
        public Sede(string localita) 
        { 
            this.localita = localita;
        }

        public void SetResponsabile(Persona responsabile)
        {
            this.responsabile = responsabile;
        }
    }
}
