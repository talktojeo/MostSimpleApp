using Microsoft.AspNetCore.Mvc;
using System; // 👈 This is required for DateTime

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
