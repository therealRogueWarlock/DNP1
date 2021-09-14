namespace Ex1
{
    public class FullTimeEmployee : Employee
    {
        
        public double MonthlySalary { get; set; }

        
        public FullTimeEmployee(string name, double monthlySalary) : base(name)
        {
            MonthlySalary = monthlySalary;
        }

        public override double GetMonthlySalary()
        {
            return MonthlySalary;
        }
    }
}