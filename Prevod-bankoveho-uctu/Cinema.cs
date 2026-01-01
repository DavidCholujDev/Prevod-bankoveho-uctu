
namespace Prevod_bankoveho_uctu
{
    internal class Cinema
    {
        public void CinemaInfo(string[] args)
        {
            Console.WriteLine("Toto je info o Kine!");
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "Kino - ucet.txt";
            string filePath = Path.Combine(folder, fileName);
            string text = File.ReadAllText(filePath);
            Console.WriteLine(text);


            Console.ReadKey();
        }
    }
}
    