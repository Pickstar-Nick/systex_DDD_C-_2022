using Model;
using var db = new BlogContext();
Console.WriteLine($"資料庫的路徑是:{db.DbPath}");

db.Add(new Blog{Uri = "http://www.uuu.com.tw"});
db.Add(new Blog{Uri = "http://www.tibame.com"});
db.Add(new Blog{Uri = "http://hahow.in"});
db.SaveChanges();
var blogs = db.Blogs!.OrderBy(x => x.BlogId);
foreach(var item in blogs )
{
    Console.WriteLine($"{item.BlogId},{item.Uri}");
}
