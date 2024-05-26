using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_House
{
    public class Team 
    {
        public List<IWorker> workers;        
        public Team()
        {
            workers = new List<IWorker>();
        }
        public void BuildHouse(House house)
        {
            foreach(var worker in workers)
            {
                worker.Work(house);
                if (house.IsComplete())
                {
                    break;
                }
                
            }
            
        }
    }
}
