using Microsoft.AspNetCore.Mvc;

namespace cratis_experiments;

[Route("api/[controller]")]
public class TestApi : ControllerBase
{
    [HttpPost("test1")]
    public async Task<IActionResult> GetTest1()
    {
        // Works
        await Task.Delay(1);
        return Ok("test1");
    }
    
    [HttpGet("test2")]
    public async Task<IActionResult> GetTest2()
    {
        // Works
        await Task.Delay(1);
        return Ok("test2");
    }
    
    [HttpGet("test3/{id:guid}")]
    public async Task<IActionResult> GetTest3(Guid id)
    {
        // Doesnt
        await Task.Delay(1);
        return Ok("test3 " + id);
    }
    
    [HttpGet("test5")]
    public async Task<IActionResult> GetTest5([FromQuery]Guid id)
    {
        // Doesnt
        await Task.Delay(1);
        return Ok("test5 " + id);
    }
}