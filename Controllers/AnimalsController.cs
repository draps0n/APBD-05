using APBD_05.Models;
using APBD_05.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_05.Controllers;

[ApiController]
[Route("animals")]
public class AnimalsController : ControllerBase
{
    private readonly IAnimalService _animalService;

    public AnimalsController(IAnimalService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = _animalService.GetAnimals();
        return Ok(animals);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animalService.GetAnimal(id);
        if (animal == null)
        {
            return NotFound($"Animal with id={id} was not found");
        }
        return Ok(animal);
    }
    
    [HttpPost]
    public IActionResult AddAnimal([FromBody] Animal animal)
    {
        _animalService.AddAnimal(animal);
        return Created();
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, [FromBody] Animal animal)
    {
        var animalToEdit = _animalService.GetAnimal(id);

        if (animalToEdit == null)
        {
            return NotFound($"Animal with id={id} was not found");
        }
        
        _animalService.DeleteAnimal(animalToEdit);
        _animalService.AddAnimal(animal);

        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animalToDelete = _animalService.GetAnimal(id);

        if (animalToDelete == null)
        {
            return NotFound($"Animal with id={id} was not found");
        }

        _animalService.DeleteAnimal(animalToDelete);
        
        return NoContent();
    }
    
    [HttpGet("visits/{animalId:int}")] // Czy nie lepiej "{animalId:int}/visits"
    public IActionResult GetVisitsForAnimal(int animalId)
    {
        var animalVisits = _animalService.GetVisitsForAnimal(animalId);
        return Ok(animalVisits);
    }
    
    [HttpPost("visits")]
    public IActionResult AddVisit([FromBody] Visit visit)
    {
        _animalService.AddVisit(visit);
        return Created();
    }
}