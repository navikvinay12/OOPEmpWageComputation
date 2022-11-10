namespace OOPEmpWageComputation
{
    internal class OOPEmpWage
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        public static void Welcome()
        {
            Console.WriteLine("Welcome to EmployeeWage Computation Program");
        }
        public static void EmpWagePerDay()
        {
            int empHrs = 0, empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Full Time Employee is Present");
                empHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Part Time Employee is Present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Employee Wage : " + empWage);
        }
        public static void Main(string[] args)
        {
            Welcome();
            EmpWagePerDay();
        }
    }
}