using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using duktur.Data;

namespace duktur.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.TotalTickets = await _context.Tickets.CountAsync();
            ViewBag.NewTickets = await _context.Tickets.CountAsync(t => t.Status == "New");
            ViewBag.InProgressTickets = await _context.Tickets.CountAsync(t => t.Status == "In Progress");
            ViewBag.ResolvedTickets = await _context.Tickets.CountAsync(t => t.Status == "Resolved");
            return View();
        }
    }
}