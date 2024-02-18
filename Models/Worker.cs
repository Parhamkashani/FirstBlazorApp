namespace FirstBlazorApp.Models
{
    public class Worker : Employee
    {
        public string Boss { get; set; }
        public double Wage { get; set; }

        public Worker() {}

        public Worker(int id, string firstname, string lastname,string boss, double wage, int age, string skill) : base(id, firstname, lastname, age, skill)
        {
            Boss = boss;
            Wage = wage;
        }

    }
}
