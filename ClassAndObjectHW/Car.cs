namespace ClassAndObjectHW
{
    public class Car
    {
        public string CarBrand { get; set; }
        public int CarNumber { get; set; }
        public int CarSpeed { get; set; }


        public void StartCar()
        {
            Console.WriteLine($"Start driving your {CarBrand}.");
        }

        public void SppedUpF()
        {
            int SpeedUp = CarSpeed + 10; 

            Console.WriteLine($"Speed up to {SpeedUp}");
        }

        public void StopCar()
        {
            Console.WriteLine($"Stop driving your {CarBrand}.");
        }

        public void Signal()
        {
            Console.WriteLine("Beep-beep");
        }
    }
}
