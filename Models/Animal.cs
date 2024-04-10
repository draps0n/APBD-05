using System.ComponentModel.DataAnnotations;

namespace APBD_05.Models;

public class Animal(int id, string name, string category, double weight, string furColor)
{
    [Required]
    public int Id { get; set; } = id;
    [Required]
    public string Name { get; set; } = name;
    [Required]
    public string Category { get; set; } = category;
    [Required]
    public double Weight { get; set; } = weight;
    [Required]
    public string FurColor { get; set; } = furColor;
}