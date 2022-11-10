namespace OOPEmpWageComputation
{
    internal class OOPEmpWage
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 20;
        public static void Welcome()
        {
            Console.WriteLine("Welcome to EmployeeWage Computation Program");
        }
        public static void EmpWage20Day()
        {
            int empHrs = 0, empWage = 0, TotalEmpWage = 0;
            for (int days = 1; days <= NUM_OF_WORKING_DAYS; days++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = EMP_RATE_PER_HOUR * empHrs;
                TotalEmpWage += empWage;
            }
            Console.WriteLine("Employee Wage for 20 Days is : " + TotalEmpWage);
        }
        public static void Main(string[] args)
        {
            Welcome();
            EmpWage20Day();
        }
    }
}