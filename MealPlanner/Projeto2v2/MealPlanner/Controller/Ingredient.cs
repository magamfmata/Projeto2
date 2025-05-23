using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlanner.Projeto2v2.MealPlanner.Controller
{
using System;

namespace MealPlanner.Model
{
    public class Ingredient : IIngredient
    {
        public string Name { get; }
        public string Type { get; }

        public Ingredient(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Ingredient);
        }

        public bool Equals(Ingredient other)
        {
            if (other is null) return false;
            return string.Equals(Name, other.Name, StringComparison.OrdinalIgnoreCase)
                && string.Equals(Type, other.Type, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name?.ToLowerInvariant(), Type?.ToLowerInvariant());
        }
    }
}