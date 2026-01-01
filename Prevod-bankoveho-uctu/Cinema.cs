
namespace Prevod_bankoveho_uctu
{
    internal class Cinema
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Toto je info o Kine!");
            string fileName = @"C:\Users\kolku\OneDrive\Desktop\Ulohy prax\Polrocny projekt\Kino - ucet.txt";
            string text = File.ReadAllText(fileName);
            Console.WriteLine(text);


            Console.ReadKey();
        }
    }
}
    