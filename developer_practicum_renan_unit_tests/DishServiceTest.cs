using developer_practicum_renan.Business;
using developer_practicum_renan.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace developer_practicum_renan_unit_tests
{
    [TestClass]
    public class DishServiceTest
    {
        private IDishService DishService { get; set; }

        public DishServiceTest()
        {
            DishService = new DishService();
        }

        [TestMethod]
        public void UserCanOrderCompleteBreakfast()
        {
            var period = DayPeriod.Morning;
            var types = new DishType[3] { DishType.Entree, DishType.Side, DishType.Drink };

            var output = DishService.GetDishes(period, types);

            Assert.AreEqual("eggs, toast, coffee", output.ToString());
        }

        [TestMethod]
        public void UserCanOrderCompleteBreakfastInAnyOrdenation()
        {
            var period = DayPeriod.Morning;
            var types = new DishType[3] { DishType.Side, DishType.Entree, DishType.Drink };

            var output = DishService.GetDishes(period, types);

            Assert.AreEqual("eggs, toast, coffee", output.ToString());
        }

        [TestMethod]
        public void UserCanOrderCompleteBreakfastButDessert()
        {
            var period = DayPeriod.Morning;
            var types = new DishType[4] 
            {
                DishType.Side, DishType.Entree, DishType.Drink, DishType.Dessert
            };

            var output = DishService.GetDishes(period, types);

            Assert.AreEqual("eggs, toast, coffee, error", output.ToString());
        }

        [TestMethod]
        public void UserCanOrderCompleteBreakfastWithALotOfCoffee()
        {
            var period = DayPeriod.Morning;
            var types = new DishType[5]
            {
                DishType.Entree, DishType.Side, DishType.Drink, DishType.Drink, DishType.Drink
            };

            var output = DishService.GetDishes(period, types);

            Assert.AreEqual("eggs, toast, coffee(x3)", output.ToString());
        }



        [TestMethod]
        public void UserCanOrderCompleteDinner()
        {
            var period = DayPeriod.Night;
            var types = new DishType[4] 
            {
                DishType.Entree, DishType.Side, DishType.Drink, DishType.Dessert
            };

            var output = DishService.GetDishes(period, types);

            Assert.AreEqual("steak, potato, wine, cake", output.ToString());
        }

        [TestMethod]
        public void UserCanOrderCompleteBreakfastWithALotOfPotatos()
        {
            var period = DayPeriod.Night;
            var types = new DishType[4]
            {
                DishType.Entree, DishType.Side, DishType.Side, DishType.Dessert
            };

            var output = DishService.GetDishes(period, types);

            Assert.AreEqual("steak, potato(x2), cake", output.ToString());
        }

        [TestMethod]
        public void UserCanOrderCompleteDinnerWithNotFoundItems()
        {
            var period = DayPeriod.Night;
            var types = new DishType[4]
            {
                DishType.Entree, DishType.Side, DishType.Drink, DishType.None
            };

            var output = DishService.GetDishes(period, types);

            Assert.AreEqual("steak, potato, wine, error", output.ToString());
        }
    }
}
