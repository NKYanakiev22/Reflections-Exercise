using Microsoft.AspNetCore.Mvc;
using Reflections_Exercise.Models;

[Route("api/[controller]/[Action]")]
public class WatchController : ControllerBase
{
    [HttpGet]
    public IActionResult Play(string id)
    {
        return Ok($"Playing video with id: {id}");
    }

    [HttpDelete]
    public IActionResult DeleteVideo([FromQuery] int id, [FromQuery] string name)
    {
        return Ok($"Deleted video id: {id}, name: {name}");
    }

    [HttpPost]
    public IActionResult AddVideo([FromBody] VideoDTO video)
    {
        return Ok($"Added video with name: {video.Name}");
    }
}