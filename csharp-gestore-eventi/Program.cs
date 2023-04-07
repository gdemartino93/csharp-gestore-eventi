namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event newEvent = new Event("Concerto", new DateTime(2025, 10, 10),40);

            newEvent.PrenotaPosti(30);
            newEvent.DisdiciPosti(3);
            Console.WriteLine($"Posti prenotati {newEvent.PostiPrenotati}");
            Console.WriteLine(newEvent.ToString());
        }
    }
}