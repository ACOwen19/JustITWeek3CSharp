using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesObjectsFieldExercise
{

    class Vehicle
    {
        public string make;
        public string model;
        public bool turbo;
        public int price;
        public bool sold;
        public int doors;
        public string vehicleType;
        //public static List<Vehicle> allStock = new List<Vehicle>();
        // DON'T Try to manage the class within the class
        public static int stock = 0;
        public static int salesTotal = 0;

        public Vehicle(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.doors = 4;
            sold = false;
            turbo = false;
            //allStock.Add(this);
            // DON'T Try to manage
            Vehicle.stock += 1;
        }

        public Vehicle(string make, string model, int price, string hasTurbo)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            turbo = true;
            this.doors = 4;
            sold = false;
            Vehicle.stock += 1;
        }
        public Vehicle(string make, string model, int price, int doors)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            turbo = false;
            this.doors = doors;
            sold = false;
            Vehicle.stock += 1;
        }


        public void DisplayVehicle()
        {
            Console.WriteLine("Type: {5} Make: {0} Model: {1} Price: £{2} Turbo: {3} Doors: {4}", make, model, price, turbo, doors, vehicleType);
        }

        public void SellVehicle()
        {
            sold = true;
            Vehicle.stock -= 1;
        }

        public static void DisplayAvailableStock(List<Vehicle> allStock)
        {
            Console.WriteLine("We have " + Vehicle.stock + " Vehicles in stock:");

            for (int i = 0; i < allStock.Count; i += 1)
            {
                if (allStock[i].sold == false)
                {
                    allStock[i].DisplayVehicle();
                }
            }
        }

        public static void TotalSales(List<Vehicle> allStock)
        {
            for (int i = 0; i < allStock.Count; i += 1)
            {

                if (allStock[i].sold == true)
                {
                    salesTotal += allStock[i].price;
                }
            }
            Console.WriteLine("We have sold £{0:N0} worth of Vehicles", salesTotal);
        }
        // :N0 will format the number to be currency supposedly
        public virtual void Wheels()
        {
            Console.WriteLine("A vehicle has a number of wheels");
        }


    }

    class Car : Vehicle
    {
        public static int carCount;


        public Car(string make, string model, int price) : base(make, model, price)
        {
            vehicleType = "Car";
            carCount += 1;
        }

        public Car(string make, string model, int price, string hasTurbo) : base(make, model, price, hasTurbo)
        {
            vehicleType = "Car";
            carCount += 1;
        }

        public Car(string make, string model, int price, int doors) : base(make, model, price, doors)
        {
            vehicleType = "Car";
            carCount += 1;
        }

        public override void Wheels()
        {
            Console.WriteLine("A car has 4 wheels");
        }

    }

    class ThreeWheeler : Car
    {


        public ThreeWheeler(string make, string model, int price) : base(make, model, price)
        {
            vehicleType = "Car";
            carCount += 1;
        }

        public ThreeWheeler(string make, string model, int price, string hasTurbo) : base(make, model, price, hasTurbo)
        {
            vehicleType = "Car";
            carCount += 1;
        }

        public ThreeWheeler(string make, string model, int price, int doors) : base(make, model, price, doors)
        {
            vehicleType = "Car";
            carCount += 1;
        }

        public override void Wheels()
        {
            Console.WriteLine("A Three Wheeler has 3 wheels");
        }

    }

    class Motorcycle : Vehicle
    {
        public static int bikeCount;


        public Motorcycle(string make, string model, int price) : base(make, model, price)
        {
            vehicleType = "Motorcycle";
            doors = 0;
            bikeCount += 1;
        }

        public Motorcycle(string make, string model, int price, string hasTurbo) : base(make, model, price, hasTurbo)
        {
            vehicleType = "Motorcycle";
            doors = 0;
            bikeCount += 1;
        }

        public Motorcycle(string make, string model, int price, int doors) : base(make, model, price, doors)
        {
            vehicleType = "Motorcycle";
            this.doors = 0;
            bikeCount += 1;
        }

        public override void Wheels()
        {
            Console.WriteLine("A bike has 2 wheels");
        }
    }

    class HGV : Vehicle
    {
        public static int HGVCount;


        public HGV(string make, string model, int price) : base(make, model, price)
        {
            vehicleType = "HGV";
            doors = 2;
            HGVCount += 1;
        }

        public HGV(string make, string model, int price, string hasTurbo) : base(make, model, price, hasTurbo)
        {
            vehicleType = "HGV";
            doors = 2;
            HGVCount += 1;
        }

        public HGV(string make, string model, int price, int doors) : base(make, model, price, doors)
        {
            vehicleType = "HGV";
            this.doors = 2;
            HGVCount += 1;
        }

        public new void Wheels()
        {
            Console.WriteLine("A truck has 8 wheels");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> allStock = new List<Vehicle>();

            Vehicle A5TNMTN = new Car("Aston Martin", "DB9", 75000, 2);
            //A5TNMTN.make = "Aston Martin";
            //A5TNMTN.model = "DB9";
            //A5TNMTN.price = 75000;
            //A5TNMTN.sold = false;
            //Vehicle.stock += 1;
            allStock.Add(A5TNMTN);


            Vehicle RENAU1T = new Car("Renault", "Clio", 2500);
            //RENAU1T.AddVehicle("Renault", "Clio", 2500);
            allStock.Add(RENAU1T);

            Vehicle FOCU5R5 = new Car("Ford", "Focus RS", 20000, "Turbo");
            //FOCU5R5.AddVehicle("Ford", "Focus RS", 20000);
            allStock.Add(FOCU5R5);

            Vehicle MRCACL5 = new Car("Mercedes", "A Class", 30000);
            //MRCACL5.AddVehicle("Mercedes","A Class", 30000);
            allStock.Add(MRCACL5);

            Vehicle HNDA8KE = new Motorcycle("Honda", "Superbike", 50000);
            allStock.Add(HNDA8KE);

            Vehicle RLNTR8N = new ThreeWheeler("Reliant", "Robin", 15000);
            allStock.Add(RLNTR8N);

            HGV VOLVOFH = new HGV("Volvo", "FH", 115000);
            allStock.Add(VOLVOFH);
            //Console.WriteLine("We have " + Vehicle.stock + " Vehicles in stock:");
            //Console.WriteLine("Make: {0} Model: {1} Price: £{2}", A5TNMTN.make, A5TNMTN.model, A5TNMTN.price);
            //A5TNMTN.DisplayVehicle();
            //RENAU1T.DisplayVehicle();
            //FOCU5R5.DisplayVehicle();
            //MRCACL5.DisplayVehicle();

            foreach (Vehicle v in allStock)
            {
                Console.WriteLine(v.GetType() + ":");
                v.Wheels();
            }
            // VOLVOFH hasn't been cast as a vehicle so because we are using the new method for the HGV class 
            // when it is called using foreach vehicle it won't call the hgv wheels method
            // If we call the wheels method for specifically VOLVOFH because its an HGV then it will call the HGV method
            Console.WriteLine(VOLVOFH.GetType() + ":");
            VOLVOFH.Wheels();

            Vehicle.DisplayAvailableStock(allStock);
            Vehicle.TotalSales(allStock);
            MRCACL5.SellVehicle();
            HNDA8KE.SellVehicle();
            Vehicle.DisplayAvailableStock(allStock);
            Vehicle.TotalSales(allStock);




        }
    }
}
