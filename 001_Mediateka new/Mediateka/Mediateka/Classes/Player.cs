using Mediateka.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Mediateka.Classes
{
    public class Player 
    {
        private Picture p1;
        private Track t1;
        private Video v1;
        

        //Конструктор получает имя функции и номер до кторого ведется счет
        public Player(IMediaStream  stream) 
        {
            thread = new Thread(this.func);
            thread.Name = name;
            thread.Start(num);//передача параметра в поток
        }

        public Player(string name, int num, Picture p1) : this(name, num)
        {
            this.p1 = p1;
        }

        public Player(string name, int num, Video v1) : this(name, num)
        {
            this.v1 = v1;
        }

        public Player(string name, int num, Track t1) : this(name, num)
        {
            this.t1 = t1;
        }

        void func(object num)//Функция потока, передаем параметр
        {
            for (int i = 0; i < (int)num; i++)
            {

                Console.WriteLine(Thread.CurrentThread.Name 
                    + " сейчас проирывает " 
                    + t1.Name+" c ресурса "
                    + t1.Url);
                Thread.Sleep(1000);

            }
            Console.WriteLine(Thread.CurrentThread.Name + "Проигрывание завершилось.");
        }
    }
}

