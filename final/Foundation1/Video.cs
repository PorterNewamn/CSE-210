using System.ComponentModel.DataAnnotations;

class Video
{
    public string _videoTitle;
    public string _length;
    public string _author;

    public void DisplayVidDetals()
    {
        Console.WriteLine($"\n{_videoTitle}\n by: {_author}. \n length of the video is: {_length}");
    }
}