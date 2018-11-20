using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram.Mappers
{
    class FloorMapper
    {
        public void CreateFloor(Floor floor)
        {
            var context = new CampusContext();
            context.Floor.Add(floor);
            context.SaveChanges();
        }
    }
}
