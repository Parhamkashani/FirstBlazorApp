namespace FirstBlazorApp.Models
{
    public class Boss
    {
        public string Firstname;
        public string Lastname;
        public string Department; 
        public double Salary;

        public Boss(string firstname, string lastname, string department, double salary)
        {
            Firstname = firstname;
            Lastname = lastname;
            Department = department;
            Salary = salary;
        }
    }
}
