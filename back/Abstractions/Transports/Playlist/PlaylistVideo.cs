﻿namespace Videyo.Api.Abstractions.Transports.Playlist;

public class PlaylistVideo
{
    public required Guid Id { get; set; }

    public required string Label { get; set; }
}