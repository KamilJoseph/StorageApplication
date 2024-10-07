namespace StorageApplication
{
    public class Vehicle
    {
        string brand;
        string license_plate;
        float engine_litre;

        public Vehicle(string Brand, string License_Plate, float Engine_Litre)
        {
                this.brand = Brand;
                this.license_plate = License_Plate;
                this.engine_litre = Engine_Litre;
        }

        public string get_brand()
        {
            return brand;
        }

        public string get_license_plate()
        {
            return license_plate;
        }

        public float get_engine_litre() 
        { 
            return engine_litre;
        }

        public void Display()
        {
            Console.WriteLine($"Brand: {get_brand()}, License Plate: {get_license_plate()}, Engine Size: {get_engine_litre()}L");
        }
    }
}

