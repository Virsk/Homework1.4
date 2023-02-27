using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework1._4
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Фаил txt открыт");
            Console.ResetColor();
        }
        public override void Create()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Фаил txt создан");
            Console.ResetColor();
        }
        public override void Change()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Фаил txt отредактирован");
            Console.ResetColor();
        }
        public override void Save()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Фаил txt сохранен");
            Console.ResetColor();
        }
    }
}
