using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var now = new CurrentTime { ServerTime = DateTime.Now };
        _context.Times.Add(now);
        _context.SaveChanges();
        return View(now);
    }
}
