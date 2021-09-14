namespace Ex1
{
    public abstract class Employee
    {
        public string Name { get; set; }
        
        

        protected Employee(string name)
        {
            Name = name;
        }
        

        public abstract double GetMonthlySalary();
    }
}