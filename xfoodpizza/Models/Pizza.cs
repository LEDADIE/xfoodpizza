using System.ComponentModel.DataAnnotations;

namespace xfoodpizza.Models;

public class Pizza
{
    [Display(Name = "Ingrédients")]
    public string ingredients { get; set; }

    [Display(Name = "Nom")]
    public string nom { get; set; }

    [Display(Name = "Id")]
    public int PizzaID { get; set; }

    [Display(Name = "Prix (€)")]
    public float prix { get; set; }

    [Display(Name = "Végétarienne")]
    public bool vetarienne { get; set; }
}