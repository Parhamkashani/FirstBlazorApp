namespace FirstBlazorApp.Models
{
    public class Boss : Employee
    {
        public string Department { get; set; }
        public double Salary { get; set; }

        public Boss() {}
        public Boss(int id, string firstname, string lastname, string department, double salary, int age, string skill) : 
            base(id, firstname, lastname, age, skill)
        {
            Department = department;
            Salary = salary;
        }
    }
}
