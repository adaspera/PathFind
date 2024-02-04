using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PathAPI.Models;
using PineAPP.Data;

namespace PathAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class LocationSearchController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public LocationSearchController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet("{input:alpha}")]
    public async Task<ActionResult> GetLocation(string input)
    {
        var results = await _dbContext.Location
            .Where(location => location.Name.StartsWith(input))
            .Take(10)
            .ToListAsync();
        return Ok(results);
    }
}