namespace HW_6_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team();       
            team.workers.Add(new Worker());
            team.workers.Add(new Worker());
            team.workers.Add(new Worker());
            TeamLiader teamLiader = new TeamLiader();
           
                     
            team.BuildHouse(house);
            teamLiader.Work(house);
            if(house.IsComplete())
            {
                Console.WriteLine("Дом построен!");
            }
            house.Print();






        }
    }
}
