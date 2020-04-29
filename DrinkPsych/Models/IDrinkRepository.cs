using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkPsych.Models
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks();
        IEnumerable<Drink> PreferredDrinks();
        Drink GetDrinkById(int drinkid);
    }
}
