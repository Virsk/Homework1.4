using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    internal class Player : IRecodable, IPlayable
    {
        public string Song { get; set; }

        SoundPlayer player = new SoundPlayer();

        public void Play()
        {
            if(Song == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Песня не записана запишите песню");
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                Console.OutputEncoding = Encoding.UTF8;

                string[] numberSong = "Min● - 1 - 2 - 3 - 4 - 5 - ●Max".Split();

                Console.WriteLine("╔══╗ \r\n║██║♫ ♪ ♫ ♪ \r\n║()║       ♫ ♪ ♫ ♪\r\n╚══╝              ♫ ♪ ♫ ♪\r\n▄ █ ▄ █ ▄ ▄ █ ▄ █ ▄ █");

                foreach(string simbol in numberSong)
                {
                    if (simbol == Song[Song.Length - 5].ToString())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(simbol + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(simbol + " ");
                    }
                }
                Console.WriteLine();

                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream resourceStream =
                    assembly.GetManifestResourceStream(@Song);
                player = new SoundPlayer(resourceStream);

                player.Play();
            }           
        }
        public void Record()
        {
            Console.WriteLine("Выберите номер песни для записи (1, 2, 3, 4, 5)");
            string choise = Console.ReadLine();
            switch(choise)
            {
                case "1":
                    this.Song = "Player.music.1.wav";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Песня номер 1 записана в плеер");
                    Console.WriteLine();
                    Console.ResetColor();
                    break;
                case "2":
                    this.Song = "Player.music.2.wav";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Песня номер 2 записана в плеер");
                    Console.WriteLine();
                    Console.ResetColor();
                    break;
                case "3":
                    this.Song = "Player.music.3.wav";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Песня номер 3 записана в плеер");
                    Console.WriteLine();
                    Console.ResetColor();
                    break;
                case "4":
                    this.Song = "Player.music.4.wav";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Песня номер 4 записана в плеер");
                    Console.WriteLine();
                    Console.ResetColor();
                    break;
                case "5":
                    this.Song = "Player.music.5.wav";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Песня номер 5 записана в плеер");
                    Console.WriteLine();
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Песни не сущуствует");
                    Console.WriteLine();
                    Console.ResetColor();
                    break;
            }
        }
        public void Pause()
        {
            player.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Песня на паузе");
            Console.WriteLine();
            Console.ResetColor();
        }
        public void Stop()
        {
            Process.GetCurrentProcess().Kill();
        }    
    }
}
