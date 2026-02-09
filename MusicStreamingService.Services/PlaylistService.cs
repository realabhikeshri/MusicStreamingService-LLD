using MusicStreamingService.Core.Entities;
using MusicStreamingService.Core.Interfaces;

namespace MusicStreamingService.Services;

public class PlaylistService : IPlaylistService
{
    public Playlist CreatePlaylist(string name) => new(name);

    public void AddTrack(Playlist playlist, Track track)
    {
        playlist.AddTrack(track);
    }
}
