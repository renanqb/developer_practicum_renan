using developer_practicum_renan.Business;
using developer_practicum_renan.Model;
using System;
using System.Linq;

namespace developer_practicum_renan
{
    class Program
    {
        static void Main(string[] args)
        {
            var dishService = (IDishService)new DishService();

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("DishType \t morning \t night");
                    Console.WriteLine("1(entrée) \t eggs \t\t steak");
                    Console.WriteLine("2(side) \t toast \t\t potato");
                    Console.WriteLine("3(drink) \t coffee \t wine");
                    Console.WriteLine("4(dessert) \t - \t\t cake");

                    var input = Console.ReadLine();
                    var inputArray = input.Split(',');

                    var inputPeriod = (DayPeriod)Enum.Parse(typeof(DayPeriod), inputArray[0], true);
                    var inputTypes = inputArray.Skip(1).Select(s => (DishType)int.Parse(s)).ToArray();

                    var resp = dishService.GetDishes(inputPeriod, inputTypes);
                    Console.WriteLine(resp.ToString());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro de formato: informe as opção no formato correto");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("");
                    Console.WriteLine("Pressione qualquer tecla para continuar ou ESC para sair");
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
