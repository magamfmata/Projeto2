using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlanner.Controller
{
    public class Recipe : IRecipe
{
    public string Nome { get; }
    public List<Ingredient> Ingredients { get; }

    public Recipe(string name, List<Ingredient> ingredients)
    {
        Name = name;
        Ingredients = ingredientss;
    }

    public int CompareTo(Recipe other)
    {
        return string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
    }
}

