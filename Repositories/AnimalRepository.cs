using APBD_05.Models;

namespace APBD_05.Repositories;

public class AnimalRepository : IAnimalRepository
{
    private static readonly ICollection<Animal> Animals = new List<Animal>
    {
        new Animal(1, "Azor", "Pies", 3.5, "black"),
        new Animal(2, "Mruczek", "Kot", 2, "biały"),
        new Animal(3, "Monte", "Królik", 2.5, "biało-brązowy"),
    };

    public ICollection<Animal> FetchAnimals()
    {
        return Animals;
    }

    public Animal? FetchAnimal(int id)
    {
        return Animals.FirstOrDefault(animal => animal.Id == id);
    }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public void DeleteAnimal(Animal animal)
    {
        Animals.Remove(animal);
    }
}