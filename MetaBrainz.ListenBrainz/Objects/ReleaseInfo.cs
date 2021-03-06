using System;
using System.Collections.Generic;

using MetaBrainz.Common.Json;
using MetaBrainz.ListenBrainz.Interfaces;

namespace MetaBrainz.ListenBrainz.Objects {

  internal sealed  class ReleaseInfo : JsonBasedObject, IReleaseInfo {

    public ReleaseInfo(string name, int listenCount) {
      this.Name = name;
      this.ListenCount = listenCount;
    }

    public IReadOnlyList<Guid>? ArtistIds { get; set; }

    public Guid? ArtistMessyId { get; set; }

    public string? ArtistName { get; set; }

    public Guid? Id { get; set; }

    public int ListenCount { get; }

    public Guid? MessyId { get; set; }

    public string Name { get; }

  }

}
