namespace MusicStreamingService.Core.Entities;

public class Track
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Title { get; }
    public Artist Artist { get; }
    public Album Album { get; }
    public TimeSpan Duration { get; }

    public Track(string title, Artist artist, Album album, TimeSpan duration)
    {
        Title = title;
        Artist = artist;
        Album = album;
        Duration = duration;
    }
}
