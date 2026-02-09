namespace MusicStreamingService.Core.Entities;

public class User
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; }
    public HashSet<Guid> LikedTracks { get; } = new();

    public User(string name)
    {
        Name = name;
    }
}
