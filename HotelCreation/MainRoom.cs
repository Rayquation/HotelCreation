namespace HotelCreation
{
    internal class MainRoom
    {
        public bool IsAvailable { get; set; }
        public SubRoom subRooms { get; set; }
        public override string ToString()
        {
            if (IsAvailable == true)
            {
                return $"Jeg er ledig";
            }
            else
            {
                return $"Jeg er ikke ledig";
            }

        }
    }
}
