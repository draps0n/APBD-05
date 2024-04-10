using System.ComponentModel.DataAnnotations;

namespace APBD_05.Models;

public class Visit(int id, DateTime visitData, int animalId, string description, double price)
{
    [Required]
    public int Id { get; set; } = id;
    [Required]
    public DateTime VisitData { get; set; } = visitData;
    [Required]
    public int AnimalId { get; set; } = animalId;
    [Required]
    public string Description { get; set; } = description;
    [Required]
    public double Price { get; set; } = price;
}