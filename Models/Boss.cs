namespace FirstBlazorApp.Models
{
    public class Boss
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Boss(string firstname, string lastname, string department, double salary)
        {
            Firstname = firstname;
            Lastname = lastname;
            Department = department;
            Salary = salary;
        }
    }
}
