using Microsoft.AspNetCore.Mvc;
using Action = server.Models.Action;

namespace server.Controllers;

[Route("api/action")]
[ApiController]
public class ActionController: ControllerBase
{
    private readonly ApplicationDbContext _dbContext;
    public ActionController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    public async Task<IActionResult> SaveAction([FromBody]Action action)
    {
        action.CreatedAt = DateTime.UtcNow;
        
        _dbContext.Actions.Add(action);
        
        await _dbContext.SaveChangesAsync();
        
        return Ok(action);
    }
}