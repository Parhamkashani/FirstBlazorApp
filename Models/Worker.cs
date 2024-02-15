namespace FirstBlazorApp.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Boss { get; set; }
        public double Wage { get; set; }

        public Worker() {}

        public Worker(int id, string firstname, string lastname, string boss, double wage)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Boss = boss;
            Wage = wage;
        }
    }
}
