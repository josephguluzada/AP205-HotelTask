using HotelTask.Models;
using System;

namespace HotelTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("Sun",50,1);
            Room room2 = new Room("Moon",30,2);

            //Console.WriteLine(room1.ToString());
            //Console.WriteLine(room2.ToString());

            Hotel hotel = new Hotel("SunMoon");

            hotel.AddRoom(room1);
            hotel.AddRoom(room2);

            foreach (var item in hotel._rooms)
            {
                Console.WriteLine(item.ToString());
            }

            hotel.MakeReservation(2);

            foreach (var item in hotel._rooms)
            {
                Console.WriteLine(item.ToString());
            }

            hotel.MakeReservation(2);
        }
    }
}
