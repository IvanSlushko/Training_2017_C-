namespace Mediateka.Interfaces
{
    public interface IMedia
    {
        string Name { get; }
        string Url { get; }

        IMediaStream GetStream();
        void Play();
    }
}
