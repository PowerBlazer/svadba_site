using Microsoft.AspNetCore.Mvc;

namespace server.Controllers;

[Route("api/action")]
[ApiController]
public class ActionController: ControllerBase
{
    public ActionController()
    {
        
    }

    [HttpPost]
    public async Task<IActionResult> SaveAction()
    {
        return Ok();
    }
}