using developer_practicum_renan.Data;
using developer_practicum_renan.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace developer_practicum_renan.Business
{
    public class DishService : IDishService
    {
        public readonly DishContext Context = new DishContext();

        public DishModelContainer GetDishes(DayPeriod period, DishType[] types)
        {
            if (types == null && !types.Any())
            {
                throw new FormatException();
            }

            var tempDishList = new List<DishModel>();
            var periodDishes = Context.DishCollection.Where(w => w.Period == period);
            foreach (var type in types)
            {
                var foundDish = 
                    periodDishes.SingleOrDefault(s => s.Type == type) ?? 
                    new DishModel { Period = DayPeriod.None, Type = DishType.None, Name = "error" };

                tempDishList.Add(foundDish);
            }

            return new DishModelContainer(tempDishList);
        }
    }
}
