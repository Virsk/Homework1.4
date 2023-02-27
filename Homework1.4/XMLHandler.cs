using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework1._4
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Фаил html открыт");
            Console.ResetColor();
        }
        public override void Create()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Фаил html создан");
            Console.ResetColor();
        }
        public override void Change()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Фаил html отредактирован");
            Console.ResetColor();
        }
        public override void Save()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Фаил html сохранен");
            Console.ResetColor();
        }
    }
}
