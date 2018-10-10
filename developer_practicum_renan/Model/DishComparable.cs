using System.Collections.Generic;

namespace developer_practicum_renan.Model
{
    public class DishComparable : IEqualityComparer<DishModel>
    {
        public bool Equals(DishModel x, DishModel y)
        {
            var isCoffeOrPotato = false;
            var isEquals = x.Period == y.Period && x.Type == y.Type;

            if (isEquals)
            {
                isCoffeOrPotato =
                    (x.Period == DayPeriod.Morning && x.Type == DishType.Drink) ||
                    (x.Period == DayPeriod.Night && x.Type == DishType.Side);
            }

            return isEquals && !isCoffeOrPotato;
        }

        public int GetHashCode(DishModel obj)
        {
            return base.GetHashCode();
        }
    }
}
