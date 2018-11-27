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

        public static void DeleteDormRoomByID(int roomid)
        {
            var rooms = from r in context.DormRoom
                        where r.RoomID == roomid
                        select r;
            DormRoom room = rooms.FirstOrDefault();
            if (room != null)
            {
                context.DormRoom.Remove(room);
                context.SaveChanges();
            }
        }

        public static List<DormRoom> GetAllRooms()
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

        public static List<DormRoom> GetAvailableRoomsByDate(DateTime start, DateTime end)
        {
            var reserved = from room in context.DormRoom
                           join reservation in context.Reservation
                               on room.RoomID equals reservation.RoomID
                               into reserves
                           from subres in reserves.DefaultIfEmpty()
                           where subres == null
                                || subres.StartDate > end
                                || subres.EndDate < start
                           select room;
            return reserved.ToList();
        }
    }
}
