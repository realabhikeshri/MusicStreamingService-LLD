using MusicStreamingService.Core.Entities;
using MusicStreamingService.Core.Interfaces;
using MusicStreamingService.Infrastructure.Repositories;

namespace MusicStreamingService.Services;

public class SearchService : ISearchService
{
    private readonly InMemoryTrackRepository _repo;

    public SearchService(InMemoryTrackRepository repo)
    {
        _repo = repo;
    }

    public IEnumerable<Track> SearchTracks(string query)
    {
        return _repo.GetAll()
            .Where(t => t.Title.Contains(query, StringComparison.OrdinalIgnoreCase));
    }
}
