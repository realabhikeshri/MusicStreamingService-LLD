using MusicStreamingService.Core.Entities;
using MusicStreamingService.Core.Enums;
using MusicStreamingService.Core.Interfaces;

namespace MusicStreamingService.Services;

public class PlaybackService : IPlaybackService
{
    private readonly object _lock = new();
    private PlaybackState _state = PlaybackState.Stopped;
    private Track? _currentTrack;

    public void Play(Track track)
    {
        lock (_lock)
        {
            _currentTrack = track;
            _state = PlaybackState.Playing;
            Console.WriteLine($"▶ Playing: {track.Title}");
        }
    }

    public void Pause()
    {
        lock (_lock)
        {
            _state = PlaybackState.Paused;
            Console.WriteLine("⏸ Paused");
        }
    }

    public void Stop()
    {
        lock (_lock)
        {
            _state = PlaybackState.Stopped;
            _currentTrack = null;
            Console.WriteLine("⏹ Stopped");
        }
    }

    public void Next() => Console.WriteLine("⏭ Next track");
    public void Previous() => Console.WriteLine("⏮ Previous track");
}
