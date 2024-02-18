namespace FirstBlazorApp.Models
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Skill { get; set; }
        public Employee() { }
        public Employee(int id, string firstname, string lastname, int age, string skill)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Skill = skill;
        }
    }
}
