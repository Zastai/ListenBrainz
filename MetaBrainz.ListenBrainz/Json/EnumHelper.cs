using System;

namespace MetaBrainz.ListenBrainz.Json {

  internal static class EnumHelper {

    public static StatisticsRange? ParseStatisticsRange(string? text) {
      if (text == null)
        return null;
      return text switch {
        "all_time" => StatisticsRange.AllTime,
        "week" => StatisticsRange.Week,
        "month" => StatisticsRange.Month,
        "year" => StatisticsRange.Year,
        _ => StatisticsRange.Unknown,
      };
    }

    public static string ToJson(this StatisticsRange range) {
      return range switch {
        StatisticsRange.AllTime => "all_time",
        StatisticsRange.Week => "week",
        StatisticsRange.Month => "month",
        StatisticsRange.Year => "year",
        _ => throw new ArgumentOutOfRangeException(nameof(range), range, "Invalid statistics range specified.")
      };
    }

  }

}
