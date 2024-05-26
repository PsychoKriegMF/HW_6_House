using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_House
{
    public class TeamLiader : IWorker
    {
        public void Work(House house)
        {
            Console.WriteLine("Отчет о выполненом строительстве.");
            Console.WriteLine($"Фундамент: {(house.Basement.IsBuilt ? "построен" : "не построен")}");
            Console.WriteLine($"Стены: {(house.Walls.TrueForAll(w => w.IsBuilt) ? "построены" : "не построены")}");
            Console.WriteLine($"Окна: {(house.Windows.TrueForAll(w => w.IsBuilt) ? "построены" : "не построены")}");
            Console.WriteLine($"Дверь: {(house.Door.IsBuilt ? "вставлена" : "не вставлена")}");
            Console.WriteLine($"Крыша: {(house.Roof.IsBuilt ? "построена" : "не построена")}");
        }
    }
}
