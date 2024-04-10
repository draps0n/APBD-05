using APBD_05.Models;

namespace APBD_05.Repositories;

public interface IAnimalRepository
{
    ICollection<Animal> FetchAnimals();
    Animal? FetchAnimal(int id);
    void AddAnimal(Animal animal);
    void DeleteAnimal(Animal animal);
}