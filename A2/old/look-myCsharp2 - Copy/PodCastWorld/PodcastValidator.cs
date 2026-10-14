using System.Text.RegularExpressions;

namespace PodCastWorld;

public static class PodcastValidator
{
    public static bool IsValidPodcastName(string name)
    {
        return Regex.IsMatch(
            name,
            @"^(?=.*[A-Za-z])[A-Za-z0-9 '\:\-]+$");
    }

    public static bool IsValidDescription(string description)
    {
        return description.Any(char.IsLetter);
    }

    public static bool IsValidLength(string input, out int length)
    {
        if (int.TryParse(input, out length))
        {
            return length >= 1 && length <= 300;
        }

        return false;
    }

    public static bool IsValidRecordedDate(
        string input,
        out DateTime date)
    {
        return DateTime.TryParseExact(
            input,
            "dd/MM/yyyy",
            null,
            System.Globalization.DateTimeStyles.None,
            out date);
    }
}