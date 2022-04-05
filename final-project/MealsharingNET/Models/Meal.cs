namespace MealsharingNET.Models;

public class Meal
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public int MaxReservations { get; set; }
    public decimal Price { get; set; }
    public string Location { get; set; }

};