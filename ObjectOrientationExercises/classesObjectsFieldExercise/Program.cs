using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesObjectsFieldExercise
{

    class Car
    {
        public string make;
        public string model;
        public bool turbo;
        public int price;
        public bool sold;
        public int doors;
        //public static List<Car> allStock = new List<Car>();
        // DON'T Try to manage the class within the class
        public static int stock = 0;
        public static int salesTotal = 0;

        public Car(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.doors = 4;
            sold = false;
            turbo = false;
            //allStock.Add(this);
            // DON'T Try to manage
            Car.stock += 1;
        }

        public Car(string make, string model, int price, string hasTurbo)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            turbo = true;
            this.doors = 4;
            sold = false;
            Car.stock += 1;
        }
        public Car(string make, string model, int price, int doors)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            turbo = false;
            this.doors = doors;
            sold = false;
            Car.stock += 1;
        }


        public void DisplayCar()
        {
            Console.WriteLine("Make: {0} Model: {1} Price: £{2} Turbo: {3} Doors: {4}", make, model, price, turbo, doors);
        }

        public void SellCar()
        {
            sold = true;
        }

        public static void DisplayAvailableStock(List<Car> allStock)
        {
            for (int i = 0; i<allStock.Count; i += 1)
            {
                if (allStock[i].sold == false)
                {
                    allStock[i].DisplayCar();
                }
            }
        }

        public static void TotalSales(List<Car> allStock)
        {
            for (int i = 0; i < allStock.Count; i += 1)
            {
               
                if (allStock[i].sold == true)
                {
                    salesTotal += allStock[i].price;
                }
            }
            Console.WriteLine("We have sold £{0} worth of cars",salesTotal);
        }

    }

    


    class Program
    {
        static void Main(string[] args)
        {

            List<Car> allStock = new List<Car>();

            Car A5TNMTN = new Car("Aston Martin", "DB9", 75000, 2);
            //A5TNMTN.make = "Aston Martin";
            //A5TNMTN.model = "DB9";
            //A5TNMTN.price = 75000;
            //A5TNMTN.sold = false;
            //Car.stock += 1;
            allStock.Add(A5TNMTN);
            

            Car RENAU1T = new Car("Renault", "Clio", 2500);
            //RENAU1T.AddCar("Renault", "Clio", 2500);
            allStock.Add(RENAU1T);
                     
            Car FOCU5R5 = new Car("Ford", "Focus RS", 20000, "Turbo");
            //FOCU5R5.AddCar("Ford", "Focus RS", 20000);
            allStock.Add(FOCU5R5);

            Car MRCACL5 = new Car("Mercedes", "A Class", 30000);
            //MRCACL5.AddCar("Mercedes","A Class", 30000);
            allStock.Add(MRCACL5);

            Console.WriteLine("We have " + Car.stock + " cars in stock:");
            //Console.WriteLine("Make: {0} Model: {1} Price: £{2}", A5TNMTN.make, A5TNMTN.model, A5TNMTN.price);
            //A5TNMTN.DisplayCar();
            //RENAU1T.DisplayCar();
            //FOCU5R5.DisplayCar();
            //MRCACL5.DisplayCar();

            Car.DisplayAvailableStock(allStock);
            Car.TotalSales(allStock);
            MRCACL5.SellCar();
            Car.DisplayAvailableStock(allStock);
            Car.TotalSales(allStock);




        }
    }
}
