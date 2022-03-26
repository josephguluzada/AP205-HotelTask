using System;
using System.Collections.Generic;
using System.Text;

namespace HotelTask.Models
{
    public class Room
    {
        private static int _id = 0;

        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }

        private Room()
        {
            ++_id;
            Id = _id;
            IsAvailable = true;
        }

        public Room(string name,double price,int personCapacity):this()
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }

        public string ShowInfo()
        {
            return $"Id: {Id} Name:{Name} Price: {Price} Person Capacity: {PersonCapacity} Availibility: {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
