using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka;
using Mediateka.Builders;
using Mediateka.Classes;
using Mediateka.Interfaces;



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


            //создаем плейлист
            Media audioPList = new Media("Sbornik_1", new List<IMediaItem>());


            //добавляем в библиотеку трек
            AudioItem t1 = new AudioItem("Dr. Dre", "www.listen.ru/dr.dre/track1.mp3");
            AudioItem t2 = new AudioItem("Madonna", "www.listen.ru/dr.dre/track2.mp3");
            AudioItem t3 = new AudioItem("The Prodigy", "www.listen.ru/dr.dre/track3.mp3");
            audioPList.Items.Add(t1);
            audioPList.Items.Add(t2);
            audioPList.Items.Add(t3);

            Console.WriteLine(audioPList.Name);

            


        }
    }
}
