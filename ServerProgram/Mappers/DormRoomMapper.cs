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
        public static void CreateDormRoom(DormRoom room)
        {
            var context = new CampusContext();
            context.DormRoom.Add(room);
            context.SaveChanges();
        }
    }
}
