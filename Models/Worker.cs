namespace FirstBlazorApp.Models
{
    public class Worker
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Boss { get; set; }
        public double Wage { get; set; }

        public Worker(string firstname, string lastname, string boss, double wage)
        {
            Firstname = firstname;
            Lastname = lastname;
            Boss = boss;
            Wage = wage;
        }
    }
}
