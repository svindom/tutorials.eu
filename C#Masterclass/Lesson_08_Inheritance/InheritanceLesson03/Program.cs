

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
    public Post(int iD, string title, string sendByUserName, bool isPublic)
    {
        ID = iD;
        Title = title;
        SendByUserName = sendByUserName;
        IsPublic = isPublic;
    }
}