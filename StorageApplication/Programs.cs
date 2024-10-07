using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StorageApplication
{

    class Programs
    {
        public static void add_vehicle()
        {


        }

        public static void remove_vehicle() 
        { 
        

        }

        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to vehicle application systemn:\n" + "______________________________________\n" + "1) Add Vehicle\n" + "2) Remove Vehicle\n" + "3) Search for a Vehicle\n" + "4) Sort Vehicle by registration number" );
            Console.WriteLine();


            var volxwagan = new Car("Volxwagan", "WQRTY123", 1.5f, 4, 5);
            var bmw = new Car("BMW", "RT5678Y", 1.5f, 4, 5);
            var mountainBike = new Bike("Giant", "BIKE123", 0.0f, 2);
            var roadBike = new Bike("Trek", "BIKE456", 0.0f, 2);

            // Create a list of Vehicle to hold both Car and Bike instances
            List<Vehicle> vehicles = new List<Vehicle>
            {
            new Car("Volxwagan", "WQRTY123", 1.5f, 4, 5),
            new Car("BMW", "RT5678Y", 1.5f, 4, 5),
            new Bike("Giant", "BIKE123", 0.0f, 2),
            new Bike("Trek", "BIKE456", 0.0f, 2)
            };

            // Display information about the vehicles
            foreach (var vehicle in vehicles)
            {
                vehicle.Display();
            }


            // Add on the vehicle management applications below


        }
    }
}
