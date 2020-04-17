using System.Text.Json;

using MetaBrainz.Common.Json;
using MetaBrainz.Common.Json.Converters;
using MetaBrainz.ListenBrainz.Interfaces;
using MetaBrainz.ListenBrainz.Objects;

namespace MetaBrainz.ListenBrainz.Json.Writers {

  internal sealed class ListenDataPayloadWriter : ObjectWriter<SubmissionPayload<ISubmittedListenData>> {

    public static readonly ListenDataPayloadWriter Instance = new ListenDataPayloadWriter();

    protected override void WriteObjectContents(Utf8JsonWriter writer, SubmissionPayload<ISubmittedListenData> value, JsonSerializerOptions options) {
      writer.WriteString("listen_type", value.Type);
      switch (value.Type) {
        case "playing_now": {
          writer.WritePropertyName("payload");
          JsonUtils.WriteList(writer, value.Listens, options, ListenDataWriter.Instance);
          break;
        }
        default:
          throw new JsonException($"Invalid submission payload type: '{value.Type}'.");
      }
    }

  }

}