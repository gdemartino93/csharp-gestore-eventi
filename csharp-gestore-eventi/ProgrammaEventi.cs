﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class ProgrammaEventi
    {
        private string titolo;
        List<Evento> eventi;
        List<Evento> eventiCercatiPerData;

        public string Titolo { get; set; }
        public List<Evento> Eventi { get; set; }

        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
            Eventi = new List<Evento>();
        }

        public void aggiungiEvento(Evento evento)
        {
            Eventi.Add(evento);
            Console.WriteLine("Evento aggiunto alla lista");
        }
        public void eventoPerData(DateTime dataDaCercare)
        {
            foreach (var evento in Eventi)
            {
                if(dataDaCercare == evento.Data)
                {
                    Console.WriteLine(evento.ToString());
                }
            }
            
        }
    }
}
