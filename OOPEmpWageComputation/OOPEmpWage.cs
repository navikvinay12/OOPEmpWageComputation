namespace OOPEmpWageComputation
{
    internal class OOPEmpWage
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 20;
        const int MAX_HRS_IN_MONTH = 100;
        public static void Welcome()
        {
            Console.WriteLine("Welcome to EmployeeWage Computation Program");
        }
        public static void EmpWage20Day()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while(totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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
                totalEmpHrs+=empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "  " + "Working Hours : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine($"totalEmpHrs : {totalEmpHrs}  *  EMP_RATE_PER_HOUR : {EMP_RATE_PER_HOUR} = totalEmpWage : {totalEmpWage}");
        }
        public static void Main(string[] args)
        {
            Welcome();
            EmpWage20Day();
        }
    }
}