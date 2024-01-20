Post myPost1 = new Post("Thanks for helping me out with learning English", true, "Alex N");
Console.WriteLine(myPost1.ToString());

ImagePost myImagePost1 = new ImagePost("Check out my new Steels", true, "Alex N", "https://images.com/shoes");
Console.WriteLine(myImagePost1.ToString());

VideoPost videoPost1 = new VideoPost("How to learn C#", true, "Alex N", "https://video.com/csharp-learning", 12);
Console.WriteLine(videoPost1.ToString());

videoPost1.Play();
Console.WriteLine("Press any key to stop a video");
Console.ReadKey();
videoPost1.Stop();

Console.ReadKey();


public class Post
{
    private static int currentPostID;



    //properties
    protected int ID { get; set; }
    protected string Title { get; set; }
    protected string SendByUserName { get; set; }
    protected bool IsPublic { get; set;}
    
    // Defaulr constructor. If a derived class does not invoke a base class constructor explicitly, 
    // the default constructor is called implicitly
    public Post()
    {
        this.ID = 0;
        this.Title = "My first post";
        this.SendByUserName = "Johny";
        this.IsPublic = true;
    }

    // Instance constructor that has three parameters
    public Post(string title, bool isPublic, string sendByUserName)
    {
        this.ID = GetNextID();
        this.Title = title;
        this.SendByUserName = sendByUserName;
        this.IsPublic = isPublic;
    }

    protected int GetNextID()
    {
        return ++currentPostID;
    }

    public void Update(string title, bool isPublic)
    {
        this.Title = title;
        this.IsPublic = isPublic;
    }


    // This virtual method override of the ToString method that is inherited
    // from System.Object
    public override string ToString()
    {
        return String.Format($"{this.ID} - {this.Title} - by {this.SendByUserName}");
    }
}

// ImagePost class derives from Post and adds a property (ImageURL) and two constructors
class ImagePost : Post
{
    public string ImageURL { get; set; }

    public ImagePost()
    {

    }
    public ImagePost(string title, bool isPublic, string sendByUserName, string imageURL)
    {
        // The following properties and the GetNextID() method are inherited from the Post class
        this.ID = GetNextID();
        this.Title = title;
        this.IsPublic = isPublic;
        this.SendByUserName= sendByUserName;

        // Property ImageUrl is a member of the ImagePost class, but not of the Post class itself.
        this.ImageURL = imageURL;
    }

    public override string ToString()
    {
        return String.Format($"{this.ID} - {this.Title} - by {this.SendByUserName} - link: {this.ImageURL}");
    }
}

class VideoPost : Post
{
    // fields
    protected bool isPlaying = false;
    protected int currentDuration = 0;
    Timer timer;

    // properties
    protected string VideoURL { get; set; }
    protected int Length { get; set; }

    public VideoPost() 
    {

    }
    public VideoPost(string title, bool isPublic, string sendByUserName, string videoURL, int length)
    {
        // The following properties and the GetNextID() method are inherited from the Post class
        this.ID = GetNextID();
        this.Title = title;
        this.IsPublic = isPublic;
        this.SendByUserName = sendByUserName;

        // Property of the VideoPost class, but not of the Post class itself.
        this.VideoURL = videoURL;
        this.Length = length;
    }

    public override string ToString()
    {
        return String.Format($"{this.ID} - {this.Title} - {this.Length} min length - by {this.SendByUserName} - link: {this.VideoURL}");
    }

    public void Play()
    {
        if (!isPlaying)
        {
            isPlaying = true;
            Console.WriteLine("Playing");
            timer = new Timer(TimerCallBack, null, 0, 1000);
        }
    }

    private void TimerCallBack(Object o)
    {
        if (currentDuration < Length)
        {
            currentDuration++;
            Console.WriteLine($"Video at {currentDuration} sec");
            GC.Collect(); // calling th garbage collector which will clean up all the mess
        }
        else
        {
            Stop();
        }
    }

    public void Stop() 
    {
        if (isPlaying)
        {
            isPlaying = false;
            Console.WriteLine($"Stopped at {currentDuration} sec");
            currentDuration = 0;
            timer.Dispose();
        }
    }


}
