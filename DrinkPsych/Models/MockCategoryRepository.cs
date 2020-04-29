using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkPsych.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                    {
                        new Category { CategoryName = "Alcoholoic", Description = "All alcoholic drinks" },
                        new Category { CategoryName = "Non-Alcoholic", Description = "All non-alcoholic drinks" }
                    };
            }
        }        
    }
}
