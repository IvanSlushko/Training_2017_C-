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

            // содаем объект распорядителя
            Maker maker = new Maker();

            // создаем билдер для видео
            MediaBuilder mediaBuilder = new VideoBuilder();
            Media videoMedia = maker.Make(mediaBuilder);
            Console.WriteLine(videoMedia.ToString());

            // создаем билдер для audio
            mediaBuilder = new AudioBuilder();
            Media audioMedia = maker.Make(mediaBuilder);
            Console.WriteLine(audioMedia.ToString());

            // оздаем билдер для photo
            mediaBuilder = new PhotoBuilder();
            Media photoMedia = maker.Make(mediaBuilder);
            Console.WriteLine(photoMedia.ToString());



            //NEW VERSION:

            //добавляем в библиотеку трек
            AudioItem a = new AudioItem("Dr. Dre", "www.listen.ru/dr.dre/track1.mp3");

            //создаем плейлист
            GeneralMedia media = new GeneralMedia("ddd", new List<IMediaItem>());

            //GeneralMedia m1 = new GeneralMedia("GGGG", new LinkedList<ISaladItem>());
            //добавляем трек туда
            media.Items.Add(a);



        }
    }
}
