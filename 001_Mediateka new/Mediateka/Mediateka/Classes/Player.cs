using Mediateka.Interfaces;
using System;
using System.Collections.Generic;

namespace Mediateka.Classes
{
    public class Player : IMediaStream
    {


        public Media Media { get; protected set; }

        public void Play()
        {
            Media.Play();
        }

        public void LoadCollection(Media media)
        {
            Media = media;
        }
    }

}