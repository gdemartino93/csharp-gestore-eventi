using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_gestore_eventi
{
    internal class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienzaMassima;
        private int postiPrenotati;
        private int postiLiberi;

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
        public int PostiPrenotati { get; set; }
        public int PostiLiberi
        {
            get
            {
                return postiLiberi;
            }
            set
            {
               if(CapienzaMassima - PostiPrenotati > 0 )
                {
                    postiLiberi = CapienzaMassima - PostiPrenotati;
                }
                else
                {
                    Console.WriteLine("Non ci sono posti liberi");
                }

            }
        }

        public Evento(string titolo,DateTime data,int capienzaMassima)
        {
            Titolo = titolo;
            Data = data;
            CapienzaMassima = capienzaMassima;
            PostiPrenotati = 0;
            PostiLiberi = capienzaMassima;
        }

        public void PrenotaPosti(int postiDaAggiungere)
        {
            if ((CapienzaMassima == 0) || (Data < DateTime.Today) || ((CapienzaMassima - postiDaAggiungere) <= 0))
            {
                Console.WriteLine("Non è possibile prenotare");
            }
            else
            {
                PostiPrenotati += postiDaAggiungere;
                PostiLiberi = CapienzaMassima - PostiPrenotati;
                if(PostiPrenotati > 0)
                {
                    if (postiDaAggiungere == 1)
                    {
                        Console.WriteLine($"Hai prenotato {postiDaAggiungere} posto.");
                        StampaPosti();
                    }
                    else
                    {
                        Console.WriteLine($"Hai prenotato {postiDaAggiungere} posti.");
                        StampaPosti();
                    }

                }

            }
        }
        public void DisdiciPosti(int postiDaDisdire)
        {
            if((Data < DateTime.Today) || ((PostiPrenotati - postiDaDisdire) < 0))
            {
                Console.WriteLine("Impossibile disdire i posti");
            }
            else
            {
                PostiPrenotati -= postiDaDisdire;

                PostiLiberi += postiDaDisdire;

                if (postiDaDisdire == 1)
                {
                    Console.WriteLine($"Hai disdetto {postiDaDisdire} posto.");
                    StampaPosti();
                }
                else
                {
                    Console.WriteLine($"Hai disdetto {postiDaDisdire} posti.");
                    StampaPosti();
                }
            }

      
        }
        public override string ToString()
        {
            return "Titolo evento: " + Titolo + " Data: " + Data.ToString();
        }

        public void StampaPosti()
        {
            Console.WriteLine($"Posti Liberi: {PostiLiberi} posti. Posti prenotati: {PostiPrenotati} posti");
        }
    }
}

