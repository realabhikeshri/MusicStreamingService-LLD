using MusicStreamingService.Core.Entities;

namespace MusicStreamingService.Core.Interfaces;

public interface ISearchService
{
    IEnumerable<Track> SearchTracks(string query);
}
