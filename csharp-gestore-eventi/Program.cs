namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Gestionale Eventi ###");
            Console.WriteLine("[1] Crea Programma eventi");
            Console.WriteLine("[2] Crea evento con possibilità di prenotare e disdire");
            int sceltaPrincipale = Convert.ToInt32(Console.ReadLine());
            switch (sceltaPrincipale)
            {
                case 1:
                    Console.WriteLine("Crea il programma eventi");
                    Console.WriteLine("Quale è il titolo del programma?");
                    string titoloProgramma = Console.ReadLine();
                    //creazione programma eventi
                    ProgrammaEventi programmaEventi = new ProgrammaEventi(titoloProgramma);
                    Console.WriteLine("Quanti eventi vuoi aggiungere al programma?");
                    int numeroEventi = Convert.ToInt32(Console.ReadLine());
                    //creamo un ciclo per far creare X eventi
                    for (int i = 0; i < numeroEventi; i++)
                    {
                        Console.WriteLine("Inserisci titolo");
                        string titoloEvento = Console.ReadLine();
                        Console.WriteLine("Inserisci data");
                        DateTime dataEvento = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Inserisci capienza massima");
                        int capienzaMaxEvento = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserisci il nome del relatore");
                        string nomeRelatore = Console.ReadLine();
                        Console.WriteLine("Inserisci il prezzo");
                        double prezzo = Convert.ToDouble(Console.ReadLine());
                        Conferenza nuovoEvento = new Conferenza(titoloEvento, dataEvento, capienzaMaxEvento,nomeRelatore,prezzo);
                        programmaEventi.aggiungiEvento(nuovoEvento);
                    }
                    Console.WriteLine("Scegli un opzione");
                    Console.WriteLine("[1] Ottieni il numero presente di eventi nel programma");
                    Console.WriteLine("[2] Stampa la lista di eventi del programma");
                    Console.WriteLine("[3] Cerca gli eventi in una data");
                    Console.WriteLine("[4] Elimina tutti gli eventi");

                    int scelta = Convert.ToInt32(Console.ReadLine());
                    switch (scelta)
                    {
                        case 1:
                            Console.WriteLine(programmaEventi.ContaEventi());
                            break;
                        case 2:
                            Console.WriteLine(programmaEventi.ToString());
                            break;
                        case 3:
                            Console.WriteLine("Inserisci la data da cercare yyyy/mm/dd");
                            DateTime dataDaCercare = Convert.ToDateTime(Console.ReadLine());
                            programmaEventi.eventoPerData(dataDaCercare);
                            break;
                        case 4:
                            programmaEventi.SvuotaEventi();
                            break;
                    }
                    break;
                case 2:
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
                    switch (risposta)
                    {
                        case "si":
                            Console.WriteLine("Quanto posti vorresti prenotare?");
                            int postiUtente = Convert.ToInt32(Console.ReadLine());
                            evento.PrenotaPosti(postiUtente);

                            break;
                        case "no":
                            Console.WriteLine("no");
                            break;

                    }
                    bool continua = true;
                    while (continua)
                    {
                        Console.WriteLine("Vuoi disdire posti? si/no");
                        risposta = Console.ReadLine();
                        switch (risposta)
                        {
                            case "si":
                                Console.WriteLine("Quanti posti vuoi disdire?");
                                int postiUtente = Convert.ToInt32(Console.ReadLine());
                                evento.DisdiciPosti(postiUtente);
                                break;
                            case "no":
                                continua = false;
                                break;

                        }
                    }
                    break;
            }          
        }
    }
}
