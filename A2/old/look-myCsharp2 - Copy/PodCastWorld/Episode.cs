namespace PodCastWorld;

public class Episode
{
    private string _name;
    private string _description;
    private DateTime _recordedDate;
    private int _lengthMinutes;
    private bool _premiumOnly;

    public Episode(
        string name,
        string description,
        DateTime recordedDate,
        int lengthMinutes,
        bool premiumOnly)
    {
        _name = name;
        _description = description;
        _recordedDate = recordedDate;
        _lengthMinutes = lengthMinutes;
        _premiumOnly = premiumOnly;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsPremiumOnly()
    {
        return _premiumOnly;
    }
}