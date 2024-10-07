namespace StorageApplication
{
    public class Bike : Vehicle
    {
        private int wheels;

        // Constructor that takes parameters for both the Bike and its base Vehicle
        public Bike(string brand, string license_plate, float engine_litre, int wheels)
            : base(brand, license_plate, engine_litre) // Call the base constructor
        {
            this.wheels = wheels;
        }

        public int GetWheels()
        {
            return wheels;
        }

     
    }

 }

