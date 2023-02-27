using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Homework1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler file = new DOCHandler();
            bool breaker = true;
            while(true)
            {
                while (breaker == true)
                {
                    Console.WriteLine("укажите разширение файла(doc, txt, html)");
                    string tipe = Console.ReadLine();

                    switch (tipe)
                    {
                        case "doc":
                            file = new DOCHandler();
                            breaker = false;
                            break;
                        case "txt":
                            file = new TXTHandler();
                            breaker = false;
                            break;
                        case "html":
                            file = new XMLHandler();
                            breaker = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Неизвесный тип документа");
                            Console.ResetColor();
                            Console.WriteLine();
                            break;
                    }
                }
                    
                while (breaker == false)
                {
                    Console.WriteLine("Выберите действие(Открыть, Создать, Редактировать, Сохранить)");
                    string method = Console.ReadLine();
                    Console.WriteLine();

                    switch (method)
                    {
                        case "Открыть":
                            file.Open();
                            break;
                        case "Создать":
                            file.Create();
                            break;
                        case "Редактировать":
                            file.Change();
                            break;
                        case "Сохранить":
                            file.Save();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Действие не возможно");
                            Console.ResetColor();
                            Console.WriteLine();
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Продолжить работать с этим файлом? Yes/No");
                    string changebreker = Console.ReadLine();
                    if(changebreker == "No" || changebreker == "no")
                    {
                        breaker = true;
                    }                   
                }                
            }
            
            
        }
    }
}
