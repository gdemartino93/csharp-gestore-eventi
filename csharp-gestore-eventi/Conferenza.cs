using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Conferenza:Evento
    {
        private string relatore;
        private double prezzo;

        public string Relatore { get; set; }
        public double Prezzo { get; set; }

        public Conferenza(string titolo,DateTime data,int capienzaMassima,string relatore, double prezzo):base(titolo,data,capienzaMassima)
        {
            Relatore = relatore;
            Prezzo = prezzo;
        }

        public override string ToString()
        {
            return $"Conferenza|| Titolo: {Titolo}. Data: {Data}. Relatore: {Relatore}. Prezzo:{Prezzo.ToString("0.00")}"; 
        }

    }
}
