using MusicStreamingService.Core.Entities;

namespace MusicStreamingService.Core.Interfaces;

public interface IPlaylistService
{
    Playlist CreatePlaylist(string name);
    void AddTrack(Playlist playlist, Track track);
}
