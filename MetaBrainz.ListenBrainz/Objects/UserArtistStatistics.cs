using System;
using System.Collections.Generic;

using MetaBrainz.ListenBrainz.Interfaces;

namespace MetaBrainz.ListenBrainz.Objects {

  internal sealed class UserArtistStatistics : UserStatistics, IUserArtistStatistics {

    public UserArtistStatistics(DateTimeOffset lastUpdated, int offset, StatisticsRange range, string user)
    : base(lastUpdated, offset, range, user)
    { }

    public IReadOnlyList<IArtistInfo>? Artists { get; set; }

    public DateTimeOffset? NewestListen { get; set; }

    public DateTimeOffset? OldestListen { get; set; }

    public int? TotalArtistCount { get; set; }

  }

}