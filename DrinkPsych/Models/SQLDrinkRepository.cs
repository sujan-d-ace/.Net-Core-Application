using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkPsych.Models
{
    public class SQLDrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _appDbContext;

        public SQLDrinkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Drink GetDrinkById(int drinkid)
        {
            return (_appDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkid));

        }

        IEnumerable<Drink> IDrinkRepository.Drinks()
        {
            return (_appDbContext.Drinks.Include(c => c.Category));
        }

        IEnumerable<Drink> IDrinkRepository.PreferredDrinks()
        {
            return (_appDbContext.Drinks.Where(p => p.IsPreferredDrink).Include(c => c.Category));
        }
    }
}
