using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationExercise
{

    // Is it better to start everything as public and then go back and encapsulate when you know what needs to be called in other classes?
    // why not just have balance as a static decimal that increments everytime you cook a meal?
    // if we keep the bookeeping inside meal we can change price and cost to private
    public class Meal
    {
        public string name;
        public decimal price;
        public decimal cost;

        public Meal(string name, decimal price, decimal cost)
        {
            this.name = name;
            this.price = price;
            this.cost = cost;
        }
        public static void cookMeal(Meal meal)
        {
            Console.WriteLine("The meal {0} has been cooked.", meal.name);
        }
    }
    public class Bookkeeping
    {
        // private static decimal balance = 0;
        public static decimal balance = 0;
        public static void processOrder(Meal meal)
        {

            balance = balance + meal.price;
            balance = balance - meal.cost;
        }

        //public static decimal showBalance()
        //{
        //    return balance;
        //}
    }
    public class Order
    {
        public void takeOrder(Meal meal)
        {
            Console.WriteLine("The meal {0} has been ordered.", meal.name);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Meal steak = new Meal("Steak", 20.00M, 5.00M);

            Meal fajitas = new Meal("Fajitas", 12.00M, 2.00M);

            Meal pumpkinRisotto = new Meal("Pumpkin Risotto", 10.00M, 1.00M);

            Order order1 = new Order();
            order1.takeOrder(steak);
            Meal.cookMeal(steak);
            Bookkeeping.processOrder(steak);
            Order order2 = new Order();
            order2.takeOrder(pumpkinRisotto);
            Meal.cookMeal(pumpkinRisotto);
            Bookkeeping.processOrder(pumpkinRisotto);

            // decimal balance = Bookkeeping.showBalance();
            Console.WriteLine("Tonight in the restaurant, we made £{0:N2}.", Bookkeeping.balance);
        }
    }
}
