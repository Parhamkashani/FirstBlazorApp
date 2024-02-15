namespace FirstBlazorApp.Models
{
    public class Boss
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Boss() {}
        public Boss(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Department = "Pending";
            Salary = 0;
        }
        public Boss(int id, string firstname, string lastname, string department, double salary)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Department = department;
            Salary = salary;
        }
    }
}
