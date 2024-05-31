using HomeWork65.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeWork65.Controllers;
[ApiController]
[Route("api/[controller]/[action]")]
public class CountryController : Controller
{
    private CountryContext _context;

    public CountryController(CountryContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Country>>> GetAll()
    {
        var countries = await _context.Countries.ToListAsync();
        return countries != null ? countries : new List<Country>();
    }
    
    [HttpGet]
    public async Task<ActionResult<Country>> GetById(int id)
    {
        Country? country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
        if (country == null)
            return NotFound();
        return new ObjectResult(country);
    }
    
    [HttpGet]
    public async Task<ActionResult<Country>> GetByName(string name)
    {
        Country? country = await _context.Countries.FirstOrDefaultAsync(c => c.Name.ToLower() == name.ToLower() || c.OfficialName.ToLower() == name.ToLower());
        if (country == null)
            return NotFound();
        return new ObjectResult(country);
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<Country>> Delete(int id)
    {
        Country? country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
        if (country == null)
            return NotFound();
        _context.Countries.Remove(country);
        await _context.SaveChangesAsync();
        return Ok(country);
    }
    
    [HttpPut]
    public async Task<ActionResult<Country>> Put(Country country)
    {
        if (country == null)
            return BadRequest();
        if (!_context.Countries.Any(c => c.Id == country.Id))
            return NotFound();
        _context.Update(country);
        await _context.SaveChangesAsync();
        return Ok(country);
    }
    
    [HttpPost]
    public async Task<ActionResult<Country>> Post(Country country)
    {
        if (country == null || _context.Countries.Any(c => c.Id == country.Id))
            return BadRequest();
        _context.Countries.Add(country);
        await _context.SaveChangesAsync();
        return Ok(country);
    }
}