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


        public List<string> Visualizzati()
        {
            var s = new List<string>();

            s.Add($"Sede : {this.localita}\n\n");
            s.Add($"responsabile : {responsabile.Visualizzati()}\n");

            return s;
        }
    }
}
