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
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Country>> Get(int id)
    {
        Country? country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
        if (country == null)
            return NotFound();
        return new ObjectResult(country);
    }
    
    [HttpGet("{name}")]
    public async Task<ActionResult<Country>> Get(string name)
    {
        Country? country = await _context.Countries.FirstOrDefaultAsync(c => c.Name.ToLower() == name.ToLower() || c.OfficialName.ToLower() == name.ToLower());
        if (country == null)
            return NotFound();
        return new ObjectResult(country);
    }
}