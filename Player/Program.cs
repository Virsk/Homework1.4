using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            while (true)
            {
                Console.WriteLine("Выберети одну из команд");
                Console.WriteLine();
                Console.WriteLine("1. Записать песню.\r\n2. Включить песню.\r\n3. Поставить на паузу.\r\n4. Закрыть приложение.");
                string choise = (Console.ReadLine());                
                if (choise == "Записать песню" ||
                    choise == "1" || 
                    choise == "Записать песню." || 
                    choise == "Записать"||
                    choise == "записать"||
                    choise == "записать песню" ||
                    choise == "записать песню.")
                {
                    player.Record();
                }
                else if (
                    choise == "Включить песню" ||
                    choise == "2" ||
                    choise == "Включить песню." ||
                    choise == "Включить"||
                    choise == "включить" ||
                    choise == "включить песню" ||
                    choise == "включить песню.")
                {
                    player.Play();
                }
                else if (
                    choise == "Поставить на паузу" ||
                    choise == "3" ||
                    choise == "Поставить на паузу." ||
                    choise == "Пауза" ||
                    choise == "пауза" ||
                    choise == "поставить на паузу" ||
                    choise == "поставить на паузу.")
                {
                    player.Pause();
                }
                else if (
                    choise == "Закрыть приложение" ||
                    choise == "4" ||
                    choise == "Закрыть приложение." ||
                    choise == "Закрыть" ||
                    choise == "закрыть" ||
                    choise == "закрыть приложение" ||
                    choise == "закрыть приложение.")
                {
                    player.Stop();
                }
                else
                {
                    Console.WriteLine("Команда не доступна");
                    Console.WriteLine();
                }

            }
        }
    }
}
