using MusicStreamingService.Core.Entities;

namespace MusicStreamingService.Core.Interfaces;

public interface IPlaybackService
{
    void Play(Track track);
    void Pause();
    void Stop();
    void Next();
    void Previous();
}
