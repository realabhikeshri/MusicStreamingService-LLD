# MusicStreamingService

A C# music streaming service implemented using a layered architecture with clear separation of domain, infrastructure, application logic, and execution.


## Layers

### Core
Defines domain entities, enums, and service contracts.
Contains no implementation details and has no dependencies.

### Infrastructure
Provides in-memory repository implementations for users, tracks, and playlists.
Implements abstractions defined in Core.

### Services
Implements business operations such as playback, playlists, search, and recommendations.
Coordinates domain models and repositories.

### App
Application entry point.
Responsible for wiring dependencies and running the application.


---

## Summary

The project is modular, extensible, and designed to allow infrastructure or presentation changes without impacting core business logic.

##Author

Abhishek Keshri
