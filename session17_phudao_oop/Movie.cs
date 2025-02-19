class Movie
{
    private string movieID;
    public string MovieID { get; set; }

    private string title;
    public string Title { get; set; }

    private string director;
    public string Director { get; set; }

    private int duration; // in minutes
    public int Duration { get; set; }

    private int rating;
    public int Rating { get; set; }

    public Movie(
        string movieID,
        string title,
        string director,
        int duration,
        int rating
    )
    {
        MovieID = movieID;
        Title = title;
        Director = director;
        Duration = duration;
        Rating = rating;
    }
}