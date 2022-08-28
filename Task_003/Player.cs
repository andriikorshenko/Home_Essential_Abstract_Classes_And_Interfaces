using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_011
{
    internal class Player : IPlayable, IRecordable, IControlable
    {
        private byte userSelection;
        private bool exit = false;

        void IPlayable.Play()
            => Console.WriteLine("Starting play music...\n");

        void IPlayable.Pause()
            => Console.WriteLine("Music has been Paused.\n");

        void IPlayable.Stop()
            => Console.WriteLine("Music has been Stopped!\n");

        void IRecordable.Record()
            => Console.WriteLine("Starting record...\n");

        void IRecordable.Pause()
            => Console.WriteLine("Record has been Paused.\n");

        void IRecordable.Stop()
            => Console.WriteLine("Record has been Stopped!\n");

        void IControlable.ShowOptions()
        {
            Console.WriteLine("Выберите опцию : "
                + "\n1 -- Включить музыку."
                + "\n2 -- Приостановить музыку."
                + "\n3 -- Выключить музыку."
                + "\n4 -- Начать запись звука."
                + "\n5 -- Приостановить запись звука."
                + "\n6 -- Выключить запись звука."
                + "\n7 -- Выйти из программы.\n");
        }

        void IControlable.SelectOption()
        {
            Console.Write("Выберите команду : ");
            userSelection = Convert.ToByte(Console.ReadLine());
        }

        void IControlable.RunOption()
        {
            IPlayable playable = this;
            IRecordable recodable = this;

            do
            {
                switch (userSelection)
                {
                    case 1:
                        playable.Play();
                        break;
                    case 2:
                        playable.Pause();
                        break;
                    case 3:
                        playable.Stop();
                        break;
                    case 4:
                        recodable.Record();
                        break;
                    case 5:
                        recodable.Pause();
                        break;
                    case 6:
                        recodable.Stop();
                        break;
                    case 7:
                        exit = true;
                        Console.WriteLine("You exit the program. Have a good day! :)");
                        break;
                    default:
                        Console.WriteLine("Sorry! Wrong command. Try againe\n");
                        break;
                }
            } while (exit);
        }
    }
}
