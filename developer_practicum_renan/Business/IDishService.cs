using developer_practicum_renan.Model;

namespace developer_practicum_renan.Business
{
    public interface IDishService
    {
        DishModelContainer GetDishes(DayPeriod period, DishType[] types);
    }
}
