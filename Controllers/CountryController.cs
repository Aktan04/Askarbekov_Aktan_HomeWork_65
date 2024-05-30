using HomeWork65.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeWork65.Controllers;
[ApiController]
[Route("[controller]")]
public class CountryController : Controller
{
    private CountryContext _context;

    public CountryController(CountryContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Country>>> Get()
    {
        return await _context.Countries.ToListAsync();
    }

}