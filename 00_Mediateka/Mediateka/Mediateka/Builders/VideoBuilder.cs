using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka;

namespace Mediateka
{
    // строитель для видео
    class VideoBuilder : MediaBuilder
    {
        public override void SetVideoFile()
        {
            this.Media.VideoFile = new MediaFile { FileType = "Видео файл 1" };
        }

        public override void SetUrl()
        {
            this.Media.Url = new MediaUrl { Name = "https://www.youtube.com/video1" };
        }

        public override void SetAudioFile()
        {
            //throw new NotImplementedException();// не используется
        }
        public override void SetPhotoFile()
        {
            //throw new NotImplementedException();// не используется
        }
    }
}
