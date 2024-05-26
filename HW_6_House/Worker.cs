using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_House
{
    public class Worker : IWorker
    {
        public void Work(House house)
        {
            if(!house.Basement.IsBuilt)
            {
                house.Basement.Build();
            }
            else if(!house.Walls.TrueForAll(w => w.IsBuilt))
            {
                foreach(var wall in house.Walls)
                {
                    if(!wall.IsBuilt)
                    {
                        wall.Build();
                        break;
                    }

                }
            }
            else if(!house.Windows.TrueForAll(w => w.IsBuilt))
            {
                foreach(var windows in house.Windows)
                {
                    if(!windows.IsBuilt)
                    {
                        windows.Build();
                        break;
                    }
                }
            }
            else if(!house.Door.IsBuilt)
            {
                house.Door.Build();
            }
            else if(!house.Roof.IsBuilt)
            {
                house.Roof.Build();
            }
            else  { Console.WriteLine("Строительство дома завершено"); }
        }
    }
}
