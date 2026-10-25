using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductsController(AppDbContext context)
    {
        _context = context;
    }


    [HttpGet("SQLInjection")]
    public async Task<ActionResult> SQLInjection (string name)
    {
        string query = $"SELECT * FROM OliveOilProducts WHERE Name = '{name}'";
        var products = await _context.OliveOilProducts
        .FromSqlRaw(query)
        .ToListAsync();
        return Ok(products);
        
    }
 
   [HttpGet("NOSQLInjection")] 
    public async Task<ActionResult> NOSQLInjection (string name)
     {
          var products = await _context.OliveOilProducts
                .Where(p => p.Name == name)
                .ToListAsync();
          return Ok(products);
     }




}