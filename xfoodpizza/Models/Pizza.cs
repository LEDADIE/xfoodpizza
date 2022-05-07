using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace xfoodpizza.Models;

public class Pizza
{
    [JsonIgnore]
    [Display(Name = "Ingrédients")]
    public string ingredients { get; set; }

    [NotMapped]
    [JsonPropertyName("ingredients")]
    public string[] listeIngredients
    {
        get
        {
            if ((ingredients == null) || (ingredients.Count() == 0))
            {
                return null;
            }
            return ingredients.Split(", ");
        }
    }

    [Display(Name = "Nom")]
    public string nom { get; set; }

    [JsonIgnore]
    [Display(Name = "Id")]
    public int PizzaID { get; set; }

    [Display(Name = "Prix (€)")]
    public float prix { get; set; }

    [Display(Name = "Végétarienne")]
    public bool vetarienne { get; set; }
}