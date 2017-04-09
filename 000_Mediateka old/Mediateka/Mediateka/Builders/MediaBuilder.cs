using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka;

namespace Mediateka
{
    // абстрактный класс строителя
    abstract class MediaBuilder
    {
        public Media Media { get; private set; }
        public void CreateMedia()
        {
            Media = new Media();
        }
        public abstract void SetPhotoFile();
        public abstract void SetVideoFile();
        public abstract void SetAudioFile();

        public abstract void SetUrl();
    }
}
