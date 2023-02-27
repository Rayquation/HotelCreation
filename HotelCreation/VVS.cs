namespace HotelCreation
{
    internal class VVS : Toilet
    {
        public bool IsBroken { get; set; }
        public bool ToiletFixed(int index)
        {
            Console.WriteLine($"\nThe vvs has seen and fixed toilet {index} problem");
            return false;
            
        }
    }
}
