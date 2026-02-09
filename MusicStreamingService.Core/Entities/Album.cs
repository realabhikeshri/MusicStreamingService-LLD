namespace MusicStreamingService.Core.Entities;

public class Album
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Title { get; }
    public Artist Artist { get; }

    public Album(string title, Artist artist)
    {
        Title = title;
        Artist = artist;
    }
}
