using Model;
using var db = new BlogContext();
Console.WriteLine($"資料庫的路徑是:{db.DbPath}");

// db.Add(new Blog{Uri = "http://www.uuu.com.tw"});
// db.Add(new Blog{Uri = "http://www.tibame.com"});
// db.Add(new Blog{Uri = "http://hahow.in"});
// Console.WriteLine("修改一下資料");
// var blog = db.Blogs!.OrderBy(x => x.BlogId).Last();
// blog.Uri = "https://www.cwb.gov.tw";
// blog.Posts.Add(new Post{Title = "urgent", Content = "Typhoon is comming"});
// blog.Posts.Add(new Post{Title = "urgent", Content = "Earthquake last night"});
// db.SaveChanges();
Console.WriteLine("將資料讀回");
var blogs = db.Blogs!.OrderBy(x => x.BlogId);
foreach(var item in blogs )
{
    Console.WriteLine($"{item.BlogId},{item.Uri}");
    foreach(var post in item.Posts)
    {
        Console.WriteLine($"*{post.Title}/{post.Content}");
    }
}
