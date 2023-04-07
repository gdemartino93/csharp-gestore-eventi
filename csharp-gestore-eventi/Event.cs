using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_gestore_eventi
{
    internal class Event
    {
        private string titolo;
        private DateTime data;
        private int capienzaMassima;
        private int postiPrenotati;

        public string Titolo
        {
            get
            {
                return titolo;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("Il titolo non può esser vuoto");
                }
                else
                    titolo = value;
            }
        }
        public DateTime Data {
            get
            {
                return data;
            }
            set
            {
                if(value < DateTime.Today)
                {
                    throw new ArgumentException("La data è già passata");
                }
                else
                {
                    data = value;
                }
            }
        }
        public int CapienzaMassima {
            get
            {
                return capienzaMassima;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("La capienza dei posti non può essere negativa o uguale a 0");
                }
                capienzaMassima = value;
            }
        }
        public int PostiPrentoati { get; set; }

        public Event(string titolo,DateTime data,int capienzaMassima)
        {
            Titolo = titolo;
            Data = data;
            CapienzaMassima = capienzaMassima;
            PostiPrentoati = 0;
        }

        public void PrenotaPosti(int posti)
        {
            if ((CapienzaMassima == 0) || (Data < DateTime.Today) || ((CapienzaMassima - posti) <= 0))
            {
                Console.WriteLine("Non è possibile prenotare");
            }
            else
            {
                PostiPrentoati += posti;
                Console.WriteLine("Prenotazione avvenuta");
            }
        }


    }
}

