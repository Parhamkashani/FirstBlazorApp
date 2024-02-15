using FirstBlazorApp.Models;

namespace FirstBlazorApp.Data
{
    public class EmployeeDB
    {
        private static List<Boss> _bosses = new List<Boss>()
        { 
            new Boss(1, "Damien", "Weatherley", "Programming", 100000),
            new Boss(2, "Parham", "Kashani", "CEO", 1000000),
        };

        private static List<Worker> _workers = new List<Worker>()
        {
            new Worker(3, "Alex", "England", "Damien Weatherley", 30),
            new Worker(4, "Bob", "Scotland", "Damien Weatherley", 20),
            new Worker(5, "Sally", "Wales", "Damien Weatherley", 25),
            new Worker(6, "Tony", "Ireland", "Damien Weatherley", 43),
        };

        public List<Worker> GetWorkers()
        {
            return _workers;
        }

        public List<Boss> GetBosses()
        {
            return _bosses;
        }

        public Boss GetBossByID(int id)
        {
            Boss b = _bosses.Find(x => x.Id == id) ?? new Boss();

            return b;
        }

        public Worker GetWorkerByID(int id)
        {
            Worker w = _workers.Find(x => x.Id == id) ?? new Worker();

            return w;
        }
    }
}
