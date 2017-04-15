namespace Mediateka.Interfaces
{
    public interface IMediaStream :IMedia, IVideo, IPicture, ITrack
    {
        byte[] Read(int pos, int count);
    }
}
