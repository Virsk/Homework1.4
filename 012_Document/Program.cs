using System;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            string title = "Контракт";


            string body = "Тіло контракту...";


            string footer = "Директор: Іванов І.І.";

            Document document = new Document(title, body, footer);
            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
