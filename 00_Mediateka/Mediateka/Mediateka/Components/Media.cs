using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka
{
    class Media
    {
        public MediaFile PhotoFile { get; set; }

        public MediaFile VideoFile { get; set; }

        public MediaFile AudioFile { get; set; }

        public MediaUrl Url { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (PhotoFile != null)
                sb.Append("Фото: " + PhotoFile.FileType + "\n");
            if (VideoFile != null)
                sb.Append("Видео: " + VideoFile.FileType + " \n");
            if (AudioFile != null)
                sb.Append("Аудио: " + AudioFile.FileType + " \n");
            if (Url != null)
                sb.Append("URL: " + Url.Name + " \n");
            return sb.ToString();
        }
    }
}
