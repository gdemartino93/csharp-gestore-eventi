namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event newEvent = new Event("Concerto", new DateTime(2025, 10, 10),4);

            newEvent.PrenotaPosti(2);
        }
    }
}