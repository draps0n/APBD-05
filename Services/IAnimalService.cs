using APBD_05.Models;

namespace APBD_05.Services;

public interface IAnimalService
{
    ICollection<Animal> GetAnimals();
    Animal? GetAnimal(int id);
    void AddAnimal(Animal animal);
    void DeleteAnimal(Animal animal);
}