using ServerProgram.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram.Mappers
{
    class BuildingMapper
    {
        public void CreateBuilding(Building building)
        {
            var context = new CampusContext();
            context.Building.Add(building);
            context.SaveChanges();
        }
    }
}
