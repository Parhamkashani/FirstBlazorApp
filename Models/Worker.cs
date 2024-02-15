namespace FirstBlazorApp.Models
{
    public class Worker
    {
        public string Firstname;
        public string Lastname;
        public string Boss;
        public double Wage;

        public Worker(string firstname, string lastname, string boss, double wage)
        {
            Firstname = firstname;
            Lastname = lastname;
            Boss = boss;
            Wage = wage;
        }
    }
}
