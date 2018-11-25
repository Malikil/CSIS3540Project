using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProgram.Entities;

namespace ServerProgram.Mappers
{
    class FloorMapper
    {
        public static void CreateFloor(Floor floor)
        {
            var context = new CampusContext();
            context.Floor.Add(floor);
            context.SaveChanges();
        }
    }
}
