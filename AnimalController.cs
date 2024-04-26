using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Http;

namespace APBD_Zadanie_3;

[Route("api/animals")]
[ApiController]
public class AnimalController : ControllerBase
{
    
    private IAnimalService _animalService;
    
    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }
    
    
    [HttpGet]
    public IActionResult GetAnimal([FromQuery] string orderBy="name")
    {
        var animal = _animalService.GetAnimal(orderBy);
        return Ok(animal);
    }
    
    [HttpPost]
    public IActionResult AddAnimal(AnimalPostDto animalPostDto)
    {
        _animalService.AddAnimal(animalPostDto);
        return StatusCode((StatusCodes.Status201Created));
    }
    
    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, [FromBody] Animal animal)
    {
        _animalService.UpdateAnimal(id, animal);
        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        _animalService.DeleteAnimal(id);
        return NoContent();
    }
}