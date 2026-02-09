using MusicStreamingService.Core.Entities;

namespace MusicStreamingService.Core.Interfaces;

public interface IRecommendationService
{
    IEnumerable<Track> Recommend(User user);
}
