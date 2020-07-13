using System;
using System.ComponentModel.DataAnnotations;

namespace cs_burgershack_api.Models
{
  public class Burger
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    [Range(0, double.MaxValue)]
    public double Price { get; set; }
    public string Description { get; set;}

    public Burger()
    {
      
    }

    public Burger(string name, double price, string description)
    {
      Name = name;
      Price = Price;
      Description = description;
    }
  }
}