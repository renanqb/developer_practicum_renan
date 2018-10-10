using developer_practicum_renan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace developer_practicum_renan.Data
{
    public class DishContext
    {
        public List<DishModel> DishCollection { get; set; }

        public DishContext()
        {
            DishCollection = new List<DishModel>
            {
                new DishModel { Period = DayPeriod.Morning, Type = DishType.Entree, Name = "eggs" },
                new DishModel { Period = DayPeriod.Morning, Type = DishType.Side, Name = "toast" },
                new DishModel { Period = DayPeriod.Morning, Type = DishType.Drink, Name = "coffee" },
                new DishModel { Period = DayPeriod.Morning, Type = DishType.Dessert, Name = "error" },
                new DishModel { Period = DayPeriod.Night, Type = DishType.Entree, Name = "steak" },
                new DishModel { Period = DayPeriod.Night, Type = DishType.Side, Name = "potato" },
                new DishModel { Period = DayPeriod.Night, Type = DishType.Drink, Name = "wine" },
                new DishModel { Period = DayPeriod.Night, Type = DishType.Dessert, Name = "cake" },
            };
        }
    }
}
