using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProgram.Entities;

namespace ServerProgram.Mappers
{
    class DormRoomMapper
    {

        private static readonly CampusContext context = new CampusContext();

        public static void CreateDormRoom(DormRoom room)
        {
            context.DormRoom.Add(room);
            context.SaveChanges();
        }

        public static List<DormRoom> ReadAllRooms()
        {
            return context.DormRoom.ToList();
        }

        /// <summary>
        /// Check the capacity of the room by roomid
        /// </summary>
        /// <param name="roomid"></param>
        public static int GetRoomCapacityByID(int roomid)
        {
            var capacity = from room in context.DormRoom
                                     where room.RoomID == roomid 
                                     select room.Capacity;
            return capacity.FirstOrDefault();
        }
    }
}
