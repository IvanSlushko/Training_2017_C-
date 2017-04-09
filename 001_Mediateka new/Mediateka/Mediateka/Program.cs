using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka;
using Mediateka.Builders;
using Mediateka.Classes;
using Mediateka.Interfaces;
using Mediateka.Builders.Classes;



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

            
            //добавляем в библиотеку треки
            MediaItem t1 = new MediaItem("Dr. Dre", "www.listen.ru/dr.dre/track1.mp3");
            MediaItem t2 = new MediaItem("Madonna", "www.listen.ru/dr.dre/track2.mp3");
            MediaItem t3 = new MediaItem("The Prodigy", "www.listen.ru/dr.dre/track3.mp3");
            audioPList.Items.Add(t1);
            audioPList.Items.Add(t2);
            audioPList.Items.Add(t3);
            audioPList.Items.Add(new MediaItem("Off Spring", "www.listen.ru/dr.dre/track4.mp3"));

            foreach (MediaItem a in audioPList.Items)
            {
                Console.WriteLine(a.Play);
            }
            

            


        }
    }
}
