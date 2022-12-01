using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RoomHotel
{
    internal class Hotel
    {
        public Hotel(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        private Room[] Rooms = new Room[0];

        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = room;
        }

        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                for (int i = 0; i < Rooms.Length; i++)
                {
                    if (Rooms[i].Id == roomId)
                    {
                        if (Rooms[i].IsAvailable == false)
                        {

                            throw new NotAvailableException("Not Available.");
                        }
                        else
                        {
                            Rooms[i].IsAvailable = false;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have reserved this room.");
                        }
                    }
                }
            }
        }
    }
}
