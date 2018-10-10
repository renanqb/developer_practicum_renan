using System.Collections.Generic;
using System.Linq;

namespace developer_practicum_renan.Model
{
    public class DishModelContainer
    {
        public List<DishModel> Dishes { get; private set; }

        public DishModelContainer(List<DishModel> dishes)
        {
            Dishes = dishes ?? new List<DishModel>();
        }

        public override string ToString()
        {
            var distinctList = Dishes
                .OrderBy(o => o.Type)
                .Distinct(new DishComparable());

            var groupedStringDishes = distinctList
                .GroupBy(g => g.Name)
                .Select(s => s.Count() == 1 ? s.Key : string.Format("{0}(x{1})", s.Key, s.Count()));

            return string.Join(", ", groupedStringDishes);
        }
    }
}
