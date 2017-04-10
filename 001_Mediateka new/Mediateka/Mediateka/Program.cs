using System.Collections.Generic;
using Mediateka.Classes;
using Mediateka.Interfaces;
using System;



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

namespace Mediateka
{
    class Program
    {

        static void Main(string[] args)
        {

            Track t1 = new Track("Dr. Dre", "www.listen.ru/dr.dre-track1.mp3");
            Track t2 = new Track("Madonna", "www.listen.ru/dr.dre/track2.mp3");
            Track t3 = new Track("The Prodigy", "www.listen.ru/dr.dre/track3.mp3");

            Disk disk = new Disk("MyDisk",new List<IDisk>());

            disk.AddTrack(t1);
            disk.AddTrack(t2);
            disk.AddTrack(t3);
            disk.AddTrack(new Track("Off Spring", "www.listen.ru/dr.dre/track4.mp3"));
            Console.WriteLine("-----------{0}---------", disk.Name);
            foreach (Track a in disk.Tracks)
            {
             Console.WriteLine("Track: {0}, Url: {1}", a.Name, a.Url);
            }

            Console.WriteLine("--------------------");
            Picture p1 = new Picture("Garden", "www.pic.ru/garden.jpg");
            Console.WriteLine("Picture: {0}, Url: {1}", p1.Name, p1.Url);

            Console.WriteLine("--------------------");
            Video v1 = new Video("At Barcelona", "www.youtube.ru/321jghjnm31k2");
            Console.WriteLine("Video: {0}, Url: {1}", v1.Name, v1.Url);





            Console.WriteLine("---------------------------------------------");
        }
    }
}
