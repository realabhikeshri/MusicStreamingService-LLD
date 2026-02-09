using  MusicStreamingService.Core.Entities;

namespace MusicStreamingService.Infrastructure.Repositories;

public class InMemoryTrackRepository
{
    private readonly List<Track> _tracks = new();

    public void Add(Track track) => _tracks.Add(track);
    public IEnumerable<Track> GetAll() => _tracks;
}
