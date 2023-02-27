using System;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Document document = new Document("Контракт");
            document.Body = "Тіло контракту...";
            document.Footer = "Директор: Іванов І.І.";

            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
