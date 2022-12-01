using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace RoomHotel
{
    internal class Room
    {
        private static int count;
        public Room(string name,double price, int personCapacity)
        {
            count++;
            this.Id = count;
            this.Name = name;
            this.Price = price;
            this.PersonCapacity = personCapacity;
        }
        public int Id { get;}
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable=true;


        public string ShowInfo()
        {
            return $"Room ID:         {Id}\nRoom name:       {Name}\nRoom price:      {Price} $\nPerson capacity: {PersonCapacity}\nAvailable:       {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo(); 
        }
    }
}
