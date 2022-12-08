namespace Model;
public class Blog
{
    public int BlogId { get; set; }
    public string? Uri { get; set; } //?代表可為null
    public List<Post> Posts { get; set;} = new();
}