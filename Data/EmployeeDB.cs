using FirstBlazorApp.Models;
using System.Runtime.CompilerServices;

namespace FirstBlazorApp.Data
{
    public class EmployeeDB
    {
        private List<Boss> _bosses = new List<Boss>()
        { 
            new Boss(1, "Damien", "Weatherley", "Programming", 100000, 30, "Webdesigning"),
            new Boss(2, "Parham", "Kashani", "CEO", 1000000, 27, "Management"),
        };

        public List<Worker> _workers = new List<Worker>()
        {
            new Worker(3, "Alex", "England", "Damien Weatherley", 28.5, 36, "Accountant"),
            new Worker(4, "Bob", "Scotland", "Damien Weatherley", 20, 25, "Selling"),
            new Worker(5, "Sally", "Wales", "Damien Weatherley", 25, 22, "Handling"),
            new Worker(6, "Tony", "Ireland", "Damien Weatherley", 43, 29, "Comment"),
        };

        public List<Worker> GetWorkers()
        {
            return _workers;
        }

        public List<Boss> GetBosses()
        {
            return _bosses;
        }

        public List<Employee> GetEmployees()
        {
            var list = new List<Employee>();

            _workers.ForEach(w => list.Add(w));
            _bosses.ForEach(b => list.Add(b));

            return list;
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

        public Employee GetEmployeeByID(int id)
        {
            List<Employee> _employee = GetEmployees();
            Employee e = _employee.Find(x => x.Id == id) ?? new Employee(); ;

            return e;
        }
        
    }
}
