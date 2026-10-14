namespace PodCastWorld;

public class Podcast
{
    private string _name;
    private string _genre;
    private string _description;

    private List<Episode> _episodes;

    public Podcast(string name, string genre, string description)
    {
        _name = name;
        _genre = genre;
        _description = description;

        _episodes = new List<Episode>();
    }

    public string GetName()
    {
        return _name;
    }

    public void AddEpisode(Episode episode)
    {
        _episodes.Add(episode);
    }

    public List<Episode> GetEpisodes()
    {
        return _episodes;
    }
}