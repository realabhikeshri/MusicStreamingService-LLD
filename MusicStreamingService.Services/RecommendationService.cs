using MusicStreamingService.Core.Entities;
using MusicStreamingService.Core.Interfaces;

namespace MusicStreamingService.Services;

public class RecommendationService : IRecommendationService
{
    public IEnumerable<Track> Recommend(User user)
    {
        // Stub: hook ML / collaborative filtering later
        return Enumerable.Empty<Track>();
    }
}
