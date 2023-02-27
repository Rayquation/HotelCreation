namespace HotelCreation
{
    internal class Bruger
    {
        public VVS vvsmand { get; set; } = new VVS();
        public Hotel hotel { get; set; } = new Hotel();
        public void MakeHotel()
        {
            Console.WriteLine("Hvor mange etager skal der være i hotelet");
            int floor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvor mange værelser skal der være på hvert etage");
            int rooms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvad er locationen");
            string location = Console.ReadLine();

            this.hotel.Floor = floor;
            this.hotel.RoomsPrFloor = rooms;
            this.hotel.Location = location;
            for (int i = 0;i < rooms; i++)
            {
                MakeApartment();
                Console.WriteLine($"\nTilstanden af toilet nr {this.hotel.mainRooms.IndexOf(this.hotel.mainRooms[i])} er {this.hotel.mainRooms[i].subRooms.Bathroom.IsBroken}");
            }
            foreach (var room in this.hotel.mainRooms)
            {
                
                if (room.subRooms.Bathroom.IsBroken == true)
                {
                    room.subRooms.Bathroom.IsBroken= vvsmand.ToiletFixed(this.hotel.mainRooms.IndexOf(room));
                }
            }
        }
        public void MakeApartment()
        { 
            Random rand = new Random();
            int tmp = rand.Next(1, 3);
            if (tmp == 2)
            {
                this.hotel.mainRooms.Add(new MainRoom
                {
                    IsAvailable = true,
                    subRooms = new SubRoom(true)
                });
            }
            else
            {
                this.hotel.mainRooms.Add(new MainRoom
                {
                    IsAvailable = true,
                    subRooms = new SubRoom(false)
                });
            }


        }
    }

}
