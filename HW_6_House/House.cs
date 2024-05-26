using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_House
{
    public class House
    {
        public Basement Basement { get; set; }
        public List<Walls> Walls { get; set; }
        public List<Window> Windows { get; set; }
        public Door Door { get; set; }
        public Roof Roof { get; set; }

        public House()
        {
            Basement = new Basement();
            Walls = new List<Walls>();
            Windows = new List<Window>();
            Door = new Door();
            Roof = new Roof();
        }
        public bool IsComplete()
        {
            return Basement.IsBuilt && Walls.TrueForAll(w => w.IsBuilt) && Windows.TrueForAll(w => w.IsBuilt) && Door.IsBuilt && Roof.IsBuilt;
        }

        public void Print()
        {
            // максимально лень сидеть с циками
            Console.WriteLine("\n       ############################");
            Console.WriteLine("     ################################");
            Console.WriteLine("   ####################################");
            Console.WriteLine("##########################################");
            Console.WriteLine("##########################################");
            Console.WriteLine("##########################################");
            Console.WriteLine("##### о        ###########################");
            Console.WriteLine("#####  к       ###########################");
            Console.WriteLine("#####   н      ################        ###");
            Console.WriteLine("#####    о     ################    д   ###");
            Console.WriteLine("#####          ################    в   ###");
            Console.WriteLine("###############################    е   ###");
            Console.WriteLine("###############################    р   ###");
            Console.WriteLine("###############################    ь   ###");
            Console.WriteLine("###############################        ###");
            Console.WriteLine("###############################        ###");
            Console.WriteLine("###############################        ###");
            Console.WriteLine("###############################        ###");
            Console.WriteLine("##########################################");
            Console.WriteLine("\nА другие три окна на других стенах... Честно....");

        }

    }
}
