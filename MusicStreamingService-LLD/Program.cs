using MusicStreamingService.Core.Entities;
using MusicStreamingService.Infrastructure.Repositories;
using MusicStreamingService.Services;

var artist = new Artist("Coldplay");
var album = new Album("Parachutes", artist);
var track = new Track("Yellow", artist, album, TimeSpan.FromMinutes(4));

var trackRepo = new InMemoryTrackRepository();
trackRepo.Add(track);

var playbackService = new PlaybackService();
playbackService.Play(track);
