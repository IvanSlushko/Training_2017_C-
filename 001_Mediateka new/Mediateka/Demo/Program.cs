using System.Collections.Generic;
using Mediateka.Classes;
using Mediateka.Interfaces;
using System;
using System.Threading;



//  Необходимо составить библиотеку классов и интерфейсов для описания сущностей домена «Медиатека». 
// В медиатеке могут сохранятся элементы следущего вида: 

// --фото, ссылка на фото (url), 
// --муз.трек, ссылка на муз.трек, 
// --видео, ссылка на видео, 
// --событие (набор из фото, ссылок на фото, видео, ссылок на видео), 
// --диск (фиксированный набор из треков и картинок), 
// --сериал (набор из видео + набор картинок), 
// --подборка (как диск только с возможностью изменения элементов и/или порядка элементов).

// Остальные требования:
//1)     Составить демо
//2)     Использовать шаблон Factory и/или Builder для построения сложных объектов
//3)     Использовать принцип Dependency Injection
//4)     В классах контейнерах обеспечить необходимые CRUD операции(при необходимости)
//5)     Сделать методы для проигрывания элементов в некотором абстрактном плейере(методы могут просто выводить в консоль название проигрываемого элемента)

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Track t1 = new Track("Dr. Dre", "www.listen.ru/dr.dre-track1.mp3", "picture23");
            Track t2 = new Track("Madonna", "www.listen.ru/dr.dre/track2.mp3", "picture3");
            Track t3 = new Track("The Prodigy", "www.listen.ru/dr.dre/track3.mp3", "picture27");

            Disk disk = new Disk("MyDisk",new List<IDisk>());

            disk.AddTrack(t1);
            disk.AddTrack(t2);
            disk.AddTrack(t3);
            disk.AddTrack(new Track("Off Spring", "www.listen.ru/dr.dre/track4.mp3", "picture23"));
            Console.WriteLine("-----------{0}---------", disk.Name);
            //disk.DelTrack(t1);

            foreach (Track a in disk.Tracks)
            {
             Console.WriteLine("Track: {0}, Url: {1}, Picture: {2}", a.Name, a.Url, a.Picture);
            }
            Console.WriteLine("--------------------");
            Disk disk1 = new Disk("MyDisk1", new List<IDisk>()
            {new Track("Dr. Dre", "www.listen.ru/dr.dre-track1.mp3", "picture55"),
            new Track("Dr. Dre", "www.listen.ru/dr.dre-track5.mp3", "picture53"),
            new Track("Dr. Dre", "www.listen.ru/dr.dre-track55.mp3", "picture553")
            });

            Console.WriteLine(t1.Play);

            Console.WriteLine("--------------------");
            Picture p1 = new Picture("Garden", "www.pic.ru/garden.jpg");
            Picture p2 = new Picture("Garden1", "www.pic.ru/garden1.jpg");
            Console.WriteLine("Picture: {0}, Url: {1}", p1.Name, p1.Url);
            Console.WriteLine("Picture: {0}, Url: {1}", p2.Name, p2.Url);

            Console.WriteLine("--------------------");
            Video v1 = new Video("At Barcelona", "www.youtube.ru/321jghjnm31k2");
            Console.WriteLine("Video: {0}, Url: {1}", v1.Name, v1.Url);

            Console.WriteLine("--------------------");

            // событие: 
            // набор из фото и ссылок на фото 
            // видео и ссылок на видео
            
            Event ev = new Event();
            ev.AddToEvents(v1);
            ev.AddToEvents(p2);
            ev.AddToEvents(p1);
            Console.WriteLine(ev.PrintAll());
            Console.WriteLine("after delete------");
            ev.DelFromEvents(p2);
            Console.WriteLine(ev.PrintAll());
            Console.WriteLine("---------------------------------------------");

            // --сериал (набор из видео + набор картинок), 

            Serial ser = new Serial();
            ser.AddToSerials(v1);
            ser.AddToSerials(p2);
            ser.AddToSerials(p1);
            //ser.DelFromSerials(p2);
            Console.WriteLine(ser.PrintAll());
            Console.WriteLine("---------------------------------------------");

            Player pl1 = new Player("Плеер 1", 5 , t1);
            //Player pl2 = new Player("Плеер 2", 5, v1);
            //Player pl3 = new Player("Плеер 3", 5, p2);

        }
    }
}
