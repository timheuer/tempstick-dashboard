﻿namespace tempstick_dashboard.Helpers;

public static class ConverterExtensionMethods
{
    public static double ToFarenheit(this double celsius)
    {
        var converted = (celsius * 1.8) + 32;
        return Math.Round(converted, 1);
    }

    public static string ToFarenheitDisplay(this double celsius)
    {
        var converted = (celsius * 1.8) + 32;
        return $"{Math.Round(converted, 1)}⁰F";
    }

    public static string ToHumidityDisplay(this double humid)
    {
        return $"{Math.Round(humid, 1)}%";
    }

    public static string DisplayDate(this string badDate)
    {
        var fixedDate = badDate.Replace("Z", "");
        return DateTime.Parse(fixedDate).ToString("MMM d, yyyy");
    }

    public static string DisplayTime(this string badDate)
    {
        var fixedDate = badDate.Replace("Z", "");
        return DateTime.Parse(fixedDate).ToString("hh:mm tt");
    }

    public static string OnlineStatus(this string isOffline)
    {
        return (isOffline == "1") ? "Offline" : "Online";
    }

    public static string ToQuality(this int dbm)
    {
        var q = 2 * (dbm + 100);
        return $"{q}%";
    }
}