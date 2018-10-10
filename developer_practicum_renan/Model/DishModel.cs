using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace developer_practicum_renan.Model
{
    public enum DayPeriod
    {
        Morning = 1,
        Night = 2,
        None = 3
    }

    public enum DishType
    {
        Entree = 1,
        Side = 2,
        Drink = 3,
        Dessert = 4,
        None = 5
    }

    public class DishModel
    {
        public string Name { get; set; }
        public DayPeriod Period { get; set; }
        public DishType Type { get; set; }
    }
}
