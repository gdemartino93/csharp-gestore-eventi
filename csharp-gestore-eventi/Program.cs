namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProgrammaEventi eventi = new ProgrammaEventi("lista eventi");

            ///debug 
            Evento uno = new Evento("concerto1", new DateTime(2024,12,01), 100);
            Evento due = new Evento("concerto2", new DateTime(2024,12,02), 200);
            Evento tre = new Evento("concerto3", new DateTime(2024,12,03), 300);
            Evento quattro = new Evento("concerto4", new DateTime(2024, 12, 03), 300);
            Evento cinque = new Evento("concerto5", new DateTime(2024, 12, 03), 300);
            eventi.aggiungiEvento(uno);
            eventi.aggiungiEvento(due);
            eventi.aggiungiEvento(tre);
            eventi.aggiungiEvento(quattro);
            eventi.aggiungiEvento(cinque);

       
            Console.WriteLine(eventi.ContaEventi());
            Console.WriteLine(eventi.StampaProgramma());

            string eventilistastringa = ProgrammaEventi.EventiInStringa(eventi.Eventi);
            Console.WriteLine(eventilistastringa);

            Console.WriteLine("Crea il programma eventi");
            Console.WriteLine("Quale è il titolo del programma?");
            string titoloProgramma = Console.ReadLine();
            Console.WriteLine("Quanti eventi vuoi aggiungere al programma?");
            int numeroEventi = Convert.ToInt32(Console.ReadLine());

            ProgrammaEventi programmaEventi = new ProgrammaEventi(titoloProgramma);


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