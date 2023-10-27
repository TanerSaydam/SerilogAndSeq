using Microsoft.AspNetCore.Mvc;

namespace SerilogAndSeq.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{    
    [HttpGet]
    public IActionResult Get(int number)
    {
        int x = 0;
        try
        {
            int z = x / number;
            return Ok(new { Message = $"Result is {z}"});
        }
        catch (Exception ex)
        {            
            throw new Exception(ex.Message);
        }          
    }
}
