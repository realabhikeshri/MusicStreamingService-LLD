namespace MusicStreamingService.Core.Entities;

public class Playlist
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; }
    private readonly List<Track> _tracks = new();

    public IReadOnlyList<Track> Tracks => _tracks.AsReadOnly();

    public Playlist(string name)
    {
        Name = name;
    }

    public void AddTrack(Track track) => _tracks.Add(track);
    public void RemoveTrack(Track track) => _tracks.Remove(track);
}
