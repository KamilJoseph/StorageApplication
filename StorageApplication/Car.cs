namespace StorageApplication
{
    public class Car : Vehicle
    {
        private int doors;
        private int seats;

        // Constructor that calls the base class constructor
        public Car(string brand, string license_plate, float engine_litre, int doors, int seats)
            : base(brand, license_plate, engine_litre) // Call the base constructor
        {
            this.doors = doors;
            this.seats = seats;
        }

        // Getters for doors and seats
        public int GetDoors()
        {
            return doors;
        }

        public int GetSeats()
        {
            return seats;
        }

       
    }


}
