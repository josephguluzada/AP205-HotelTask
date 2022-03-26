using HotelTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelTask.Models
{
    public class Hotel
    {
        public string Name { get; set; }
        public Room[] _rooms = new Room[0];

        public Hotel(string name)
        {
            Name = name;
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length+1);
            _rooms[_rooms.Length - 1] = room;
        }

        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
                throw new NullReferenceException("Bele bir otaq movcud deyil");

            foreach (Room room in _rooms)
            {
                if(room.Id == roomId)
                {
                    if (room.IsAvailable == true)
                        room.IsAvailable = false;
                    else
                        throw new NotAvailableException("Otaq hal hazirda movcud deyil!");
                }
            }
        }

    }
}
