namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Crea il programma eventi");
            Console.WriteLine("Quale è il titolo del programma?");
            string titoloProgramma = Console.ReadLine();
            //creazione programma eventi
            ProgrammaEventi programmaEventi = new ProgrammaEventi(titoloProgramma);
            Console.WriteLine("Quanti eventi vuoi aggiungere al programma?");
            int numeroEventi = Convert.ToInt32(Console.ReadLine());
            //creamo un ciclo per far creare X eventi
            for(int i = 0; i < numeroEventi; i++)
            {
                Console.WriteLine("Inserisci titolo");
                string titoloEvento = Console.ReadLine();
                Console.WriteLine("Inserisci data");
                DateTime dataEvento = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Inserisci capienza massima");
                int capienzaMaxEvento = Convert.ToInt32(Console.ReadLine());
                Evento nuovoEvento = new Evento(titoloEvento, dataEvento, capienzaMaxEvento);
                programmaEventi.aggiungiEvento(nuovoEvento);
            }
            string eventilistastringa = ProgrammaEventi.EventiInStringa(programmaEventi.Eventi);
            Console.WriteLine(eventilistastringa);


            Console.WriteLine("Crea evento");
            Console.WriteLine("Inserisci il titolo dell'evento:");
            string nomeEvento = Console.ReadLine();
            Console.WriteLine("Inserisci la data delle evento yyyy/mm/dd");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Inserisci la capienza massima dell'evento");
            int capienzaMassima = Convert.ToInt32(Console.ReadLine());

            Evento evento = new Evento(nomeEvento, data, capienzaMassima);
            Console.WriteLine(evento.ToString());

            Console.WriteLine("Hai bisogno di prenotare? si/no");
            string risposta = Console.ReadLine();
            switch(risposta)
            {
                case "si" :
                    Console.WriteLine("Quanto posti vorresti prenotare?");
                    int postiUtente = Convert.ToInt32(Console.ReadLine());
                    evento.PrenotaPosti(postiUtente);

                    break;
                case "no": Console.WriteLine("no");
                    break;

            }
            bool continua = true;
            while (continua)
            {
                Console.WriteLine("Vuoi disdire posti? si/no");
                risposta = Console.ReadLine();
                switch(risposta)
                {
                    case "si":
                        Console.WriteLine("Quanti posti vuoi disdire?");
                        int postiUtente = Convert.ToInt32(Console.ReadLine());
                        evento.DisdiciPosti(postiUtente);
                        break;
                    case "no": continua = false;
                        break;
                        
                }
            }           
        }
    }
}