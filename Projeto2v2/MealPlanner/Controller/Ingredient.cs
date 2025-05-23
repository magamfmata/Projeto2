using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlanner.Controller
{
    public class Ingredient: IIngredient
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
            if (obj is Ingredient other)
            {
                return string.Equals(Name, other.Name, StringComparison.OrdinalIgnoreCase)
                    && string.Equals(Type, other.Type, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name?.ToLowerInvariant(), Type?.ToLowerInvariant());
        }
    }
}

