using APBD_05.Models;
using APBD_05.Repositories;

namespace APBD_05.Services;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;

    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    public ICollection<Animal> GetAnimals()
    {
        return _animalRepository.FetchAnimals();
    }

    public Animal? GetAnimal(int id)
    {
        return _animalRepository.FetchAnimal(id);
    }

    public void AddAnimal(Animal animal)
    {
        _animalRepository.AddAnimal(animal);
    }

    public void DeleteAnimal(Animal animal)
    {
        _animalRepository.DeleteAnimal(animal);
    }

    public IEnumerable<Visit> GetVisitsForAnimal(int animalId)
    {
        return _animalRepository.GetVisitsForAnimal(animalId);
    }

    public void AddVisit(Visit visit)
    {
        _animalRepository.AddVisit(visit);
    }
}