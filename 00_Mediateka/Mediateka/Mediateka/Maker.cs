using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka;

namespace Mediateka
{
    class Maker
    {
        public Media Make(MediaBuilder mediaBuilder)
        {
            mediaBuilder.CreateMedia();

            mediaBuilder.SetPhotoFile();
            mediaBuilder.SetVideoFile();
            mediaBuilder.SetAudioFile();

            mediaBuilder.SetUrl();
            return mediaBuilder.Media;
        }
    }
}
