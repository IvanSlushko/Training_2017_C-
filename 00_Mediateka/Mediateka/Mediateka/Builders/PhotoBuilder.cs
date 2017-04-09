using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka;

namespace Mediateka
{
    // строитель для photo
    class PhotoBuilder : MediaBuilder
    {
        public override void SetPhotoFile()
        {
            this.Media.PhotoFile = new MediaFile { FileType = "фото 1" };
        }
        public override void SetUrl()
        {
            this.Media.Url = new MediaUrl { Name = "https://www.photo.ru/11.jpg" };
        }

        public override void SetVideoFile()
        {
            //throw new NotImplementedException();// не используется
        }
        public override void SetAudioFile()
        {
            //throw new NotImplementedException();// не используется
        }
 
    }
}
