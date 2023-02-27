namespace HotelCreation
{
    internal class SubRoom
    {
        public Bathroom Bathroom { get; set; } = new Bathroom();
        public SubRoom(bool isbroken)
        {
            Bathroom.IsBroken = isbroken;
        }
    }
    public class Bathroom : Toilet
    {
        public bool IsBroken { get; set; }

    }
}
