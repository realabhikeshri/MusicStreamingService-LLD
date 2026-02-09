namespace MusicStreamingService.Core.Entities;

public class Artist
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; }

    public Artist(string name)
    {
        Name = name;
    }
}
